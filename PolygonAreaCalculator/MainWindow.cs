using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Windows.Threading;

namespace PolygonAreaCalculator
{
    public partial class MainWindow : Form
    {
        BackgroundWorker backWorker = new BackgroundWorker();
        
        /// <summary>
        /// Список всех точек в текущем процессе вычислений
        /// </summary>
        List<PolygonPoint> pointsList = new List<PolygonPoint>();
        
        /// <summary>
        /// Конструктор
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();

            backWorker.DoWork += backWorker_DoWork;
            backWorker.WorkerReportsProgress = true;
            backWorker.ProgressChanged += backWorker_ProgressChanged;
            backWorker.RunWorkerCompleted += backWorker_RunWorkerCompleted;
            backWorker.WorkerSupportsCancellation = true;
        }

        /// <summary>
        /// Событие нажатия на кнопку Вычислить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void calculateButton_Click(object sender, EventArgs e)
        {
            pointsList.Clear();
            pointsListTextBox.Clear();
            resultLabel.Text = "---";
            calculateButton.Enabled = false;
            cancelButton.Enabled = true;
            pointsListTextBox.Enabled = false;
            statusLabel.Text = "Подсчет запущен...";

            if (randomRadioButton.Checked)
            {
                progressBar.Value = 0;
                progressBar.Maximum = Convert.ToInt32(pointsCount.Value);
            }

            backWorker.RunWorkerAsync();
        }

        /// <summary>
        /// Событие нажатия на кнопку Отменить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (backWorker.IsBusy)
            {
                backWorker.CancelAsync();
            }
        }

        /// <summary>
        /// Основные вычисления
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            if (manualRadioButton.Checked)
                GetPointsFromList(e);
            else if (randomRadioButton.Checked)
                SetRandomPoints(e);

            if (pointsList == null || pointsList.Count < 3)
                return;

            if (CheckForCancel(e))
                return;

            //--------считаем по формуле площади Гаусса
            double xToy = 0.0;
            double yTox = 0.0;
            for (int i = 0; i < pointsList.Count - 2; i++)
            {
                xToy += pointsList[i].X * pointsList[i + 1].Y;
                yTox += pointsList[i].Y * pointsList[i + 1].X;

                if (CheckForCancel(e))
                    return;
            }

            xToy += pointsList[pointsList.Count - 1].X * pointsList[0].Y;
            yTox += pointsList[pointsList.Count - 1].Y * pointsList[0].X;

            double result = Math.Abs((xToy - yTox) / 2.0);
            //-------------------------------------

            this.Invoke(new Action(() =>
            {
                this.resultLabel.Text = Math.Round(result, 2).ToString();
            }));
        }

        /// <summary>
        /// Функция проверки отмены операции
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        private bool CheckForCancel(DoWorkEventArgs e)
        {
            if (backWorker.CancellationPending)
            {
                e.Cancel = true;
                backWorker.ReportProgress(0);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Функция окончания выполнения операции
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            calculateButton.Enabled = true;
            cancelButton.Enabled = false;
            pointsListTextBox.Enabled = true;

            string message;
            if (e.Cancelled)
            {
                pointsListTextBox.Text = string.Empty;
                message = "Процесс был остановлен пользователем.";
            }
            else if (e.Error != null)
            {
                pointsListTextBox.Text = string.Empty;
                message = "В процессе работы произошла ошибка. Процесс остановлен.";
            }
            else if (pointsList == null || pointsList.Count < 3)
            {
                message = "Количество точек не должно быть меньше 3. Попробуйте снова.";
            }
            else
            {
                message = "Готово.";
            }
            this.Invoke(new Action(() =>
            {
                this.statusLabel.Text = message;
                progressBar.Value = 0;
            }));
        }

        /// <summary>
        /// Событие изменения значения прогресса
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
        }

#pragma warning disable SecurityIntelliSenseCS

        /// <summary>
        /// Подбор случайных значений координат
        /// </summary>
        /// <param name="e"></param>
        private void SetRandomPoints(DoWorkEventArgs e)
        {
            Random rand = new Random();

            for (int i = 0; i < pointsCount.Value; i++)
            {
                pointsList.Add(new PolygonPoint(rand.Next(-100, 100), rand.Next(-100, 100)));
                if (CheckForCancel(e))
                    return;
            }
            DisplayPoints(e);
        }
#pragma warning restore SecurityIntelliSenseCS

        /// <summary>
        /// Чтение значений координат из таблицы
        /// </summary>
        /// <param name="e"></param>
        private void GetPointsFromList(DoWorkEventArgs e)
        {

            for (int i = 0; i < pointsGridView.Rows.Count - 1; i++)
            {
                double resultX;
                double resultY;

                if (!double.TryParse(pointsGridView.Rows[i].Cells[0].FormattedValue.ToString(), out resultX) |
                    !double.TryParse(pointsGridView.Rows[i].Cells[1].FormattedValue.ToString(), out resultY))
                    continue;
                pointsList.Add(new PolygonPoint(resultX, resultY));

                if (CheckForCancel(e))
                    return;
            }
            DisplayPoints(e);
        }

        /// <summary>
         /// Отображение списка координат
         /// </summary>
         /// <param name="e"></param>
        private void DisplayPoints(DoWorkEventArgs e)
        {
            int i = 1;
            foreach (var p in pointsList)
            {
                this.Invoke(new Action(() => {
                    this.pointsListTextBox.Text += $"({p.X}, {p.Y})" + Environment.NewLine;
                }));
                if (CheckForCancel(e))
                    return;

                backWorker.ReportProgress(i++);
            }
        }

        /// <summary>
        /// Событие изменения типа ввода координат
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            manualGroupBox.Enabled = manualRadioButton.Checked;
            randomGroupBox.Enabled = randomRadioButton.Checked;
        }

        /// <summary>
        /// Событие ввода значения в ячейку таблицы координат (double)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pointsGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            double result;
            if (!double.TryParse(e.FormattedValue.ToString(), out result))
            {
                e.Cancel = true;
                pointsGridView.Rows[e.RowIndex].ErrorText = "You have to enter doubles only";
            }
        }

        private void pointsGridView_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            pointsGridView.Rows[e.RowIndex].ErrorText = null;
        }

        /// <summary>
        /// Запрет на закрытие формы во время выполнения процесса
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (backWorker.IsBusy)
            {
                e.Cancel = true;
            }
        }
    }
}

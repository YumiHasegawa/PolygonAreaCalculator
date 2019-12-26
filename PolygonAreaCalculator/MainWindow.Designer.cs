namespace PolygonAreaCalculator
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.calculateButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.manualRadioButton = new System.Windows.Forms.RadioButton();
            this.pointsListTextBox = new System.Windows.Forms.RichTextBox();
            this.mainGroupBox = new System.Windows.Forms.GroupBox();
            this.randomGroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pointsCount = new System.Windows.Forms.NumericUpDown();
            this.randomRadioButton = new System.Windows.Forms.RadioButton();
            this.manualGroupBox = new System.Windows.Forms.GroupBox();
            this.pointsGridView = new System.Windows.Forms.DataGridView();
            this.XColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.cancelButton = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mainGroupBox.SuspendLayout();
            this.randomGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pointsCount)).BeginInit();
            this.manualGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pointsGridView)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(88, 267);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "Вычислить";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultLabel.Location = new System.Drawing.Point(0, 0);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(107, 84);
            this.resultLabel.TabIndex = 1;
            this.resultLabel.Text = "---";
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // manualRadioButton
            // 
            this.manualRadioButton.AutoSize = true;
            this.manualRadioButton.Checked = true;
            this.manualRadioButton.Location = new System.Drawing.Point(6, 22);
            this.manualRadioButton.Name = "manualRadioButton";
            this.manualRadioButton.Size = new System.Drawing.Size(112, 17);
            this.manualRadioButton.TabIndex = 2;
            this.manualRadioButton.TabStop = true;
            this.manualRadioButton.Text = "Указать вручную";
            this.manualRadioButton.UseVisualStyleBackColor = true;
            this.manualRadioButton.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // pointsListTextBox
            // 
            this.pointsListTextBox.Location = new System.Drawing.Point(250, 22);
            this.pointsListTextBox.Name = "pointsListTextBox";
            this.pointsListTextBox.ReadOnly = true;
            this.pointsListTextBox.Size = new System.Drawing.Size(107, 157);
            this.pointsListTextBox.TabIndex = 8;
            this.pointsListTextBox.Text = "";
            // 
            // mainGroupBox
            // 
            this.mainGroupBox.Controls.Add(this.cancelButton);
            this.mainGroupBox.Controls.Add(this.progressBar);
            this.mainGroupBox.Controls.Add(this.panel1);
            this.mainGroupBox.Controls.Add(this.randomGroupBox);
            this.mainGroupBox.Controls.Add(this.pointsListTextBox);
            this.mainGroupBox.Controls.Add(this.calculateButton);
            this.mainGroupBox.Controls.Add(this.manualRadioButton);
            this.mainGroupBox.Controls.Add(this.randomRadioButton);
            this.mainGroupBox.Controls.Add(this.manualGroupBox);
            this.mainGroupBox.Location = new System.Drawing.Point(12, 12);
            this.mainGroupBox.Name = "mainGroupBox";
            this.mainGroupBox.Size = new System.Drawing.Size(367, 301);
            this.mainGroupBox.TabIndex = 9;
            this.mainGroupBox.TabStop = false;
            // 
            // randomGroupBox
            // 
            this.randomGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.randomGroupBox.Controls.Add(this.label2);
            this.randomGroupBox.Controls.Add(this.pointsCount);
            this.randomGroupBox.Enabled = false;
            this.randomGroupBox.Location = new System.Drawing.Point(6, 206);
            this.randomGroupBox.Name = "randomGroupBox";
            this.randomGroupBox.Size = new System.Drawing.Size(238, 57);
            this.randomGroupBox.TabIndex = 14;
            this.randomGroupBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Введите количество точек:";
            // 
            // pointsCount
            // 
            this.pointsCount.Location = new System.Drawing.Point(156, 24);
            this.pointsCount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.pointsCount.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.pointsCount.Name = "pointsCount";
            this.pointsCount.Size = new System.Drawing.Size(74, 20);
            this.pointsCount.TabIndex = 0;
            this.pointsCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pointsCount.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // randomRadioButton
            // 
            this.randomRadioButton.AutoSize = true;
            this.randomRadioButton.Location = new System.Drawing.Point(3, 183);
            this.randomRadioButton.Name = "randomRadioButton";
            this.randomRadioButton.Size = new System.Drawing.Size(112, 17);
            this.randomRadioButton.TabIndex = 13;
            this.randomRadioButton.Text = "Случайные числа";
            this.randomRadioButton.UseVisualStyleBackColor = true;
            this.randomRadioButton.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // manualGroupBox
            // 
            this.manualGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.manualGroupBox.Controls.Add(this.pointsGridView);
            this.manualGroupBox.Location = new System.Drawing.Point(6, 45);
            this.manualGroupBox.Name = "manualGroupBox";
            this.manualGroupBox.Size = new System.Drawing.Size(238, 134);
            this.manualGroupBox.TabIndex = 11;
            this.manualGroupBox.TabStop = false;
            // 
            // pointsGridView
            // 
            this.pointsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pointsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.XColumn,
            this.YColumn});
            this.pointsGridView.Location = new System.Drawing.Point(4, 10);
            this.pointsGridView.Name = "pointsGridView";
            this.pointsGridView.Size = new System.Drawing.Size(228, 118);
            this.pointsGridView.TabIndex = 16;
            this.pointsGridView.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.pointsGridView_CellValidated);
            this.pointsGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.pointsGridView_CellValidating);
            // 
            // XColumn
            // 
            this.XColumn.Frozen = true;
            this.XColumn.HeaderText = "X";
            this.XColumn.Name = "XColumn";
            this.XColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.XColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // YColumn
            // 
            this.YColumn.Frozen = true;
            this.YColumn.HeaderText = "Y";
            this.YColumn.Name = "YColumn";
            this.YColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.YColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(250, 183);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(107, 17);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 2;
            // 
            // cancelButton
            // 
            this.cancelButton.Enabled = false;
            this.cancelButton.Location = new System.Drawing.Point(169, 267);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 16;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 319);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(387, 22);
            this.statusStrip.TabIndex = 10;
            this.statusStrip.Text = "Готово";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(48, 17);
            this.statusLabel.Text = "Готово.";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.resultLabel);
            this.panel1.Location = new System.Drawing.Point(250, 206);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(107, 84);
            this.panel1.TabIndex = 15;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 341);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.mainGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Калькулятор площади многоугольника";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.mainGroupBox.ResumeLayout(false);
            this.mainGroupBox.PerformLayout();
            this.randomGroupBox.ResumeLayout(false);
            this.randomGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pointsCount)).EndInit();
            this.manualGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pointsGridView)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.RadioButton manualRadioButton;
        private System.Windows.Forms.RichTextBox pointsListTextBox;
        private System.Windows.Forms.GroupBox mainGroupBox;
        private System.Windows.Forms.GroupBox randomGroupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown pointsCount;
        private System.Windows.Forms.RadioButton randomRadioButton;
        private System.Windows.Forms.GroupBox manualGroupBox;
        private System.Windows.Forms.DataGridView pointsGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn XColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn YColumn;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.Panel panel1;
    }
}


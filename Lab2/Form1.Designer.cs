namespace Lab2
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Analysisbtn = new System.Windows.Forms.Button();
            this.ChooseDecodeFilebutton = new System.Windows.Forms.Button();
            this.SavaFilebutton = new System.Windows.Forms.Button();
            this.ClearDecodeText = new System.Windows.Forms.Button();
            this.ClearCodeText = new System.Windows.Forms.Button();
            this.RussianFrequency = new System.Windows.Forms.DataGridView();
            this.DecodeTextbox = new System.Windows.Forms.TextBox();
            this.CodeTextbox = new System.Windows.Forms.TextBox();
            this.CodeTextbutton = new System.Windows.Forms.Button();
            this.DecodeTextbutton = new System.Windows.Forms.Button();
            this.ChooseFilebutton = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Matrixdg = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.RandomKeybutton = new System.Windows.Forms.Button();
            this.ClearMatrix = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.OriginalTextFrequency = new System.Windows.Forms.DataGridView();
            this.EncryptedTextFrequency = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.FindKeyButton = new System.Windows.Forms.Button();
            this.FoundedKeyDg = new System.Windows.Forms.DataGridView();
            this.FoundKeyDicrp = new System.Windows.Forms.Button();
            this.ClearFoundedKey = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RussianFrequency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Matrixdg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OriginalTextFrequency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EncryptedTextFrequency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FoundedKeyDg)).BeginInit();
            this.SuspendLayout();
            // 
            // Analysisbtn
            // 
            this.Analysisbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Analysisbtn.Location = new System.Drawing.Point(608, 557);
            this.Analysisbtn.Name = "Analysisbtn";
            this.Analysisbtn.Size = new System.Drawing.Size(85, 39);
            this.Analysisbtn.TabIndex = 31;
            this.Analysisbtn.Text = "Анализ";
            this.Analysisbtn.UseVisualStyleBackColor = true;
            this.Analysisbtn.Click += new System.EventHandler(this.Analysis_Click);
            // 
            // ChooseDecodeFilebutton
            // 
            this.ChooseDecodeFilebutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ChooseDecodeFilebutton.Location = new System.Drawing.Point(990, 349);
            this.ChooseDecodeFilebutton.Name = "ChooseDecodeFilebutton";
            this.ChooseDecodeFilebutton.Size = new System.Drawing.Size(128, 49);
            this.ChooseDecodeFilebutton.TabIndex = 30;
            this.ChooseDecodeFilebutton.Text = "Выбрать файл";
            this.ChooseDecodeFilebutton.UseVisualStyleBackColor = true;
            this.ChooseDecodeFilebutton.Click += new System.EventHandler(this.ChooseDecodeFilebutton_Click);
            // 
            // SavaFilebutton
            // 
            this.SavaFilebutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SavaFilebutton.Location = new System.Drawing.Point(1124, 349);
            this.SavaFilebutton.Name = "SavaFilebutton";
            this.SavaFilebutton.Size = new System.Drawing.Size(128, 49);
            this.SavaFilebutton.TabIndex = 29;
            this.SavaFilebutton.Text = "Сохранить файл";
            this.SavaFilebutton.UseVisualStyleBackColor = true;
            this.SavaFilebutton.Click += new System.EventHandler(this.SavaFilebutton_Click);
            // 
            // ClearDecodeText
            // 
            this.ClearDecodeText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ClearDecodeText.Location = new System.Drawing.Point(757, 357);
            this.ClearDecodeText.Name = "ClearDecodeText";
            this.ClearDecodeText.Size = new System.Drawing.Size(91, 33);
            this.ClearDecodeText.TabIndex = 28;
            this.ClearDecodeText.Text = "Очистить";
            this.ClearDecodeText.UseVisualStyleBackColor = true;
            this.ClearDecodeText.Click += new System.EventHandler(this.ClearDecodeText_Click);
            // 
            // ClearCodeText
            // 
            this.ClearCodeText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ClearCodeText.Location = new System.Drawing.Point(460, 365);
            this.ClearCodeText.Name = "ClearCodeText";
            this.ClearCodeText.Size = new System.Drawing.Size(91, 33);
            this.ClearCodeText.TabIndex = 27;
            this.ClearCodeText.Text = "Очистить";
            this.ClearCodeText.UseVisualStyleBackColor = true;
            this.ClearCodeText.Click += new System.EventHandler(this.ClearCodeText_Click);
            // 
            // RussianFrequency
            // 
            this.RussianFrequency.AllowUserToAddRows = false;
            this.RussianFrequency.AllowUserToDeleteRows = false;
            this.RussianFrequency.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RussianFrequency.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.RussianFrequency.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.RussianFrequency.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RussianFrequency.Location = new System.Drawing.Point(1302, 402);
            this.RussianFrequency.Name = "RussianFrequency";
            this.RussianFrequency.ReadOnly = true;
            this.RussianFrequency.RowHeadersWidth = 51;
            this.RussianFrequency.RowTemplate.Height = 24;
            this.RussianFrequency.Size = new System.Drawing.Size(193, 347);
            this.RussianFrequency.TabIndex = 26;
            // 
            // DecodeTextbox
            // 
            this.DecodeTextbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DecodeTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DecodeTextbox.Location = new System.Drawing.Point(36, 404);
            this.DecodeTextbox.Multiline = true;
            this.DecodeTextbox.Name = "DecodeTextbox";
            this.DecodeTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DecodeTextbox.Size = new System.Drawing.Size(515, 345);
            this.DecodeTextbox.TabIndex = 24;
            // 
            // CodeTextbox
            // 
            this.CodeTextbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CodeTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CodeTextbox.Location = new System.Drawing.Point(757, 404);
            this.CodeTextbox.Multiline = true;
            this.CodeTextbox.Name = "CodeTextbox";
            this.CodeTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CodeTextbox.Size = new System.Drawing.Size(494, 345);
            this.CodeTextbox.TabIndex = 25;
            // 
            // CodeTextbutton
            // 
            this.CodeTextbutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CodeTextbutton.Location = new System.Drawing.Point(588, 421);
            this.CodeTextbutton.Name = "CodeTextbutton";
            this.CodeTextbutton.Size = new System.Drawing.Size(128, 49);
            this.CodeTextbutton.TabIndex = 21;
            this.CodeTextbutton.Text = "Зашифровать";
            this.CodeTextbutton.UseVisualStyleBackColor = true;
            this.CodeTextbutton.Click += new System.EventHandler(this.CodeTextbutton_Click);
            // 
            // DecodeTextbutton
            // 
            this.DecodeTextbutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DecodeTextbutton.Location = new System.Drawing.Point(588, 492);
            this.DecodeTextbutton.Name = "DecodeTextbutton";
            this.DecodeTextbutton.Size = new System.Drawing.Size(128, 49);
            this.DecodeTextbutton.TabIndex = 22;
            this.DecodeTextbutton.Text = "Дешифровать";
            this.DecodeTextbutton.UseVisualStyleBackColor = true;
            this.DecodeTextbutton.Click += new System.EventHandler(this.DecodeTextbutton_Click);
            // 
            // ChooseFilebutton
            // 
            this.ChooseFilebutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ChooseFilebutton.Location = new System.Drawing.Point(36, 341);
            this.ChooseFilebutton.Name = "ChooseFilebutton";
            this.ChooseFilebutton.Size = new System.Drawing.Size(128, 49);
            this.ChooseFilebutton.TabIndex = 23;
            this.ChooseFilebutton.Text = "Выбрать файл";
            this.ChooseFilebutton.UseVisualStyleBackColor = true;
            this.ChooseFilebutton.Click += new System.EventHandler(this.ChooseFilebutton_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(1302, 21);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(591, 326);
            this.chart1.TabIndex = 34;
            this.chart1.Text = "chart1";
            // 
            // Matrixdg
            // 
            this.Matrixdg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Matrixdg.ColumnHeadersVisible = false;
            this.Matrixdg.Location = new System.Drawing.Point(36, 119);
            this.Matrixdg.Name = "Matrixdg";
            this.Matrixdg.RowHeadersVisible = false;
            this.Matrixdg.RowHeadersWidth = 51;
            this.Matrixdg.RowTemplate.Height = 24;
            this.Matrixdg.Size = new System.Drawing.Size(305, 154);
            this.Matrixdg.TabIndex = 35;
            this.Matrixdg.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Matrixdg_CellEndEdit);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(32, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 22);
            this.label1.TabIndex = 36;
            this.label1.Text = "Ключ";
            // 
            // RandomKeybutton
            // 
            this.RandomKeybutton.Location = new System.Drawing.Point(386, 119);
            this.RandomKeybutton.Name = "RandomKeybutton";
            this.RandomKeybutton.Size = new System.Drawing.Size(94, 26);
            this.RandomKeybutton.TabIndex = 37;
            this.RandomKeybutton.Text = "Random";
            this.RandomKeybutton.UseVisualStyleBackColor = true;
            this.RandomKeybutton.Click += new System.EventHandler(this.RandomKeybutton_Click);
            // 
            // ClearMatrix
            // 
            this.ClearMatrix.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ClearMatrix.Location = new System.Drawing.Point(386, 151);
            this.ClearMatrix.Name = "ClearMatrix";
            this.ClearMatrix.Size = new System.Drawing.Size(91, 33);
            this.ClearMatrix.TabIndex = 38;
            this.ClearMatrix.Text = "Очистить";
            this.ClearMatrix.UseVisualStyleBackColor = true;
            this.ClearMatrix.Click += new System.EventHandler(this.ClearMatrix_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown1.Location = new System.Drawing.Point(130, 75);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 27);
            this.numericUpDown1.TabIndex = 39;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // OriginalTextFrequency
            // 
            this.OriginalTextFrequency.AllowUserToAddRows = false;
            this.OriginalTextFrequency.AllowUserToDeleteRows = false;
            this.OriginalTextFrequency.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OriginalTextFrequency.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.OriginalTextFrequency.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.OriginalTextFrequency.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OriginalTextFrequency.Location = new System.Drawing.Point(1720, 402);
            this.OriginalTextFrequency.Name = "OriginalTextFrequency";
            this.OriginalTextFrequency.ReadOnly = true;
            this.OriginalTextFrequency.RowHeadersWidth = 51;
            this.OriginalTextFrequency.RowTemplate.Height = 24;
            this.OriginalTextFrequency.Size = new System.Drawing.Size(188, 345);
            this.OriginalTextFrequency.TabIndex = 40;
            // 
            // EncryptedTextFrequency
            // 
            this.EncryptedTextFrequency.AllowUserToAddRows = false;
            this.EncryptedTextFrequency.AllowUserToDeleteRows = false;
            this.EncryptedTextFrequency.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EncryptedTextFrequency.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.EncryptedTextFrequency.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.EncryptedTextFrequency.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EncryptedTextFrequency.Location = new System.Drawing.Point(1501, 402);
            this.EncryptedTextFrequency.Name = "EncryptedTextFrequency";
            this.EncryptedTextFrequency.ReadOnly = true;
            this.EncryptedTextFrequency.RowHeadersWidth = 51;
            this.EncryptedTextFrequency.RowTemplate.Height = 24;
            this.EncryptedTextFrequency.Size = new System.Drawing.Size(213, 345);
            this.EncryptedTextFrequency.TabIndex = 41;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FindKeyButton
            // 
            this.FindKeyButton.Location = new System.Drawing.Point(608, 602);
            this.FindKeyButton.Name = "FindKeyButton";
            this.FindKeyButton.Size = new System.Drawing.Size(85, 42);
            this.FindKeyButton.TabIndex = 42;
            this.FindKeyButton.Text = "Найти ключ";
            this.FindKeyButton.UseVisualStyleBackColor = true;
            this.FindKeyButton.Click += new System.EventHandler(this.FindKeyButton_Click);
            // 
            // FoundedKeyDg
            // 
            this.FoundedKeyDg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FoundedKeyDg.ColumnHeadersVisible = false;
            this.FoundedKeyDg.Location = new System.Drawing.Point(884, 119);
            this.FoundedKeyDg.Name = "FoundedKeyDg";
            this.FoundedKeyDg.RowHeadersVisible = false;
            this.FoundedKeyDg.RowHeadersWidth = 51;
            this.FoundedKeyDg.RowTemplate.Height = 24;
            this.FoundedKeyDg.Size = new System.Drawing.Size(305, 154);
            this.FoundedKeyDg.TabIndex = 35;
            this.FoundedKeyDg.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Matrixdg_CellEndEdit);
            // 
            // FoundKeyDicrp
            // 
            this.FoundKeyDicrp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FoundKeyDicrp.Location = new System.Drawing.Point(718, 151);
            this.FoundKeyDicrp.Name = "FoundKeyDicrp";
            this.FoundKeyDicrp.Size = new System.Drawing.Size(148, 49);
            this.FoundKeyDicrp.TabIndex = 22;
            this.FoundKeyDicrp.Text = "Дешифровать";
            this.FoundKeyDicrp.UseVisualStyleBackColor = true;
            this.FoundKeyDicrp.Click += new System.EventHandler(this.FoundKeyDicrp_Click);
            // 
            // ClearFoundedKey
            // 
            this.ClearFoundedKey.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ClearFoundedKey.Location = new System.Drawing.Point(718, 206);
            this.ClearFoundedKey.Name = "ClearFoundedKey";
            this.ClearFoundedKey.Size = new System.Drawing.Size(91, 33);
            this.ClearFoundedKey.TabIndex = 38;
            this.ClearFoundedKey.Text = "Очистить";
            this.ClearFoundedKey.UseVisualStyleBackColor = true;
            this.ClearFoundedKey.Click += new System.EventHandler(this.ClearFoundedKey_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(1924, 773);
            this.Controls.Add(this.FindKeyButton);
            this.Controls.Add(this.OriginalTextFrequency);
            this.Controls.Add(this.EncryptedTextFrequency);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.ClearFoundedKey);
            this.Controls.Add(this.ClearMatrix);
            this.Controls.Add(this.RandomKeybutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FoundedKeyDg);
            this.Controls.Add(this.Matrixdg);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.Analysisbtn);
            this.Controls.Add(this.ChooseDecodeFilebutton);
            this.Controls.Add(this.SavaFilebutton);
            this.Controls.Add(this.ClearDecodeText);
            this.Controls.Add(this.ClearCodeText);
            this.Controls.Add(this.RussianFrequency);
            this.Controls.Add(this.DecodeTextbox);
            this.Controls.Add(this.CodeTextbox);
            this.Controls.Add(this.CodeTextbutton);
            this.Controls.Add(this.FoundKeyDicrp);
            this.Controls.Add(this.DecodeTextbutton);
            this.Controls.Add(this.ChooseFilebutton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.RussianFrequency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Matrixdg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OriginalTextFrequency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EncryptedTextFrequency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FoundedKeyDg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Analysisbtn;
        private System.Windows.Forms.Button ChooseDecodeFilebutton;
        private System.Windows.Forms.Button SavaFilebutton;
        private System.Windows.Forms.Button ClearDecodeText;
        private System.Windows.Forms.Button ClearCodeText;
        private System.Windows.Forms.DataGridView RussianFrequency;
        private System.Windows.Forms.TextBox DecodeTextbox;
        private System.Windows.Forms.TextBox CodeTextbox;
        private System.Windows.Forms.Button CodeTextbutton;
        private System.Windows.Forms.Button DecodeTextbutton;
        private System.Windows.Forms.Button ChooseFilebutton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView Matrixdg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RandomKeybutton;
        private System.Windows.Forms.Button ClearMatrix;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DataGridView OriginalTextFrequency;
        private System.Windows.Forms.DataGridView EncryptedTextFrequency;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button FindKeyButton;
        private System.Windows.Forms.DataGridView FoundedKeyDg;
        private System.Windows.Forms.Button FoundKeyDicrp;
        private System.Windows.Forms.Button ClearFoundedKey;
    }
}


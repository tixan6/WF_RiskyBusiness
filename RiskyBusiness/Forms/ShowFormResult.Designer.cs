namespace RiskyBusiness.Forms
{
    partial class ShowFormResult
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lableTEXT = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            Column12 = new DataGridViewTextBoxColumn();
            Column13 = new DataGridViewTextBoxColumn();
            Column14 = new DataGridViewTextBoxColumn();
            Column15 = new DataGridViewTextBoxColumn();
            Column16 = new DataGridViewTextBoxColumn();
            Column17 = new DataGridViewTextBoxColumn();
            Column18 = new DataGridViewTextBoxColumn();
            Column19 = new DataGridViewTextBoxColumn();
            Column20 = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            richTextBox1 = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lableTEXT
            // 
            lableTEXT.AutoSize = true;
            lableTEXT.Location = new Point(12, 2);
            lableTEXT.Name = "lableTEXT";
            lableTEXT.Size = new Size(180, 40);
            lableTEXT.TabIndex = 2;
            lableTEXT.Text = "Выберете организацию \r\nдля расчета";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(193, 12);
            comboBox1.MaxDropDownItems = 20;
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(385, 28);
            comboBox1.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.PaleGreen;
            button1.Location = new Point(584, 7);
            button1.Name = "button1";
            button1.Size = new Size(145, 36);
            button1.TabIndex = 5;
            button1.Text = "Рассчитать";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10, Column11, Column12, Column13, Column14, Column15, Column16, Column17, Column18, Column19, Column20 });
            dataGridView1.Location = new Point(12, 45);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(717, 152);
            dataGridView1.TabIndex = 6;
            // 
            // Column1
            // 
            Column1.HeaderText = "Нименование компании";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "КТЛ";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "КБЛ";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "КАЛ";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Нематериальные активы";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "Основные средства";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 125;
            // 
            // Column7
            // 
            Column7.HeaderText = "Финансовые вложения";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Width = 125;
            // 
            // Column8
            // 
            Column8.HeaderText = "Сумма первого расчета";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.Width = 125;
            // 
            // Column9
            // 
            Column9.HeaderText = "Запасы";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            Column9.Width = 125;
            // 
            // Column10
            // 
            Column10.HeaderText = "НДС";
            Column10.MinimumWidth = 6;
            Column10.Name = "Column10";
            Column10.ReadOnly = true;
            Column10.Width = 125;
            // 
            // Column11
            // 
            Column11.HeaderText = "Дебиторская задолженность";
            Column11.MinimumWidth = 6;
            Column11.Name = "Column11";
            Column11.ReadOnly = true;
            Column11.Width = 125;
            // 
            // Column12
            // 
            Column12.HeaderText = "Фин. влж. Деб. задолженность";
            Column12.MinimumWidth = 6;
            Column12.Name = "Column12";
            Column12.ReadOnly = true;
            Column12.Width = 125;
            // 
            // Column13
            // 
            Column13.HeaderText = "Прочие оборотные активы";
            Column13.MinimumWidth = 6;
            Column13.Name = "Column13";
            Column13.ReadOnly = true;
            Column13.Width = 125;
            // 
            // Column14
            // 
            Column14.HeaderText = "Оценочные обязательства";
            Column14.MinimumWidth = 6;
            Column14.Name = "Column14";
            Column14.ReadOnly = true;
            Column14.Width = 125;
            // 
            // Column15
            // 
            Column15.HeaderText = "Сумма второго расчета";
            Column15.MinimumWidth = 6;
            Column15.Name = "Column15";
            Column15.ReadOnly = true;
            Column15.Width = 125;
            // 
            // Column16
            // 
            Column16.HeaderText = "Заемные средства";
            Column16.MinimumWidth = 6;
            Column16.Name = "Column16";
            Column16.ReadOnly = true;
            Column16.Width = 125;
            // 
            // Column17
            // 
            Column17.HeaderText = "Кредиторская задолжность";
            Column17.MinimumWidth = 6;
            Column17.Name = "Column17";
            Column17.ReadOnly = true;
            Column17.Width = 125;
            // 
            // Column18
            // 
            Column18.HeaderText = "Доходы";
            Column18.MinimumWidth = 6;
            Column18.Name = "Column18";
            Column18.ReadOnly = true;
            Column18.Width = 125;
            // 
            // Column19
            // 
            Column19.HeaderText = "Оцен. обяз.";
            Column19.MinimumWidth = 6;
            Column19.Name = "Column19";
            Column19.ReadOnly = true;
            Column19.Width = 125;
            // 
            // Column20
            // 
            Column20.HeaderText = "Сумма третьего расчета";
            Column20.MinimumWidth = 6;
            Column20.Name = "Column20";
            Column20.ReadOnly = true;
            Column20.Width = 125;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(richTextBox1);
            groupBox1.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 203);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(717, 235);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Оценка финансовых рисков";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(6, 32);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(694, 197);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // ShowFormResult
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(741, 450);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(lableTEXT);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Name = "ShowFormResult";
            Text = "ShowFormResult";
            Load += ShowFormResult_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lableTEXT;
        private ComboBox comboBox1;
        private Button button1;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn Column14;
        private DataGridViewTextBoxColumn Column15;
        private DataGridViewTextBoxColumn Column16;
        private DataGridViewTextBoxColumn Column17;
        private DataGridViewTextBoxColumn Column18;
        private DataGridViewTextBoxColumn Column19;
        private DataGridViewTextBoxColumn Column20;
        private RichTextBox richTextBox1;
    }
}
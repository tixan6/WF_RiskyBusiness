namespace RiskyBusiness
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            PlaceForForms = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            PlaceForForms.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Bisque;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(237, 475);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(15, 64);
            button2.Name = "button2";
            button2.Size = new Size(215, 51);
            button2.TabIndex = 1;
            button2.Text = "Добавить предприятие";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(15, 12);
            button1.Name = "button1";
            button1.Size = new Size(215, 46);
            button1.TabIndex = 0;
            button1.Text = "Список предприятий";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // PlaceForForms
            // 
            PlaceForForms.Controls.Add(label1);
            PlaceForForms.Location = new Point(250, 12);
            PlaceForForms.Name = "PlaceForForms";
            PlaceForForms.Size = new Size(746, 451);
            PlaceForForms.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Kristen ITC", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(95, 192);
            label1.Name = "label1";
            label1.Size = new Size(583, 45);
            label1.TabIndex = 0;
            label1.Text = "Выберите пожалуйста действие";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(1008, 475);
            Controls.Add(PlaceForForms);
            Controls.Add(panel1);
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Расчет";
            panel1.ResumeLayout(false);
            PlaceForForms.ResumeLayout(false);
            PlaceForForms.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Button button1;
        private Panel PlaceForForms;
        private Label label1;
    }
}
namespace WindowsFormsApp1.View
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_start = new System.Windows.Forms.Label();
            this.label_main = new System.Windows.Forms.Label();
            this.label_exit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(954, 297);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(563, 100);
            this.label1.TabIndex = 1;
            this.label1.Text = "Курсовая работа по дисциплине \"Программирование\"\r\n\r\nТема: \"Разработка приложения " +
    "с графическим интерфейсом \"Деканат\"\"\r\n\r\nРазработал: студент группы БИТ 22-11 Ред" +
    "ьков В.Г.";
            // 
            // label_start
            // 
            this.label_start.AutoSize = true;
            this.label_start.Font = new System.Drawing.Font("Constantia", 20F, System.Drawing.FontStyle.Bold);
            this.label_start.Location = new System.Drawing.Point(16, 458);
            this.label_start.Name = "label_start";
            this.label_start.Size = new System.Drawing.Size(154, 49);
            this.label_start.TabIndex = 2;
            this.label_start.Text = "Запуск";
            this.label_start.Click += new System.EventHandler(this.label_start_Click);
            // 
            // label_main
            // 
            this.label_main.AutoSize = true;
            this.label_main.Font = new System.Drawing.Font("Constantia", 20F, System.Drawing.FontStyle.Bold);
            this.label_main.Location = new System.Drawing.Point(327, 458);
            this.label_main.Name = "label_main";
            this.label_main.Size = new System.Drawing.Size(305, 49);
            this.label_main.TabIndex = 3;
            this.label_main.Text = "Главное меню ";
            this.label_main.Click += new System.EventHandler(this.label_main_Click);
            // 
            // label_exit
            // 
            this.label_exit.AutoSize = true;
            this.label_exit.Font = new System.Drawing.Font("Constantia", 20F, System.Drawing.FontStyle.Bold);
            this.label_exit.Location = new System.Drawing.Point(798, 458);
            this.label_exit.Name = "label_exit";
            this.label_exit.Size = new System.Drawing.Size(147, 49);
            this.label_exit.TabIndex = 4;
            this.label_exit.Text = "Выход";
            this.label_exit.Click += new System.EventHandler(this.label_exit_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(978, 544);
            this.Controls.Add(this.label_exit);
            this.Controls.Add(this.label_main);
            this.Controls.Add(this.label_start);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form3";
            this.Text = "Информация о приложении";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_start;
        private System.Windows.Forms.Label label_main;
        private System.Windows.Forms.Label label_exit;
    }
}
namespace CinemaVinogradova
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Сотрудники = new System.Windows.Forms.Button();
            this.Расписание = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Сотрудники
            // 
            this.Сотрудники.BackColor = System.Drawing.Color.White;
            this.Сотрудники.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Сотрудники.Location = new System.Drawing.Point(347, 359);
            this.Сотрудники.Name = "Сотрудники";
            this.Сотрудники.Size = new System.Drawing.Size(151, 47);
            this.Сотрудники.TabIndex = 0;
            this.Сотрудники.Text = "Сотрудники";
            this.Сотрудники.UseVisualStyleBackColor = false;
            this.Сотрудники.Click += new System.EventHandler(this.Сотрудники_Click);
            // 
            // Расписание
            // 
            this.Расписание.BackColor = System.Drawing.Color.White;
            this.Расписание.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Расписание.Location = new System.Drawing.Point(347, 159);
            this.Расписание.Name = "Расписание";
            this.Расписание.Size = new System.Drawing.Size(151, 47);
            this.Расписание.TabIndex = 1;
            this.Расписание.Text = "Расписание";
            this.Расписание.UseVisualStyleBackColor = false;
            this.Расписание.Click += new System.EventHandler(this.Расписание_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(347, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 47);
            this.button1.TabIndex = 2;
            this.button1.Text = "Фильмы";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(347, 225);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 47);
            this.button2.TabIndex = 3;
            this.button2.Text = "Продажа Билетов";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(347, 291);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(151, 47);
            this.button3.TabIndex = 4;
            this.button3.Text = "Статистика";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(851, 530);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Расписание);
            this.Controls.Add(this.Сотрудники);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Главная";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Сотрудники;
        private System.Windows.Forms.Button Расписание;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}


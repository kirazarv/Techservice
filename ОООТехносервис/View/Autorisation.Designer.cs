namespace ОООТехносервис
{
    partial class Autorisation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Autorisation));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.buttonInput = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.Location = new System.Drawing.Point(735, 22);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(161, 41);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(282, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "логин";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLogin.Location = new System.Drawing.Point(351, 156);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(274, 33);
            this.textBoxLogin.TabIndex = 5;
            // 
            // textBoxPass
            // 
            this.textBoxPass.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPass.Location = new System.Drawing.Point(350, 217);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(274, 33);
            this.textBoxPass.TabIndex = 6;
            // 
            // buttonInput
            // 
            this.buttonInput.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInput.Location = new System.Drawing.Point(222, 327);
            this.buttonInput.Name = "buttonInput";
            this.buttonInput.Size = new System.Drawing.Size(437, 89);
            this.buttonInput.TabIndex = 7;
            this.buttonInput.Text = "вход";
            this.buttonInput.UseVisualStyleBackColor = true;
            this.buttonInput.Click += new System.EventHandler(this.buttonInput_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(269, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "пароль";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(322, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Авторизация";
            // 
            // Autorisation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 491);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonInput);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Autorisation";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Autorisation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Button buttonInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}


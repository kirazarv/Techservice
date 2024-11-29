namespace ОООТехносервис.View
{
    partial class WorkRequest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkRequest));
            this.buttonFix = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBoxDevice = new System.Windows.Forms.ComboBox();
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.comboBoxMaster = new System.Windows.Forms.ComboBox();
            this.comboBoxPriority = new System.Windows.Forms.ComboBox();
            this.comboBoxProblem = new System.Windows.Forms.ComboBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.comboBoxStage = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonFix
            // 
            this.buttonFix.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFix.Location = new System.Drawing.Point(378, 448);
            this.buttonFix.Name = "buttonFix";
            this.buttonFix.Size = new System.Drawing.Size(161, 41);
            this.buttonFix.TabIndex = 21;
            this.buttonFix.Text = "Готово";
            this.buttonFix.UseVisualStyleBackColor = true;
            this.buttonFix.Click += new System.EventHandler(this.buttonFix_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(225, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(345, 29);
            this.label4.TabIndex = 20;
            this.label4.Text = "Работа с отдельной заявкой";
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.Location = new System.Drawing.Point(665, 13);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(161, 41);
            this.buttonExit.TabIndex = 19;
            this.buttonExit.Text = "Назад";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Дата подачи";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Оборудование";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(126, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 24;
            this.label3.Text = "Клиент";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(172, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Описание";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(436, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Мастер";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(436, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Длительность";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(436, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Приоритет";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(436, 268);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Этап";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(436, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "Статус выполнения";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(126, 286);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "Комментарий";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(126, 211);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "Проблема";
            // 
            // comboBoxDevice
            // 
            this.comboBoxDevice.FormattingEnabled = true;
            this.comboBoxDevice.Location = new System.Drawing.Point(255, 170);
            this.comboBoxDevice.Name = "comboBoxDevice";
            this.comboBoxDevice.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDevice.TabIndex = 34;
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(255, 251);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(121, 21);
            this.comboBoxClient.TabIndex = 35;
            // 
            // comboBoxMaster
            // 
            this.comboBoxMaster.FormattingEnabled = true;
            this.comboBoxMaster.Location = new System.Drawing.Point(565, 166);
            this.comboBoxMaster.Name = "comboBoxMaster";
            this.comboBoxMaster.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMaster.TabIndex = 37;
            // 
            // comboBoxPriority
            // 
            this.comboBoxPriority.FormattingEnabled = true;
            this.comboBoxPriority.Location = new System.Drawing.Point(565, 231);
            this.comboBoxPriority.Name = "comboBoxPriority";
            this.comboBoxPriority.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPriority.TabIndex = 38;
            // 
            // comboBoxProblem
            // 
            this.comboBoxProblem.FormattingEnabled = true;
            this.comboBoxProblem.Location = new System.Drawing.Point(255, 211);
            this.comboBoxProblem.Name = "comboBoxProblem";
            this.comboBoxProblem.Size = new System.Drawing.Size(121, 21);
            this.comboBoxProblem.TabIndex = 39;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(290, 341);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxDescription.Size = new System.Drawing.Size(340, 80);
            this.textBoxDescription.TabIndex = 40;
            // 
            // textBoxTime
            // 
            this.textBoxTime.Enabled = false;
            this.textBoxTime.Location = new System.Drawing.Point(565, 200);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(121, 20);
            this.textBoxTime.TabIndex = 41;
            // 
            // textBoxComment
            // 
            this.textBoxComment.Enabled = false;
            this.textBoxComment.Location = new System.Drawing.Point(255, 286);
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(121, 20);
            this.textBoxComment.TabIndex = 44;
            // 
            // textBoxDate
            // 
            this.textBoxDate.Enabled = false;
            this.textBoxDate.Location = new System.Drawing.Point(255, 130);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(121, 20);
            this.textBoxDate.TabIndex = 45;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.Enabled = false;
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(565, 133);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(121, 21);
            this.comboBoxStatus.TabIndex = 46;
            // 
            // comboBoxStage
            // 
            this.comboBoxStage.Enabled = false;
            this.comboBoxStage.FormattingEnabled = true;
            this.comboBoxStage.Location = new System.Drawing.Point(565, 265);
            this.comboBoxStage.Name = "comboBoxStage";
            this.comboBoxStage.Size = new System.Drawing.Size(121, 21);
            this.comboBoxStage.TabIndex = 47;
            // 
            // WorkRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 528);
            this.Controls.Add(this.comboBoxStage);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.textBoxComment);
            this.Controls.Add(this.textBoxTime);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.comboBoxProblem);
            this.Controls.Add(this.comboBoxPriority);
            this.Controls.Add(this.comboBoxMaster);
            this.Controls.Add(this.comboBoxClient);
            this.Controls.Add(this.comboBoxDevice);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonFix);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "WorkRequest";
            this.Text = "WorkRequest";
            this.Load += new System.EventHandler(this.WorkRequest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFix;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBoxDevice;
        private System.Windows.Forms.ComboBox comboBoxClient;
        private System.Windows.Forms.ComboBox comboBoxMaster;
        private System.Windows.Forms.ComboBox comboBoxPriority;
        private System.Windows.Forms.ComboBox comboBoxProblem;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.TextBox textBoxComment;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.ComboBox comboBoxStage;
    }
}
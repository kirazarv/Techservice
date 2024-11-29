namespace ОООТехносервис.View
{
    partial class ListRequest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListRequest));
            this.label4 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewRequest = new System.Windows.Forms.DataGridView();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDevice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMaster = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.reportButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequest)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(264, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 29);
            this.label4.TabIndex = 11;
            this.label4.Text = "Список заявок";
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.Location = new System.Drawing.Point(691, 4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(161, 41);
            this.buttonExit.TabIndex = 10;
            this.buttonExit.Text = "Назад";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridViewRequest
            // 
            this.dataGridViewRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRequest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnData,
            this.ColumnDevice,
            this.ColumnClient,
            this.ColumnStatus,
            this.ColumnMaster,
            this.ColumnStage});
            this.dataGridViewRequest.Location = new System.Drawing.Point(12, 119);
            this.dataGridViewRequest.Name = "dataGridViewRequest";
            this.dataGridViewRequest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRequest.Size = new System.Drawing.Size(798, 248);
            this.dataGridViewRequest.TabIndex = 12;
            // 
            // ColumnID
            // 
            this.ColumnID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnID.HeaderText = "Номер заявки";
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.ReadOnly = true;
            // 
            // ColumnData
            // 
            this.ColumnData.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnData.HeaderText = "Дата подачи заявки";
            this.ColumnData.Name = "ColumnData";
            this.ColumnData.ReadOnly = true;
            // 
            // ColumnDevice
            // 
            this.ColumnDevice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnDevice.HeaderText = "Название оборудования";
            this.ColumnDevice.Name = "ColumnDevice";
            this.ColumnDevice.ReadOnly = true;
            // 
            // ColumnClient
            // 
            this.ColumnClient.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnClient.HeaderText = "ФИО Клиента";
            this.ColumnClient.Name = "ColumnClient";
            this.ColumnClient.ReadOnly = true;
            // 
            // ColumnStatus
            // 
            this.ColumnStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnStatus.HeaderText = "Статус заявки";
            this.ColumnStatus.Name = "ColumnStatus";
            this.ColumnStatus.ReadOnly = true;
            // 
            // ColumnMaster
            // 
            this.ColumnMaster.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnMaster.HeaderText = "ФИО Мастера";
            this.ColumnMaster.Name = "ColumnMaster";
            this.ColumnMaster.ReadOnly = true;
            // 
            // ColumnStage
            // 
            this.ColumnStage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnStage.HeaderText = "Этап выполнения";
            this.ColumnStage.Name = "ColumnStage";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(591, 88);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(219, 21);
            this.comboBoxStatus.TabIndex = 13;
            this.comboBoxStatus.SelectedIndexChanged += new System.EventHandler(this.comboBoxStatus_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(482, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Фильтр по статусу";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "поиск по номеру";
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(167, 88);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(143, 20);
            this.textBoxNumber.TabIndex = 16;
            this.textBoxNumber.TextChanged += new System.EventHandler(this.textBoxNumber_TextChanged);
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.Location = new System.Drawing.Point(72, 388);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(161, 41);
            this.addButton.TabIndex = 17;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Visible = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // editButton
            // 
            this.editButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editButton.Location = new System.Drawing.Point(286, 388);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(161, 41);
            this.editButton.TabIndex = 18;
            this.editButton.Text = "Редактировать";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Visible = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // reportButton
            // 
            this.reportButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reportButton.Location = new System.Drawing.Point(473, 388);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(161, 41);
            this.reportButton.TabIndex = 19;
            this.reportButton.Text = "Отчеты";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Visible = false;
            // 
            // ListRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 450);
            this.Controls.Add(this.reportButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.dataGridViewRequest);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ListRequest";
            this.Text = "Список заявок";
            this.Activated += new System.EventHandler(this.ListRequest_Activated);
            this.Load += new System.EventHandler(this.ListRequest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridViewRequest;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnData;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDevice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMaster;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStage;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button reportButton;
    }
}
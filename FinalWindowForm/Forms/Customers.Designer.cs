namespace FinalWindowForm.Forms
{
    partial class Customers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customers));
            this.DgvCustomers = new System.Windows.Forms.DataGridView();
            this.BtnCustomerCreat = new System.Windows.Forms.Button();
            this.BtnCustomerUpdate = new System.Windows.Forms.Button();
            this.BtnCustomerDelete = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DgvCustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvCustomerFullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvCustomerEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvCustomerPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvCustomerStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvCustomers
            // 
            this.DgvCustomers.AllowUserToAddRows = false;
            this.DgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvCustomers.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DgvCustomerId,
            this.DgvCustomerFullname,
            this.DgvCustomerEmail,
            this.DgvCustomerPhone,
            this.DgvCustomerStatus});
            this.DgvCustomers.Location = new System.Drawing.Point(12, 12);
            this.DgvCustomers.Name = "DgvCustomers";
            this.DgvCustomers.Size = new System.Drawing.Size(533, 396);
            this.DgvCustomers.TabIndex = 0;
            this.DgvCustomers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCustomers_CellDoubleClick);
            // 
            // BtnCustomerCreat
            // 
            this.BtnCustomerCreat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnCustomerCreat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCustomerCreat.ForeColor = System.Drawing.Color.Black;
            this.BtnCustomerCreat.Location = new System.Drawing.Point(551, 243);
            this.BtnCustomerCreat.Name = "BtnCustomerCreat";
            this.BtnCustomerCreat.Size = new System.Drawing.Size(216, 51);
            this.BtnCustomerCreat.TabIndex = 1;
            this.BtnCustomerCreat.Text = "Yeni Müştəri Əlavə Et";
            this.BtnCustomerCreat.UseVisualStyleBackColor = false;
            this.BtnCustomerCreat.Click += new System.EventHandler(this.BtnCustomerCreat_Click);
            // 
            // BtnCustomerUpdate
            // 
            this.BtnCustomerUpdate.BackColor = System.Drawing.Color.Chartreuse;
            this.BtnCustomerUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCustomerUpdate.Location = new System.Drawing.Point(551, 300);
            this.BtnCustomerUpdate.Name = "BtnCustomerUpdate";
            this.BtnCustomerUpdate.Size = new System.Drawing.Size(216, 51);
            this.BtnCustomerUpdate.TabIndex = 2;
            this.BtnCustomerUpdate.Text = "Yenilə";
            this.BtnCustomerUpdate.UseVisualStyleBackColor = false;
            // 
            // BtnCustomerDelete
            // 
            this.BtnCustomerDelete.BackColor = System.Drawing.Color.Red;
            this.BtnCustomerDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCustomerDelete.Location = new System.Drawing.Point(551, 357);
            this.BtnCustomerDelete.Name = "BtnCustomerDelete";
            this.BtnCustomerDelete.Size = new System.Drawing.Size(216, 51);
            this.BtnCustomerDelete.TabIndex = 3;
            this.BtnCustomerDelete.Text = "Sil";
            this.BtnCustomerDelete.UseVisualStyleBackColor = false;
            this.BtnCustomerDelete.Click += new System.EventHandler(this.BtnCustomerDelete_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(551, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 208);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // DgvCustomerId
            // 
            this.DgvCustomerId.HeaderText = "Id";
            this.DgvCustomerId.Name = "DgvCustomerId";
            this.DgvCustomerId.Visible = false;
            // 
            // DgvCustomerFullname
            // 
            this.DgvCustomerFullname.HeaderText = "Ad Soyad";
            this.DgvCustomerFullname.Name = "DgvCustomerFullname";
            // 
            // DgvCustomerEmail
            // 
            this.DgvCustomerEmail.HeaderText = "Email";
            this.DgvCustomerEmail.Name = "DgvCustomerEmail";
            // 
            // DgvCustomerPhone
            // 
            this.DgvCustomerPhone.HeaderText = "Telefon";
            this.DgvCustomerPhone.Name = "DgvCustomerPhone";
            // 
            // DgvCustomerStatus
            // 
            this.DgvCustomerStatus.HeaderText = "Vəziyyət";
            this.DgvCustomerStatus.Name = "DgvCustomerStatus";
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 474);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnCustomerDelete);
            this.Controls.Add(this.BtnCustomerUpdate);
            this.Controls.Add(this.BtnCustomerCreat);
            this.Controls.Add(this.DgvCustomers);
            this.Name = "Customers";
            this.Text = "Müşdərilər";
            this.Activated += new System.EventHandler(this.Customers_Activated);
            this.Load += new System.EventHandler(this.Customers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvCustomers;
        private System.Windows.Forms.Button BtnCustomerCreat;
        private System.Windows.Forms.Button BtnCustomerUpdate;
        private System.Windows.Forms.Button BtnCustomerDelete;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvCustomerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvCustomerFullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvCustomerEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvCustomerPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvCustomerStatus;
    }
}
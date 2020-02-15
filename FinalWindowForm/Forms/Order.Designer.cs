namespace FinalWindowForm.Forms
{
    partial class Order
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
            this.TxtSearchCusOr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSearchCusOr = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtSearchBookOr = new System.Windows.Forms.TextBox();
            this.BtnSearchBookOr = new System.Windows.Forms.Button();
            this.DgvOrderSrcBook = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnAddOrder = new System.Windows.Forms.Button();
            this.DgvOrderSrcCus = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DtStartTime = new System.Windows.Forms.DateTimePicker();
            this.DtEndTime = new System.Windows.Forms.DateTimePicker();
            this.LblStartTime = new System.Windows.Forms.Label();
            this.LblEndTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrderSrcBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrderSrcCus)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtSearchCusOr
            // 
            this.TxtSearchCusOr.Location = new System.Drawing.Point(12, 30);
            this.TxtSearchCusOr.Name = "TxtSearchCusOr";
            this.TxtSearchCusOr.Size = new System.Drawing.Size(173, 20);
            this.TxtSearchCusOr.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Müştəri Axtar";
            // 
            // BtnSearchCusOr
            // 
            this.BtnSearchCusOr.BackColor = System.Drawing.Color.Yellow;
            this.BtnSearchCusOr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearchCusOr.ForeColor = System.Drawing.Color.Black;
            this.BtnSearchCusOr.Location = new System.Drawing.Point(86, 62);
            this.BtnSearchCusOr.Name = "BtnSearchCusOr";
            this.BtnSearchCusOr.Size = new System.Drawing.Size(99, 39);
            this.BtnSearchCusOr.TabIndex = 2;
            this.BtnSearchCusOr.Text = "Axtar";
            this.BtnSearchCusOr.UseVisualStyleBackColor = false;
            this.BtnSearchCusOr.Click += new System.EventHandler(this.BtnSearchCusOr_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kitab Axtar";
            // 
            // TxtSearchBookOr
            // 
            this.TxtSearchBookOr.Location = new System.Drawing.Point(12, 149);
            this.TxtSearchBookOr.Name = "TxtSearchBookOr";
            this.TxtSearchBookOr.Size = new System.Drawing.Size(173, 20);
            this.TxtSearchBookOr.TabIndex = 4;
            // 
            // BtnSearchBookOr
            // 
            this.BtnSearchBookOr.BackColor = System.Drawing.Color.Yellow;
            this.BtnSearchBookOr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearchBookOr.ForeColor = System.Drawing.Color.Black;
            this.BtnSearchBookOr.Location = new System.Drawing.Point(86, 185);
            this.BtnSearchBookOr.Name = "BtnSearchBookOr";
            this.BtnSearchBookOr.Size = new System.Drawing.Size(99, 37);
            this.BtnSearchBookOr.TabIndex = 5;
            this.BtnSearchBookOr.Text = "Axtar";
            this.BtnSearchBookOr.UseVisualStyleBackColor = false;
            this.BtnSearchBookOr.Click += new System.EventHandler(this.BtnSearchBookOr_Click);
            // 
            // DgvOrderSrcBook
            // 
            this.DgvOrderSrcBook.AllowUserToAddRows = false;
            this.DgvOrderSrcBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvOrderSrcBook.BackgroundColor = System.Drawing.Color.White;
            this.DgvOrderSrcBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvOrderSrcBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column9});
            this.DgvOrderSrcBook.Location = new System.Drawing.Point(204, 131);
            this.DgvOrderSrcBook.Name = "DgvOrderSrcBook";
            this.DgvOrderSrcBook.Size = new System.Drawing.Size(440, 115);
            this.DgvOrderSrcBook.TabIndex = 7;
           
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Id";
            this.Column4.Name = "Column4";
            this.Column4.Visible = false;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Kitab adı";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Müəllif";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Janr";
            this.Column7.Name = "Column7";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "İcarə qiyməti";
            this.Column9.Name = "Column9";
            // 
            // BtnAddOrder
            // 
            this.BtnAddOrder.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnAddOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddOrder.Location = new System.Drawing.Point(462, 269);
            this.BtnAddOrder.Name = "BtnAddOrder";
            this.BtnAddOrder.Size = new System.Drawing.Size(182, 57);
            this.BtnAddOrder.TabIndex = 8;
            this.BtnAddOrder.Text = "Sifariş Yarat";
            this.BtnAddOrder.UseVisualStyleBackColor = false;
            this.BtnAddOrder.Click += new System.EventHandler(this.BtnAddOrder_Click);
            // 
            // DgvOrderSrcCus
            // 
            this.DgvOrderSrcCus.AllowUserToAddRows = false;
            this.DgvOrderSrcCus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvOrderSrcCus.BackgroundColor = System.Drawing.Color.White;
            this.DgvOrderSrcCus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvOrderSrcCus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column8});
            this.DgvOrderSrcCus.Location = new System.Drawing.Point(204, 12);
            this.DgvOrderSrcCus.Name = "DgvOrderSrcCus";
            this.DgvOrderSrcCus.Size = new System.Drawing.Size(440, 89);
            this.DgvOrderSrcCus.TabIndex = 9;
         
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Fullname";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Email";
            this.Column3.Name = "Column3";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Phone";
            this.Column8.Name = "Column8";
            // 
            // DtStartTime
            // 
            this.DtStartTime.Location = new System.Drawing.Point(204, 274);
            this.DtStartTime.Name = "DtStartTime";
            this.DtStartTime.Size = new System.Drawing.Size(141, 20);
            this.DtStartTime.TabIndex = 10;
            // 
            // DtEndTime
            // 
            this.DtEndTime.Location = new System.Drawing.Point(204, 307);
            this.DtEndTime.Name = "DtEndTime";
            this.DtEndTime.Size = new System.Drawing.Size(141, 20);
            this.DtEndTime.TabIndex = 11;
            // 
            // LblStartTime
            // 
            this.LblStartTime.AutoSize = true;
            this.LblStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStartTime.Location = new System.Drawing.Point(82, 274);
            this.LblStartTime.Name = "LblStartTime";
            this.LblStartTime.Size = new System.Drawing.Size(103, 15);
            this.LblStartTime.TabIndex = 12;
            this.LblStartTime.Text = "Başlama Tarixi";
            // 
            // LblEndTime
            // 
            this.LblEndTime.AutoSize = true;
            this.LblEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEndTime.Location = new System.Drawing.Point(83, 311);
            this.LblEndTime.Name = "LblEndTime";
            this.LblEndTime.Size = new System.Drawing.Size(84, 15);
            this.LblEndTime.TabIndex = 13;
            this.LblEndTime.Text = "Bitmə Tarixi";
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 366);
            this.Controls.Add(this.LblEndTime);
            this.Controls.Add(this.LblStartTime);
            this.Controls.Add(this.DtEndTime);
            this.Controls.Add(this.DtStartTime);
            this.Controls.Add(this.DgvOrderSrcCus);
            this.Controls.Add(this.BtnAddOrder);
            this.Controls.Add(this.DgvOrderSrcBook);
            this.Controls.Add(this.BtnSearchBookOr);
            this.Controls.Add(this.TxtSearchBookOr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnSearchCusOr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtSearchCusOr);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Order";
            this.Text = "Order";
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrderSrcBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrderSrcCus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtSearchCusOr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSearchCusOr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtSearchBookOr;
        private System.Windows.Forms.Button BtnSearchBookOr;
        private System.Windows.Forms.DataGridView DgvOrderSrcBook;
        private System.Windows.Forms.Button BtnAddOrder;
        private System.Windows.Forms.DataGridView DgvOrderSrcCus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DateTimePicker DtStartTime;
        private System.Windows.Forms.DateTimePicker DtEndTime;
        private System.Windows.Forms.Label LblStartTime;
        private System.Windows.Forms.Label LblEndTime;
    }
}
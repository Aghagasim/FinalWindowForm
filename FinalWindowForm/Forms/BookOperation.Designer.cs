namespace FinalWindowForm.Forms
{
    partial class BookOperation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookOperation));
            this.LblBookNameOp = new System.Windows.Forms.Label();
            this.LblBookAuthorOp = new System.Windows.Forms.Label();
            this.LblBookPriceOp = new System.Windows.Forms.Label();
            this.TxtBookNameOp = new System.Windows.Forms.TextBox();
            this.TxtBookAuthorOp = new System.Windows.Forms.TextBox();
            this.TxtBookPriceOp = new System.Windows.Forms.TextBox();
            this.LblBookGenresOp = new System.Windows.Forms.Label();
            this.btnAddNewBook = new System.Windows.Forms.Button();
            this.CmbGenreOP = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblBookNameOp
            // 
            this.LblBookNameOp.AutoSize = true;
            this.LblBookNameOp.BackColor = System.Drawing.Color.Transparent;
            this.LblBookNameOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBookNameOp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblBookNameOp.Location = new System.Drawing.Point(12, 45);
            this.LblBookNameOp.Name = "LblBookNameOp";
            this.LblBookNameOp.Size = new System.Drawing.Size(64, 15);
            this.LblBookNameOp.TabIndex = 0;
            this.LblBookNameOp.Text = "Kitab Adı";
            // 
            // LblBookAuthorOp
            // 
            this.LblBookAuthorOp.AutoSize = true;
            this.LblBookAuthorOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBookAuthorOp.Location = new System.Drawing.Point(12, 97);
            this.LblBookAuthorOp.Name = "LblBookAuthorOp";
            this.LblBookAuthorOp.Size = new System.Drawing.Size(51, 15);
            this.LblBookAuthorOp.TabIndex = 1;
            this.LblBookAuthorOp.Text = "Müəllif";
            // 
            // LblBookPriceOp
            // 
            this.LblBookPriceOp.AutoSize = true;
            this.LblBookPriceOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBookPriceOp.Location = new System.Drawing.Point(12, 221);
            this.LblBookPriceOp.Name = "LblBookPriceOp";
            this.LblBookPriceOp.Size = new System.Drawing.Size(55, 15);
            this.LblBookPriceOp.TabIndex = 3;
            this.LblBookPriceOp.Text = "Qiyməti";
            // 
            // TxtBookNameOp
            // 
            this.TxtBookNameOp.Location = new System.Drawing.Point(114, 45);
            this.TxtBookNameOp.Name = "TxtBookNameOp";
            this.TxtBookNameOp.Size = new System.Drawing.Size(184, 20);
            this.TxtBookNameOp.TabIndex = 4;
            // 
            // TxtBookAuthorOp
            // 
            this.TxtBookAuthorOp.Location = new System.Drawing.Point(114, 97);
            this.TxtBookAuthorOp.Name = "TxtBookAuthorOp";
            this.TxtBookAuthorOp.Size = new System.Drawing.Size(184, 20);
            this.TxtBookAuthorOp.TabIndex = 5;
            // 
            // TxtBookPriceOp
            // 
            this.TxtBookPriceOp.Location = new System.Drawing.Point(114, 216);
            this.TxtBookPriceOp.Name = "TxtBookPriceOp";
            this.TxtBookPriceOp.Size = new System.Drawing.Size(184, 20);
            this.TxtBookPriceOp.TabIndex = 7;
            // 
            // LblBookGenresOp
            // 
            this.LblBookGenresOp.AutoSize = true;
            this.LblBookGenresOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBookGenresOp.Location = new System.Drawing.Point(12, 161);
            this.LblBookGenresOp.Name = "LblBookGenresOp";
            this.LblBookGenresOp.Size = new System.Drawing.Size(35, 15);
            this.LblBookGenresOp.TabIndex = 2;
            this.LblBookGenresOp.Text = "Janr";
            // 
            // btnAddNewBook
            // 
            this.btnAddNewBook.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAddNewBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewBook.ForeColor = System.Drawing.Color.White;
            this.btnAddNewBook.Location = new System.Drawing.Point(56, 311);
            this.btnAddNewBook.Name = "btnAddNewBook";
            this.btnAddNewBook.Size = new System.Drawing.Size(154, 51);
            this.btnAddNewBook.TabIndex = 9;
            this.btnAddNewBook.Text = "Əlavə Et";
            this.btnAddNewBook.UseVisualStyleBackColor = false;
            this.btnAddNewBook.Click += new System.EventHandler(this.btnAddNewBook_Click);
            // 
            // CmbGenreOP
            // 
            this.CmbGenreOP.FormattingEnabled = true;
            this.CmbGenreOP.Location = new System.Drawing.Point(114, 161);
            this.CmbGenreOP.Name = "CmbGenreOP";
            this.CmbGenreOP.Size = new System.Drawing.Size(184, 21);
            this.CmbGenreOP.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(304, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(531, 365);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // BookOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(847, 389);
            this.Controls.Add(this.CmbGenreOP);
            this.Controls.Add(this.btnAddNewBook);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LblBookGenresOp);
            this.Controls.Add(this.TxtBookPriceOp);
            this.Controls.Add(this.TxtBookAuthorOp);
            this.Controls.Add(this.TxtBookNameOp);
            this.Controls.Add(this.LblBookPriceOp);
            this.Controls.Add(this.LblBookAuthorOp);
            this.Controls.Add(this.LblBookNameOp);
            this.Name = "BookOperation";
            this.Text = "BookOperation";
            this.Load += new System.EventHandler(this.BookOperation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblBookNameOp;
        private System.Windows.Forms.Label LblBookAuthorOp;
        private System.Windows.Forms.Label LblBookPriceOp;
        private System.Windows.Forms.TextBox TxtBookNameOp;
        private System.Windows.Forms.TextBox TxtBookAuthorOp;
        private System.Windows.Forms.TextBox TxtBookPriceOp;
        private System.Windows.Forms.Label LblBookGenresOp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAddNewBook;
        private System.Windows.Forms.ComboBox CmbGenreOP;
    }
}
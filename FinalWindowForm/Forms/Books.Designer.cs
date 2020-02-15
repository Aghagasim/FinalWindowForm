namespace FinalWindowForm.Forms
{
    partial class Books
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
            this.DgvBooks = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Create = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnCreatBook = new System.Windows.Forms.Button();
            this.BtnReadBook = new System.Windows.Forms.Button();
            this.BtnUpdateBook = new System.Windows.Forms.Button();
            this.BtnDeleteBook = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvBooks
            // 
            this.DgvBooks.AllowUserToAddRows = false;
            this.DgvBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvBooks.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DgvBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Name,
            this.Author,
            this.Genre,
            this.Create,
            this.Price});
            this.DgvBooks.Location = new System.Drawing.Point(33, 32);
            this.DgvBooks.Name = "DgvBooks";
            this.DgvBooks.Size = new System.Drawing.Size(731, 257);
            this.DgvBooks.TabIndex = 0;
            this.DgvBooks.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvBooks_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            // 
            // Author
            // 
            this.Author.HeaderText = "Author";
            this.Author.Name = "Author";
            // 
            // Genre
            // 
            this.Genre.HeaderText = "Genre";
            this.Genre.Name = "Genre";
            // 
            // Create
            // 
            this.Create.HeaderText = "Create";
            this.Create.Name = "Create";
            this.Create.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Price
            // 
            this.Price.HeaderText = "Rent Price";
            this.Price.Name = "Price";
            // 
            // BtnCreatBook
            // 
            this.BtnCreatBook.BackColor = System.Drawing.Color.DarkBlue;
            this.BtnCreatBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCreatBook.ForeColor = System.Drawing.Color.White;
            this.BtnCreatBook.Location = new System.Drawing.Point(33, 346);
            this.BtnCreatBook.Name = "BtnCreatBook";
            this.BtnCreatBook.Size = new System.Drawing.Size(129, 44);
            this.BtnCreatBook.TabIndex = 1;
            this.BtnCreatBook.Text = "Yeni Kitab";
            this.BtnCreatBook.UseVisualStyleBackColor = false;
            this.BtnCreatBook.Click += new System.EventHandler(this.BtnCreatBook_Click);
            // 
            // BtnReadBook
            // 
            this.BtnReadBook.BackColor = System.Drawing.Color.RoyalBlue;
            this.BtnReadBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReadBook.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnReadBook.Location = new System.Drawing.Point(635, 346);
            this.BtnReadBook.Name = "BtnReadBook";
            this.BtnReadBook.Size = new System.Drawing.Size(129, 44);
            this.BtnReadBook.TabIndex = 2;
            this.BtnReadBook.Text = "Oxu";
            this.BtnReadBook.UseVisualStyleBackColor = false;
            // 
            // BtnUpdateBook
            // 
            this.BtnUpdateBook.BackColor = System.Drawing.Color.Green;
            this.BtnUpdateBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdateBook.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnUpdateBook.Location = new System.Drawing.Point(217, 346);
            this.BtnUpdateBook.Name = "BtnUpdateBook";
            this.BtnUpdateBook.Size = new System.Drawing.Size(129, 44);
            this.BtnUpdateBook.TabIndex = 3;
            this.BtnUpdateBook.Text = "Yenilə";
            this.BtnUpdateBook.UseVisualStyleBackColor = false;
            // 
            // BtnDeleteBook
            // 
            this.BtnDeleteBook.BackColor = System.Drawing.Color.Firebrick;
            this.BtnDeleteBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteBook.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnDeleteBook.Location = new System.Drawing.Point(427, 346);
            this.BtnDeleteBook.Name = "BtnDeleteBook";
            this.BtnDeleteBook.Size = new System.Drawing.Size(129, 44);
            this.BtnDeleteBook.TabIndex = 4;
            this.BtnDeleteBook.Text = "Sil";
            this.BtnDeleteBook.UseVisualStyleBackColor = false;
            this.BtnDeleteBook.Click += new System.EventHandler(this.BtnDeleteBook_Click);
            // 
            // Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 409);
            this.Controls.Add(this.BtnDeleteBook);
            this.Controls.Add(this.BtnUpdateBook);
            this.Controls.Add(this.BtnReadBook);
            this.Controls.Add(this.BtnCreatBook);
            this.Controls.Add(this.DgvBooks);
            
            this.Text = "Books";
            this.Activated += new System.EventHandler(this.Books_Activated);
            this.Load += new System.EventHandler(this.Books_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvBooks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvBooks;
        private System.Windows.Forms.Button BtnCreatBook;
        private System.Windows.Forms.Button BtnReadBook;
        private System.Windows.Forms.Button BtnUpdateBook;
        private System.Windows.Forms.Button BtnDeleteBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Create;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}
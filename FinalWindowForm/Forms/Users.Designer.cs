namespace FinalWindowForm.Forms
{
    partial class Users
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
            this.DgvUser = new System.Windows.Forms.DataGridView();
            this.DgvUserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvUserFullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvUserEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvUserPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvUserLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvUserStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnCreatNewUser = new System.Windows.Forms.Button();
            this.BtnDeleteUser = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUser)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvUser
            // 
            this.DgvUser.AllowUserToAddRows = false;
            this.DgvUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DgvUserId,
            this.DgvUserFullname,
            this.DgvUserEmail,
            this.DgvUserPhone,
            this.DgvUserLevel,
            this.DgvUserStatus});
            this.DgvUser.Location = new System.Drawing.Point(24, 30);
            this.DgvUser.Name = "DgvUser";
            this.DgvUser.Size = new System.Drawing.Size(749, 254);
            this.DgvUser.TabIndex = 0;
            this.DgvUser.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvUser_CellDoubleClick);
            // 
            // DgvUserId
            // 
            this.DgvUserId.HeaderText = "Id";
            this.DgvUserId.Name = "DgvUserId";
            this.DgvUserId.Visible = false;
            // 
            // DgvUserFullname
            // 
            this.DgvUserFullname.HeaderText = "Ad Soyad";
            this.DgvUserFullname.Name = "DgvUserFullname";
            // 
            // DgvUserEmail
            // 
            this.DgvUserEmail.HeaderText = "Email";
            this.DgvUserEmail.Name = "DgvUserEmail";
            // 
            // DgvUserPhone
            // 
            this.DgvUserPhone.HeaderText = "Telefon";
            this.DgvUserPhone.Name = "DgvUserPhone";
            // 
            // DgvUserLevel
            // 
            this.DgvUserLevel.HeaderText = "Derece";
            this.DgvUserLevel.Name = "DgvUserLevel";
            // 
            // DgvUserStatus
            // 
            this.DgvUserStatus.HeaderText = "Vəziyyət";
            this.DgvUserStatus.Name = "DgvUserStatus";
            // 
            // BtnCreatNewUser
            // 
            this.BtnCreatNewUser.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnCreatNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCreatNewUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnCreatNewUser.Location = new System.Drawing.Point(24, 325);
            this.BtnCreatNewUser.Name = "BtnCreatNewUser";
            this.BtnCreatNewUser.Size = new System.Drawing.Size(125, 47);
            this.BtnCreatNewUser.TabIndex = 1;
            this.BtnCreatNewUser.Text = "Yeni İstifadəçi ";
            this.BtnCreatNewUser.UseVisualStyleBackColor = false;
            this.BtnCreatNewUser.Click += new System.EventHandler(this.BtnCreatNewUser_Click);
            // 
            // BtnDeleteUser
            // 
            this.BtnDeleteUser.BackColor = System.Drawing.Color.Red;
            this.BtnDeleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnDeleteUser.Location = new System.Drawing.Point(322, 325);
            this.BtnDeleteUser.Name = "BtnDeleteUser";
            this.BtnDeleteUser.Size = new System.Drawing.Size(125, 47);
            this.BtnDeleteUser.TabIndex = 2;
            this.BtnDeleteUser.Text = "İstifadəçi Sil";
            this.BtnDeleteUser.UseVisualStyleBackColor = false;
            this.BtnDeleteUser.Click += new System.EventHandler(this.BtnDeleteUser_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button3.Location = new System.Drawing.Point(648, 325);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 47);
            this.button3.TabIndex = 3;
            this.button3.Text = "İstifadəçi Yenilə";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BtnDeleteUser);
            this.Controls.Add(this.BtnCreatNewUser);
            this.Controls.Add(this.DgvUser);
            this.Name = "Users";
            this.Text = "İstifadəçilər";
            this.Activated += new System.EventHandler(this.Users_Activated);
            this.Load += new System.EventHandler(this.Users_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.DgvUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvUserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvUserFullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvUserEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvUserPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvUserLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvUserStatus;
        private System.Windows.Forms.Button BtnCreatNewUser;
        private System.Windows.Forms.Button BtnDeleteUser;
        private System.Windows.Forms.Button button3;
    }
}
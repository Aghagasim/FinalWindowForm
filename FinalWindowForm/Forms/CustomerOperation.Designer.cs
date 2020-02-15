namespace FinalWindowForm.Forms
{
    partial class CustomerOperation
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
            this.LblCustomNameOP = new System.Windows.Forms.Label();
            this.LblCustomEmailOP = new System.Windows.Forms.Label();
            this.LblCustomPhoneOP = new System.Windows.Forms.Label();
            this.TxtCustomNameOP = new System.Windows.Forms.TextBox();
            this.TxtCustomEmailOP = new System.Windows.Forms.TextBox();
            this.TxtCustomPhoneOP = new System.Windows.Forms.TextBox();
            this.BtnNewCustomOP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblCustomNameOP
            // 
            this.LblCustomNameOP.AutoSize = true;
            this.LblCustomNameOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCustomNameOP.Location = new System.Drawing.Point(39, 39);
            this.LblCustomNameOP.Name = "LblCustomNameOP";
            this.LblCustomNameOP.Size = new System.Drawing.Size(79, 18);
            this.LblCustomNameOP.TabIndex = 0;
            this.LblCustomNameOP.Text = "Ad Soyad";
            // 
            // LblCustomEmailOP
            // 
            this.LblCustomEmailOP.AutoSize = true;
            this.LblCustomEmailOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCustomEmailOP.Location = new System.Drawing.Point(39, 114);
            this.LblCustomEmailOP.Name = "LblCustomEmailOP";
            this.LblCustomEmailOP.Size = new System.Drawing.Size(50, 18);
            this.LblCustomEmailOP.TabIndex = 1;
            this.LblCustomEmailOP.Text = "Email";
            // 
            // LblCustomPhoneOP
            // 
            this.LblCustomPhoneOP.AutoSize = true;
            this.LblCustomPhoneOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCustomPhoneOP.Location = new System.Drawing.Point(39, 190);
            this.LblCustomPhoneOP.Name = "LblCustomPhoneOP";
            this.LblCustomPhoneOP.Size = new System.Drawing.Size(56, 18);
            this.LblCustomPhoneOP.TabIndex = 2;
            this.LblCustomPhoneOP.Text = "Phone";
            // 
            // TxtCustomNameOP
            // 
            this.TxtCustomNameOP.Location = new System.Drawing.Point(200, 39);
            this.TxtCustomNameOP.Name = "TxtCustomNameOP";
            this.TxtCustomNameOP.Size = new System.Drawing.Size(202, 20);
            this.TxtCustomNameOP.TabIndex = 4;
            // 
            // TxtCustomEmailOP
            // 
            this.TxtCustomEmailOP.Location = new System.Drawing.Point(200, 114);
            this.TxtCustomEmailOP.Name = "TxtCustomEmailOP";
            this.TxtCustomEmailOP.Size = new System.Drawing.Size(202, 20);
            this.TxtCustomEmailOP.TabIndex = 5;
            // 
            // TxtCustomPhoneOP
            // 
            this.TxtCustomPhoneOP.Location = new System.Drawing.Point(200, 190);
            this.TxtCustomPhoneOP.Name = "TxtCustomPhoneOP";
            this.TxtCustomPhoneOP.Size = new System.Drawing.Size(202, 20);
            this.TxtCustomPhoneOP.TabIndex = 6;
            // 
            // BtnNewCustomOP
            // 
            this.BtnNewCustomOP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnNewCustomOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNewCustomOP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnNewCustomOP.Location = new System.Drawing.Point(109, 285);
            this.BtnNewCustomOP.Name = "BtnNewCustomOP";
            this.BtnNewCustomOP.Size = new System.Drawing.Size(172, 46);
            this.BtnNewCustomOP.TabIndex = 8;
            this.BtnNewCustomOP.Text = "Əlavə Et";
            this.BtnNewCustomOP.UseVisualStyleBackColor = false;
            this.BtnNewCustomOP.Click += new System.EventHandler(this.BtnNewCustomOP_Click);
            // 
            // CustomerOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 382);
            this.Controls.Add(this.BtnNewCustomOP);
            this.Controls.Add(this.TxtCustomPhoneOP);
            this.Controls.Add(this.TxtCustomEmailOP);
            this.Controls.Add(this.TxtCustomNameOP);
            this.Controls.Add(this.LblCustomPhoneOP);
            this.Controls.Add(this.LblCustomEmailOP);
            this.Controls.Add(this.LblCustomNameOP);
            this.Name = "CustomerOperation";
            this.Text = "CustomerOperation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCustomNameOP;
        private System.Windows.Forms.Label LblCustomEmailOP;
        private System.Windows.Forms.Label LblCustomPhoneOP;
        private System.Windows.Forms.TextBox TxtCustomNameOP;
        private System.Windows.Forms.TextBox TxtCustomEmailOP;
        private System.Windows.Forms.TextBox TxtCustomPhoneOP;
        private System.Windows.Forms.Button BtnNewCustomOP;
    }
}
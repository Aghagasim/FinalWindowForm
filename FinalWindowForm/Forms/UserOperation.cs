using FinalWindowForm.Data;
using FinalWindowForm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalWindowForm.Forms
{
    public partial class UserOperation : Form
    {
        private readonly LibraryDbContext _context;
        public UserOperation()
        {
            _context = new LibraryDbContext();
            InitializeComponent();
        }

        private void BtnAddNewUser_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(TxtUserNameOP.Text))
            {
                MessageBox.Show("Ad və Soyad daxil edin");
                return;
            }

            if (string.IsNullOrEmpty(TxtUserEmailOP.Text))
            {
                MessageBox.Show("Email daxil edin");
                return;
            }

            if (string.IsNullOrEmpty(TxtUserPhoneOP.Text))
            {
                MessageBox.Show("Əlaqə nömrənizi daxil edin");
                return;
            }

            if (string.IsNullOrEmpty(TxtUserPasswordOP.Text))
            {
                MessageBox.Show("Şifrə daxil edin");
                return;
            }

            User creatuser = new User
            {
                Fullname = TxtUserNameOP.Text,
                Email = TxtUserEmailOP.Text,
                Phone = TxtUserPhoneOP.Text,
                Password=TxtUserPasswordOP.Text
                

            };

            _context.Users.Add(creatuser);
            _context.SaveChanges();
            Reset();
            this.Close();
        }

        private void Reset()
        {
            foreach (var item in this.Controls)
            {
                if (item.GetType().Equals(typeof(TextBox)))
                {

                    TextBox textBox = item as TextBox;
                    textBox.Text = string.Empty;
                }

            }
        }





    }
}

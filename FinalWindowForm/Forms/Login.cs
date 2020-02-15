using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalWindowForm.Forms;
using FinalWindowForm.Data;
using FinalWindowForm.Models;

namespace FinalWindowForm.Forms
{
    public partial class Login : Form
    {
        private readonly LibraryDbContext _context;
        public Login()
        {
            _context = new LibraryDbContext();
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtEmail.Text))
            {
                MessageBox.Show("E-poçt yazın");
                return;
            }

            if (string.IsNullOrEmpty(TxtPassword.Text))
            {
                MessageBox.Show("Şifrə yazın");
                return;
            }

            User user = _context.Users.FirstOrDefault(u => u.Status && u.Email == TxtEmail.Text && u.Password == TxtPassword.Text);

            if (user != null)
            {
                Dashboard dashboard = new Dashboard();
                

                dashboard.Show();

                this.Hide();
                return;
            }

            MessageBox.Show("E-poçt və ya şifrə yalnışdır");
        }

       
    }
}

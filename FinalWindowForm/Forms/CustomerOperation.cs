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
    public partial class CustomerOperation : Form
    {
        private readonly LibraryDbContext _context;
        public CustomerOperation()
        {
            _context = new LibraryDbContext();
            InitializeComponent();

        }

        

        private void BtnNewCustomOP_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtCustomNameOP.Text))
            {
                MessageBox.Show("Müştəri adı daxil edin");
                return;
            }
            if (string.IsNullOrEmpty(TxtCustomEmailOP.Text))
            {
                MessageBox.Show("Email daxil edin");
                return;
            }
            if (string.IsNullOrEmpty(TxtCustomPhoneOP.Text))
            {
                MessageBox.Show("Əlaqə nömrəsi daxil edin");
                return;
            }

            Customer creatcustomer = new Customer
            {
                
                Fullname = TxtCustomNameOP.Text,
                Email = TxtCustomEmailOP.Text,
                Phone = TxtCustomPhoneOP.Text


            };
            _context.Customers.Add(creatcustomer);
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

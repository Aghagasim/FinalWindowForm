using FinalWindowForm.Data;
using FinalWindowForm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalWindowForm.Forms
{
    public partial class Customers : Form
    {
        LibraryDbContext _context;
        Customer selected;
        public Customers()
        {
            _context = new LibraryDbContext();
            InitializeComponent();
            selected = new Customer();
        }

        private void BtnCustomerCreat_Click(object sender, EventArgs e)
        {
            CustomerOperation customer = new CustomerOperation();
            customer.ShowDialog();
        }

        private void FillCustomerDgv()
        {

            DgvCustomers.Rows.Clear();
            var customerlist = _context.Customers.Include("Orders").ToList();
            foreach (var item in customerlist)
            {

                DgvCustomers.Rows.Add(item.Id, item.Fullname, item.Email, item.Phone);
            }
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            FillCustomerDgv();
        }

        private void DgvCustomers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)DgvCustomers.Rows[e.RowIndex].Cells[0].Value;
            selected = _context.Customers.FirstOrDefault(c => c.Id == id);

        }

        private void BtnCustomerDelete_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Əminsinizmi?", "Silmək", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {

                if (selected != null)
                {
                    _context.Customers.Remove(selected);
                    _context.SaveChanges();
                }

                FillCustomerDgv();

            }
        }

        private void Customers_Activated(object sender, EventArgs e)
        {
            FillCustomerDgv();

        }
    }
}

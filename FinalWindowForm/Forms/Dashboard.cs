using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalWindowForm.Data;
using FinalWindowForm.Models;
using FinalWindowForm.Forms;

namespace FinalWindowForm.Forms
{
    public partial class Dashboard : Form
    {
        public readonly LibraryDbContext _context;
        public Dashboard()
        {
            _context = new LibraryDbContext();
            InitializeComponent();
        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Books book = new Books();
            book.ShowDialog();
            
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customers customer = new Customers();
            customer.ShowDialog();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports report = new Reports();
            report.ShowDialog();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users user = new Users();
            user.ShowDialog();
        }

        private void BtnOrderCreat_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.ShowDialog();
        }

       
    }
}

using FinalWindowForm.Data;
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
    public partial class OrderListBook : Form
    {
        LibraryDbContext _context;
        public OrderListBook()
        {
            _context = new LibraryDbContext();
            InitializeComponent();
         
        }
        private void FillDgvOrderList()
        {
            //var orderlist = _context.Orders.Include("Book").ToList();
            //var booklist = _context.Books.Include("Book").ToList();
            var cs = _context.OrderListBooks.Include("Book").Include("Customer").Include("Order").ToList();

           
            foreach (var item in cs)
            {
              //  MessageBox.Show(item.Customer.Fullname);

                DgvOrderListBook.Rows.Add(item.Id, item.Order.Customer.Fullname, item.Order.Customer.Email, item.Order.Customer.Phone, item.Book.Name, item.Order.RentStart, item.Order.RentEnd,item.TotalPrice);

            }
        }


        private void DgvOrderListBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void OrderListBook_Load(object sender, EventArgs e)
        {
            FillDgvOrderList();
        }
    }
}

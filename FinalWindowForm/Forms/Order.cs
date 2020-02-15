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

namespace FinalWindowForm.Forms
{
    public partial class Order : Form
    {
        LibraryDbContext _context;
     
        public Order()
        {
            _context = new LibraryDbContext();
            InitializeComponent();
        }

        private void BtnSearchCusOr_Click(object sender, EventArgs e)
        {
            
            var customer = _context.Customers.Where(C =>  (TxtSearchCusOr.Text != string.Empty ? C.Fullname.Contains(TxtSearchCusOr.Text) : false)).OrderBy(c => c.Fullname).ToList();

            foreach (var item in customer)
            {
                DgvOrderSrcCus.Rows.Add(item.Id,item.Fullname, item.Email, item.Phone);

            }

        }

        private void BtnSearchBookOr_Click(object sender, EventArgs e)
        {
            var book = _context.Books.Include("Category").Where(b => (TxtSearchBookOr.Text != string.Empty ? b.Name.Contains(TxtSearchBookOr.Text) : false)).OrderBy(b => b.Name).ToList();
          
            foreach (var item in book)
            {
                DgvOrderSrcBook.Rows.Add(item.Id,item.Name,item.Author,item.Category.Genre, item.RentPrice);

            }
        }

        private void BtnAddOrder_Click(object sender, EventArgs e)
        {

            try
            {

                FinalWindowForm.Models.Order order = new FinalWindowForm.Models.Order();
                order.CustomerId = (int)DgvOrderSrcCus.SelectedRows[0].Cells[0].Value;
                order.RentEnd = DtEndTime.Value;
                order.RentStart = DtStartTime.Value;
                _context.Orders.Add(order);
                _context.SaveChanges();
                for (int i = 0; i < DgvOrderSrcBook.SelectedRows.Count; i++)
                {
                    var id = (int)DgvOrderSrcBook.SelectedRows[i].Cells[0].Value;
                    FinalWindowForm.Models.OrderListBook orderListBook = new FinalWindowForm.Models.OrderListBook();
                    orderListBook.BookId = id;
                    orderListBook.OrderId = order.Id;
                    _context.OrderListBooks.Add(orderListBook);
                    _context.SaveChanges();
                }
                OrderListBook formOrder = new OrderListBook();
                formOrder.ShowDialog();

            }
            catch (Exception)
            {

                MessageBox.Show("Seçim Edin");
            }
           
            
        }
      
      


    }
}

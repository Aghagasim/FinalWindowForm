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
using FinalWindowForm.Models;

namespace FinalWindowForm.Forms
{
    public partial class BookOperation : Form
    {
       private readonly LibraryDbContext _context;
      
        public BookOperation(Books bookform, int bookid)
        {
            _context = new LibraryDbContext();
            InitializeComponent();
           

        }

        private void btnAddNewBook_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtBookNameOp.Text))
            {
                MessageBox.Show("Kitab adı daxil edin");
                return;
            }
            if (string.IsNullOrEmpty(TxtBookAuthorOp.Text))
            {
                MessageBox.Show("Müəllif adı daxil edin");
                return;
            }
            if (CmbGenreOP.SelectedIndex == -1)
            {
                MessageBox.Show("Janr sechin");
                return;
            }
            if (string.IsNullOrEmpty(TxtBookPriceOp.Text))
            {
                MessageBox.Show("Qiymət daxil edin");
                return;
            }
           
            Category cat = _context.Categories.FirstOrDefault(c => c.Genre == CmbGenreOP.SelectedItem);
            Book creatbook = new Book
            {

                Name = TxtBookNameOp.Text,
                Author = TxtBookAuthorOp.Text,
                RentPrice = Convert.ToDecimal(TxtBookPriceOp.Text),
                CategoryId = cat.Id,
                Creat = DateTime.Now

            };

            _context.Books.Add(creatbook);
            _context.SaveChanges();
          
            Reset();
            this.Close();
           
        }

        private void BookOperation_FormClosed(object sender, FormClosedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BookOperation_Load(object sender, EventArgs e)
        {
            var genrelist = _context.Categories.ToList();
            foreach (var item in genrelist)
            {
                CmbGenreOP.Items.Add(item.Genre);
            }
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

                if (item.GetType().Equals(typeof(ComboBox)))
                {
                    ComboBox comboBox = item as ComboBox;
                    comboBox.SelectedIndex = -1;
                }

            }

        }

       
    }
}

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
    public partial class Books : Form
    {
        LibraryDbContext _context;
        Book selectedbook;
        public Books()
        {
            selectedbook = new Book();
            _context = new LibraryDbContext();
            InitializeComponent();
        }
       

        private void BtnCreatBook_Click(object sender, EventArgs e)
        {
            BookOperation book = new BookOperation(this, 0);
            book.ShowDialog();

        }

        public void Books_Load(object sender, EventArgs e)
        {
            FillBooksDgv();

        }


        private void DgvBooks_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
          
           
            int id = (int)DgvBooks.Rows[e.RowIndex].Cells[0].Value;
            selectedbook = _context.Books.FirstOrDefault(b => b.Id == id);
           
        }

        private void BtnDeleteBook_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Əminsinizmi?", "Silmək", MessageBoxButtons.YesNo);
            if (d==DialogResult.Yes)
            {
                if (selectedbook != null)
                {
                    _context.Books.Remove(selectedbook);
                    _context.SaveChanges();
                    FillBooksDgv();
                    
                }
               
            }
        }
        public void FillBooksDgv()
        {
            DgvBooks.Rows.Clear();
            var booklist = _context.Books.Include("Category").ToList();
            foreach (var item in booklist)
            {
                DgvBooks.Rows.Add(item.Id, item.Name, item.Author, item.Category.Genre, item.Creat, item.RentPrice);
            }
        }

        private void Books_Activated(object sender, EventArgs e)
        {
            FillBooksDgv();
        }
    }
}

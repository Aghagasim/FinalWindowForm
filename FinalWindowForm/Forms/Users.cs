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
    public partial class Users : Form
    {
        LibraryDbContext _context;
        User selecteduser;
        public Users()
        {
            _context = new LibraryDbContext();
            InitializeComponent();
        }

        private void Users_Load_1(object sender, EventArgs e)
        {
            var userslist = _context.Users.Include("Orders").ToList();
            foreach (var item in userslist)
            {
                DgvUser.Rows.Add(item.Id, item.Fullname, item.Email, item.Phone, item.Level, item.Status);
            }
        }

        private void BtnCreatNewUser_Click(object sender, EventArgs e)
        {
            UserOperation user = new UserOperation();
            user.ShowDialog();

        }
        private void DgvUser_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = (int)DgvUser.Rows[e.RowIndex].Cells[0].Value;
            selecteduser = _context.Users.FirstOrDefault(b => b.Id == id);
        }

        private void BtnDeleteUser_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Əminsinizmi?", "Silmək", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                if (selecteduser != null)
                {
                    _context.Users.Remove(selecteduser);
                    _context.SaveChanges();
                   

                }
                FillUserDgv();

            }

        }
        private void FillUserDgv()
        {
            DgvUser.Rows.Clear();
            var userlist = _context.Users.Include("Orders").ToList();
            foreach (var item in userlist)
            {
                DgvUser.Rows.Add(item.Id, item.Fullname, item.Email, item.Phone,item.Level, item.Status);
            }
        }

        private void Users_Activated(object sender, EventArgs e)
        {
            FillUserDgv();
        }
    }
}

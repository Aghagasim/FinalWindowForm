using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using FinalWindowForm.Models;
using FinalWindowForm.Data;
using FinalWindowForm.Forms;


namespace FinalWindowForm.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        public  string Genre { get; set; }
    }
}

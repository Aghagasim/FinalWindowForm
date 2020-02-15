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
   public class Book
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        [Required]
        [MaxLength(50)]
        public  string Name { get; set; }
        [Required]
        [MaxLength(50)]
        public string  Author { get; set; }
        public Category Category { get; set; }
        [Required]
        public DateTime Creat { get; set; }
        [Required]
        public decimal RentPrice { get; set; }

        public List<OrderListBook> OrderListBooks { get; set; }
    }
}

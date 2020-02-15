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
    public class OrderListBook
    {
        public int Id { get; set; }
       
        public int BookId { get; set; }
        public int OrderId { get; set; }
        public int? CustomerId { get; set; }
        public Customer Customer { get; set; }
        public Book Book { get; set; }
        public Order Order { get; set; }
        public int Count { get; set; }
        public float TotalPrice { get; set; }
    }
}

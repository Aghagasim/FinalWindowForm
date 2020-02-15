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
    public class Order
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }
        [Required]
       
        public DateTime RentStart { get; set; }
        [Required]
       
        public DateTime RentEnd { get; set; }

        public List<OrderListBook> OrderListBooks  { get; set; }

        public Customer Customer { get; set; }

       

    }
}

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
    public  class Customer
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Fullname { get; set; }
        [Required]
        [MaxLength(50)]
        public string Email { get; set; }
        [Required]
        [MaxLength(50)]
        public string Phone { get; set; }
        public bool Status { get; set; }
        public decimal? PenaltyPay { get; set; }

        public List<OrderListBook> OrderListBook { get; set; }
        public List<Order> Orders { get; set; }
    }
}

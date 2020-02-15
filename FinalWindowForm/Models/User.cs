using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace FinalWindowForm.Models
{
    public enum UserLevel
    {
        Admin = 1,
        Moderator = 2
    }
    public class User
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Fullname { get; set; }
        [Required]
        [MaxLength(50)]
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool Status { get; set; }
        [Required]
        [MaxLength(50)]
        public string Password { get; set; }
        public UserLevel Level { get; set; }
        public List<Order> Orders { get; set; }
    }
}

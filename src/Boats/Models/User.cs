using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Boats.Models
{
    [Table("Users")]
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string Name { get; set; }
        public List<Sale> Sales { get; set; }
        public User(string name, int userId = 0)
        {
            Name = name;
            UserId = userId;
        }
        public User() { }
    }
}

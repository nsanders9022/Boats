using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Boats.Models
{
    [Table("Sellers")]
    public class Seller
    {
        [Key]
        public int SellerId { get; set; }
        public string Name { get; set; }
        public List<Sale> Sales { get; set; }
        public Seller(string name, int sellerId = 0)
        {
            Name = name;
            SellerId = sellerId;
        }
        public Seller() { }
    }
}

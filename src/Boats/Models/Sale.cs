using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Boats.Models
{
    [Table("Sales")]
    public class Sale
    {
        [Key]
        public int SaleId { get; set; }
        public int BoatId { get; set; }
        public Boat Boat { get; set; }
        public int SellerId { get; set; }
        public Seller Seller { get; set; }
        public string Comment { get; set; }
        public int Commission { get; set; }

        public Sale(int boatId, int sellerId, string comment, int commission)
        {
            BoatId = boatId;
            SellerId = sellerId;
            Comment = comment;
            Commission = commission;

        }
        public Sale() { }
    }
}

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

        //public string AssociateId { get; set; }
        public AssociateUser AssociateUser { get; set; }

        public string Comment { get; set; }
        public int Commission { get; set; }

        public Sale(int boatId, AssociateUser associateUser, string comment, int commission = 0, int id = 0)
        {
            BoatId = boatId;
            AssociateUser = associateUser;
            Comment = comment;
            Commission = commission;
            SaleId = id;
        }
        public Sale() { }
    }
}

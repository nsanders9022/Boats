using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Boats.Models
{
    [Table("Boats")]
    public class Boat
    {
        [Key]
        public int BoatId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Cost {get;set;}
        public int Inventory { get; set; }
        public string Image { get; set; }
        public int Revenue { get; set; }
        public List<AssociateBoat> AssociatesBoats { get; set; }

        public Boat(string name, int price, int cost, int inventory, string image, int boatId = 0)
        {
            Name = name;
            Price = price;
            Cost = cost;
            Inventory = inventory;
            Image = image;
            Revenue = price - cost;
            BoatId = boatId;
        }
        public Boat() { }
    }
}

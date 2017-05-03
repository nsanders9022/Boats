using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Boats.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Boats.Controllers
{
    [Authorize]
    public class BoatsController : Controller
    {
        private readonly BoatsDbContext _db;
        private readonly UserManager<AssociateUser> _userManager;

        public BoatsController (UserManager<AssociateUser> userManager, BoatsDbContext db)
        {
            _userManager = userManager;
            _db = db;
        }
        public IActionResult Index()
        {
            ViewBag.AssociateId = new SelectList(_db.Users, "UserId", "UserName");
            return View(_db.Boats.ToList());
        }

        //public IActionResult Create()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public IActionResult Create(Boat boat)
        //{
        //    _db.Boats.Add(boat);
        //    _db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        [HttpPost]
        public IActionResult NewBoat(string newName, int newPrice, int newCost, int newInventory, string newImage)
        {
            int newRevenue = newPrice - newCost;
            Console.WriteLine(newRevenue);
            Boat newBoat = new Boat(newName, newPrice, newCost, newInventory, newImage);
            _db.Boats.Add(newBoat);
            _db.SaveChanges();
            return Json(newBoat);
        }

        [HttpPost]
        public IActionResult SellBoat(int newBoatId, AssociateUser newAssociateUser, string newComment )
        {
            int newCommission = 12;
            Sale newSale = new Sale(newBoatId, newAssociateUser, newComment, newCommission);
            _db.Sales.Add(newSale);
            _db.SaveChanges();
            return Json(newSale);
        }
    }
}

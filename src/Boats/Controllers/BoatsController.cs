using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Boats.Models;
using Microsoft.AspNetCore.Identity;

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
    }
}

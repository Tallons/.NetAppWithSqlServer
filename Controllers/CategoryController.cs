using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers {
    public class CategoryController : Controller {
        private readonly AppDbContext _db;

        public CategoryController(AppDbContext db) {
            _db = db;
        }
        public IActionResult Index() {
            IEnumerable<Category> objList = _db.Category;
            return View(objList);
        }
        public IActionResult Create() {
            return View();
        }
    }
}

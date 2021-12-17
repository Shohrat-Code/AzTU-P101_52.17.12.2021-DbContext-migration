using Microsoft.AspNetCore.Mvc;
using OneHealth.Data;
using OneHealth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OneHealth.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbContext _context;

        public AboutController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            Setting model = _context.Settings.FirstOrDefault();
            return View(model);
        }
    }
}

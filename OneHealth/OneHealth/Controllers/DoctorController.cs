using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OneHealth.Data;
using OneHealth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OneHealth.Controllers
{
    public class DoctorController : Controller
    {
        private readonly AppDbContext _context;

        public DoctorController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Doctor> doctors = _context.Doctors.Include("Specialty").ToList();
            return View(doctors);
        }
    }
}

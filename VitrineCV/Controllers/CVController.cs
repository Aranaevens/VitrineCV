using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VitrineCV.Data;
using VitrineCV.Models;

namespace VitrineCV.Controllers
{
    public class CVController : Controller
    {
        private readonly CVContext _context;

        public CVController(CVContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Formations.ToListAsync());
        }
    }
}
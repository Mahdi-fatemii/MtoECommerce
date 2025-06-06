﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using MtoECommerce.Infrastructure;

namespace MtoECommerce.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PagesController(DataContext context) : Controller
    {
        private readonly DataContext _context = context;

        public async Task<IActionResult> Index()
        {
            List<Page> pages = await _context.Pages.ToListAsync();

            return View(pages);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}

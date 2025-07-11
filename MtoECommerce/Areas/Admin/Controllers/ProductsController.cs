using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using MtoECommerce.Infrastructure;

namespace MtoECommerce.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductsController(DataContext context) : Controller
    {
        private readonly DataContext _context = context;

        public async Task<IActionResult> Index()
        {
            List<Product> Products = await _context.Products.Include(x => x.Category).OrderBy(x => x.CategoryId).ToListAsync();

            return View(Products);
        }

    }
}
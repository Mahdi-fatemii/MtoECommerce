using Microsoft.AspNetCore.Mvc;
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

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Page page)
        {
            if (ModelState.IsValid) 
            {
                page.Slug = page.Title.ToLower().Replace(" ", "-");

                var slug = await _context.Pages.FirstOrDefaultAsync(x => x.Slug == page.Slug);

                if (slug != null)
                {
                    ModelState.AddModelError("", "That page already exists!");
                    return View(page);
                }

                _context.Add(page);
                await _context.SaveChangesAsync();

                TempData["Success"] = "The page has been added!";
                
                return RedirectToAction("Index");
            }

            return View(page);
        }
    }
}

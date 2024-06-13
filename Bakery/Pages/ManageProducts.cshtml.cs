using Bakery.Data;
using Bakery.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Bakery.Pages
{
    public class ManageProductsModel : PageModel
    {
        private readonly BakeryContext _context;

        public ManageProductsModel(BakeryContext context)
        {
            _context = context;
        }

        public IList<Product> Products { get; set; }

        [BindProperty]
        public Product Product { get; set; }

        public async Task OnGetAsync()
        {
            Products = await _context.Products.ToListAsync();
        }

        public async Task<IActionResult> OnPostAddAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var product = new Product
            {
                Name = Product.Name,
                Description = Product.Description,
                Price = Product.Price,
                ImageName = Product.ImageName
            };

            _context.Products.Add(product);
            await _context.SaveChangesAsync();

            return RedirectToPage();
        }

        public async Task<IActionResult> OnPostEditAsync(int id)
        {
            var product = await _context.Products.FindAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            product.Name = Product.Name;
            product.Description = Product.Description;
            product.Price = Product.Price;
            product.ImageName = Product.ImageName;

            await _context.SaveChangesAsync();

            return RedirectToPage();
        }

        public async Task<IActionResult> OnPostDeleteAsync(int id)
        {
            var product = await _context.Products.FindAsync(id);

            if (product != null)
            {
                _context.Products.Remove(product);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage();
        }

        public async Task<IActionResult> OnPostClearAsync()
        {
            _context.Products.RemoveRange(_context.Products);
            await _context.SaveChangesAsync();

            return RedirectToPage();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Carnation.Models;
using Carnation.data;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.AspNetCore.Authorization;

namespace Carnation.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ProductDbContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;
        public ProductsController(ProductDbContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            this._hostEnvironment = hostEnvironment;
        }

        // GET: Products
       
        public async Task<IActionResult> Index()
        {
            return View(await _context.Products.ToListAsync());
        }

        // GET: Products/Details/5
       [Authorize(Roles ="Admin,SimpleUser,MerchantUser")]
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .FirstOrDefaultAsync(m => m.PId == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Products/Create
        [Authorize(Roles = "Admin,MerchantUser")]

        public IActionResult Create()
        {
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PId,PName,PCompany,PPrice,PDescription,UName,PQuality,PPicture,ProductPic")] Product product)
        {
            if (ModelState.IsValid)
            {
                string wwwRootPath = _hostEnvironment.WebRootPath;
                string filename = Path.GetFileNameWithoutExtension(product.ProductPic.FileName);
                string ext = Path.GetExtension(product.ProductPic.FileName);
                product.PPicture = filename + DateTime.Now.ToString("yymmssfff") + ext;
                string path = Path.Combine(wwwRootPath + "/images/" + product.PPicture);
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    await product.ProductPic.CopyToAsync(fileStream);
                }
                product.PId = Guid.NewGuid();
                _context.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        // GET: Products/Edit/5
        [Authorize(Roles = "Admin,MerchantUser")]

        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("PId,PName,PCompany,PPrice,PDescription,UName,PQuality,PPicture,ProductPic")] Product product)
        {
            if (id != product.PId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    string wwwRootPath = _hostEnvironment.WebRootPath;
                    string filename = Path.GetFileNameWithoutExtension(product.ProductPic.FileName);
                    string ext = Path.GetExtension(product.ProductPic.FileName);
                    product.PPicture = filename + DateTime.Now.ToString("yymmssfff") + ext;
                    string path = Path.Combine(wwwRootPath + "/images/" + product.PPicture);
                    using (var fileStream = new FileStream(path, FileMode.Create))
                    {
                        await product.ProductPic.CopyToAsync(fileStream);
                    }
                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.PId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        // GET: Products/Delete/5
        [Authorize(Roles = "Admin,MerchantUser")]
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .FirstOrDefaultAsync(m => m.PId == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var product = await _context.Products.FindAsync(id);
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(Guid id)
        {
            return _context.Products.Any(e => e.PId == id);
        }
    }
}

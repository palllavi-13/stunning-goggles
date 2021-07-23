using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Carnation.NewModels;
using Microsoft.AspNetCore.Authorization;

namespace Carnation.Controllers
{
    public class MerchantUserRegistersController : Controller
    {
        private readonly CarnationDbContext _context;

        public MerchantUserRegistersController(CarnationDbContext context)
        {
            _context = context;
        }

        // GET: MerchantUserRegisters
        [Authorize(Roles ="MerchantUser,Admin")]
        public async Task<IActionResult> Index()
        {
            return View(await _context.MerchantUserRegisters.ToListAsync());
        }

        // GET: MerchantUserRegisters/Details/5
        [Authorize(Roles = "MerchantUser,Admin")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var merchantUserRegister = await _context.MerchantUserRegisters
                .FirstOrDefaultAsync(m => m.Muid == id);
            if (merchantUserRegister == null)
            {
                return NotFound();
            }

            return View(merchantUserRegister);
        }

        // GET: MerchantUserRegisters/Create

        public IActionResult Create()
        {
            return View();
        }

        // POST: MerchantUserRegisters/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Muid,FirstName,LastName,Gender,Age,Email,Contact,UserName,Pass,CreatedInfo")] MerchantUserRegister merchantUserRegister)
        {
            if (ModelState.IsValid)
            {
                _context.Add(merchantUserRegister);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(merchantUserRegister);
        }

        // GET: MerchantUserRegisters/Edit/5
        [Authorize(Roles = "MerchantUser,Admin")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var merchantUserRegister = await _context.MerchantUserRegisters.FindAsync(id);
            if (merchantUserRegister == null)
            {
                return NotFound();
            }
            return View(merchantUserRegister);
        }

        // POST: MerchantUserRegisters/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Muid,FirstName,LastName,Gender,Age,Email,Contact,UserName,Pass,CreatedInfo")] MerchantUserRegister merchantUserRegister)
        {
            if (id != merchantUserRegister.Muid)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(merchantUserRegister);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MerchantUserRegisterExists(merchantUserRegister.Muid))
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
            return View(merchantUserRegister);
        }

        // GET: MerchantUserRegisters/Delete/5
        [Authorize(Roles = "MerchantUser,Admin")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var merchantUserRegister = await _context.MerchantUserRegisters
                .FirstOrDefaultAsync(m => m.Muid == id);
            if (merchantUserRegister == null)
            {
                return NotFound();
            }

            return View(merchantUserRegister);
        }

        // POST: MerchantUserRegisters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var merchantUserRegister = await _context.MerchantUserRegisters.FindAsync(id);
            _context.MerchantUserRegisters.Remove(merchantUserRegister);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MerchantUserRegisterExists(int id)
        {
            return _context.MerchantUserRegisters.Any(e => e.Muid == id);
        }
    }
}

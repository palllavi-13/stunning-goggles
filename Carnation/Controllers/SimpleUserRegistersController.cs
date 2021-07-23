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
    public class SimpleUserRegistersController : Controller
    {
        private readonly CarnationDbContext _context;

        public SimpleUserRegistersController(CarnationDbContext context)
        {
            _context = context;
        }

        // GET: SimpleUserRegisters
        [Authorize(Roles="SimpleUser,Admin")]
        public async Task<IActionResult> Index()
        {
            return View(await _context.SimpleUserRegisters.ToListAsync());
        }

        // GET: SimpleUserRegisters/Details/5
        [Authorize(Roles = "SimpleUser,Admin")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var simpleUserRegister = await _context.SimpleUserRegisters
                .FirstOrDefaultAsync(m => m.Suid == id);
            if (simpleUserRegister == null)
            {
                return NotFound();
            }

            return View(simpleUserRegister);
        }

        // GET: SimpleUserRegisters/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SimpleUserRegisters/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Suid,FirstName,LastName,Gender,Age,Email,Contact,UserName,Pass,CreatedInfo")] SimpleUserRegister simpleUserRegister)
        {
            if (ModelState.IsValid)
            {
                _context.Add(simpleUserRegister);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(simpleUserRegister);
        }

        // GET: SimpleUserRegisters/Edit/5
        [Authorize(Roles = "SimpleUser,Admin")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var simpleUserRegister = await _context.SimpleUserRegisters.FindAsync(id);
            if (simpleUserRegister == null)
            {
                return NotFound();
            }
            return View(simpleUserRegister);
        }

        // POST: SimpleUserRegisters/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Suid,FirstName,LastName,Gender,Age,Email,Contact,UserName,Pass,CreatedInfo")] SimpleUserRegister simpleUserRegister)
        {
            if (id != simpleUserRegister.Suid)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(simpleUserRegister);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SimpleUserRegisterExists(simpleUserRegister.Suid))
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
            return View(simpleUserRegister);
        }

        // GET: SimpleUserRegisters/Delete/5
        [Authorize(Roles = "SimpleUser,Admin")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var simpleUserRegister = await _context.SimpleUserRegisters
                .FirstOrDefaultAsync(m => m.Suid == id);
            if (simpleUserRegister == null)
            {
                return NotFound();
            }

            return View(simpleUserRegister);
        }

        // POST: SimpleUserRegisters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var simpleUserRegister = await _context.SimpleUserRegisters.FindAsync(id);
            _context.SimpleUserRegisters.Remove(simpleUserRegister);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SimpleUserRegisterExists(int id)
        {
            return _context.SimpleUserRegisters.Any(e => e.Suid == id);
        }

    }
}

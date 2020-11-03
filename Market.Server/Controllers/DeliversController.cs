using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Data;
using Data.Entity;
using Microsoft.AspNetCore.Authorization;

namespace Market.Server.Controllers
{
    [Authorize]
    public class DeliversController : Controller
    {
        private readonly MarketContext _context;

        public DeliversController(MarketContext context)
        {
            _context = context;
        }

        // GET: Delivers
        public async Task<IActionResult> Index(int? PageNumber)
        {
            return View(await PageList<Deliver>.CreateAsync(_context.delivers.AsNoTracking(),PageNumber ??1));
        }

        // GET: Delivers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var deliver = await _context.delivers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (deliver == null)
            {
                return NotFound();
            }

            return View(deliver);
        }

        // GET: Delivers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Delivers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FullName,Company_Name,Company_Phone,Contat_Name,Contact_Title,Address,Contact_Date")] Deliver deliver)
        {
            if (ModelState.IsValid)
            {
                _context.Add(deliver);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(deliver);
        }

        // GET: Delivers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var deliver = await _context.delivers.FindAsync(id);
            if (deliver == null)
            {
                return NotFound();
            }
            return View(deliver);
        }

        // POST: Delivers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FullName,Company_Name,Company_Phone,Contat_Name,Contact_Title,Address,Contact_Date")] Deliver deliver)
        {
            if (id != deliver.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(deliver);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DeliverExists(deliver.Id))
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
            return View(deliver);
        }

        // GET: Delivers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var deliver = await _context.delivers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (deliver == null)
            {
                return NotFound();
            }

            return View(deliver);
        }

        // POST: Delivers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var deliver = await _context.delivers.FindAsync(id);
            _context.delivers.Remove(deliver);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DeliverExists(int id)
        {
            return _context.delivers.Any(e => e.Id == id);
        }
    }
}

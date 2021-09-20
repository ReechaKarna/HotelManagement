using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HotelReservation.Data;
using HotelReservation.Models;
using Microsoft.AspNetCore.Authorization;
using PagedList;

namespace HotelReservation.Controllers
{
    public class HotelTypesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HotelTypesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: HotelTypes

        public async Task<IActionResult> Index(HotelType hotelType, int page = 1, string sortExpression = "HotelTypeName")
        {
            var hotelTypeRecord = _context.HotelType.AsNoTracking().AsQueryable(); ;

            int num = hotelTypeRecord.ToList().Count<HotelType>();

            int num2 = 5;


            hotelType.PageSize = 5;
            hotelType.PageNumber = (int)page;
            ViewBag.PageSize = num2;
            int? nullable = page;
            int pageNumber = nullable.HasValue ? nullable.GetValueOrDefault() : 1;


            return base.View(hotelTypeRecord.OrderByDescending(m => m.HotelTypeId).ToPagedList<HotelType>(pageNumber, hotelType.PageSize));

        }

       

        // GET: HotelTypes/Create
     
        public IActionResult Create()
        {
            return View();
        }

      
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("HotelTypeId,HotelTypeName")] HotelType hotelType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hotelType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(hotelType);
        }

        // GET: HotelTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hotelType = await _context.HotelType.FindAsync(id);
            if (hotelType == null)
            {
                return NotFound();
            }
            return View(hotelType);
        }

        // POST: HotelTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, HotelType hotelType)
        {
            if (id != hotelType.HotelTypeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hotelType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HotelTypeExists(hotelType.HotelTypeId))
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
            return View(hotelType);
        }

        // GET: HotelTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hotelType = await _context.HotelType
                .FirstOrDefaultAsync(m => m.HotelTypeId == id);
            if (hotelType == null)
            {
                return NotFound();
            }

            return View(hotelType);
        }

        // POST: HotelTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var hotelType = await _context.HotelType.FindAsync(id);
            _context.HotelType.Remove(hotelType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HotelTypeExists(int id)
        {
            return _context.HotelType.Any(e => e.HotelTypeId == id);
        }
    }
}

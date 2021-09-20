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
    public class HotelLocationsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HotelLocationsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: HotelLocations
        [Authorize]
        public async Task<IActionResult> Index(HotelLocation hotelLocation, int page = 1, string sortExpression = "CityName")
        {
            var hotelLocationRecord = _context.HotelLocation.AsNoTracking().AsQueryable(); ;

            int num = hotelLocationRecord.ToList().Count<HotelLocation>();

            int num2 = 5;


            hotelLocation.PageSize = 5;
            hotelLocation.PageNumber = (int)page;
            ViewBag.PageSize = num2;
            int? nullable = page;
            int pageNumber = nullable.HasValue ? nullable.GetValueOrDefault() : 1;


            return base.View(hotelLocationRecord.OrderByDescending(m => m.HotelLocationId).ToPagedList<HotelLocation>(pageNumber, hotelLocation.PageSize));

        }

       
    

        // GET: HotelLocations/Create
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

      
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("HotelLocationId,CityNames,ProvienceNo")] HotelLocation hotelLocation)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hotelLocation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(hotelLocation);
        }

        // GET: HotelLocations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hotelLocation = await _context.HotelLocation.FindAsync(id);
            if (hotelLocation == null)
            {
                return NotFound();
            }
            return View(hotelLocation);
        }

      
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, HotelLocation hotelLocation)
        {
            if (id != hotelLocation.HotelLocationId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hotelLocation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HotelLocationExists(hotelLocation.HotelLocationId))
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
            return View(hotelLocation);
        }

        // GET: HotelLocations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hotelLocation = await _context.HotelLocation
                .FirstOrDefaultAsync(m => m.HotelLocationId == id);
            if (hotelLocation == null)
            {
                return NotFound();
            }

            return View(hotelLocation);
        }

        // POST: HotelLocations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var hotelLocation = await _context.HotelLocation.FindAsync(id);
            _context.HotelLocation.Remove(hotelLocation);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HotelLocationExists(int id)
        {
            return _context.HotelLocation.Any(e => e.HotelLocationId == id);
        }
    }
}

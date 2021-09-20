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
using Microsoft.AspNetCore.Http;

namespace HotelReservation.Controllers
{
    public class HotelsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HotelsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Hotels
        [Authorize]
        public async Task<IActionResult> Index(Hotel hotel, int page = 1, string sortExpression = "HotelName")
        {
            var hotelRecord = _context.Hotel.Include(h => h.HotelLocation).Include(h => h.HotelType).AsNoTracking().AsQueryable(); ;

            int num = hotelRecord.ToList().Count<Hotel>();

            int num2 = 5;


            hotel.PageSize = 5;
            hotel.PageNumber = (int)page;
            ViewBag.PageSize = num2;
            int? nullable = page;
            int pageNumber = nullable.HasValue ? nullable.GetValueOrDefault() : 1;


            return base.View(hotelRecord.OrderByDescending(m => m.HotelId).ToPagedList<Hotel>(pageNumber, hotel.PageSize));
       
        }

   

        // GET: Hotels/Create
        [Authorize]
        public IActionResult Create()
        {
            ViewData["HotelLocationId"] = new SelectList(_context.HotelLocation, "HotelLocationId", "CityNames");
            ViewData["HotelTypeId"] = new SelectList(_context.HotelType, "HotelTypeId", "HotelTypeName");
            return View();
        }

     
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Hotel hotel)
        {
            if (ModelState.IsValid)
            {
                hotel.Image = ReturnByte(hotel.ImageFile);
                _context.Add(hotel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["HotelLocationId"] = new SelectList(_context.HotelLocation, "HotelLocationId", "HotelLocationId", hotel.HotelLocationId);
            ViewData["HotelTypeId"] = new SelectList(_context.HotelType, "HotelTypeId", "HotelTypeId", hotel.HotelTypeId);
            return View(hotel);
        }

        // GET: Hotels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hotel = await _context.Hotel.FindAsync(id);
            if (hotel == null)
            {
                return NotFound();
            }
            ViewData["HotelLocationId"] = new SelectList(_context.HotelLocation, "HotelLocationId", "CityNames", hotel.HotelLocationId);
            ViewData["HotelTypeId"] = new SelectList(_context.HotelType, "HotelTypeId", "HotelTypeName", hotel.HotelTypeId);
            return View(hotel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,  Hotel hotel)
        {
            if (id != hotel.HotelId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {


                    if (hotel.ImageFile != null)
                    {
                        hotel.Image = ReturnByte(hotel.ImageFile);
                    }
                    _context.Update(hotel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HotelExists(hotel.HotelId))
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
            ViewData["HotelLocationId"] = new SelectList(_context.HotelLocation, "HotelLocationId", "CityNames", hotel.HotelLocationId);
            ViewData["HotelTypeId"] = new SelectList(_context.HotelType, "HotelTypeId", "HotelTypeName", hotel.HotelTypeId);
            return View(hotel);
        }

        // GET: Hotels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hotel = await _context.Hotel
                .Include(h => h.HotelLocation)
                .Include(h => h.HotelType)
                .FirstOrDefaultAsync(m => m.HotelId == id);
            if (hotel == null)
            {
                return NotFound();
            }

            return View(hotel);
        }

        // POST: Hotels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var hotel = await _context.Hotel.FindAsync(id);
            _context.Hotel.Remove(hotel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HotelExists(int id)
        {
            return _context.Hotel.Any(e => e.HotelId == id);
        }




        public static byte[] ReturnByte(IFormFile ImageFile)
        {
            if (ImageFile == null)
            {
                return null;
            }
            byte[] buffer = null;

            if (ImageFile != null)
            {
                buffer = new byte[ImageFile.OpenReadStream().Length];
                ImageFile.OpenReadStream().Read(buffer, 0, buffer.Length);
            }
            return buffer;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Assesment2.Models;
using Microsoft.AspNetCore.Http;

namespace Assesment2.Controllers
{
    public class ItemManagementsController : Controller
    {
        private readonly Assesment2Context _context;

        public ItemManagementsController(Assesment2Context context)
        {
            _context = context;
        }

        // GET: ItemManagements
        public async Task<IActionResult> Index(string temp = "")
        {
            if (HttpContext.Session.GetString("Username") != null)
            {
                if (temp == "")
                {
                    return View(await _context.ItemManagement.ToListAsync());
                }
                return View(await _context.ItemManagement.Where(a => a.Name.Contains(temp)).ToListAsync());
            }
            return RedirectToAction("Login", "Login");
        }

        // GET: ItemManagements/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itemManagement = await _context.ItemManagement
                .FirstOrDefaultAsync(m => m.Id == id);
            if (itemManagement == null)
            {
                return NotFound();
            }

            return View(itemManagement);
        }

        // GET: ItemManagements/Create
        public IActionResult Create()
        {
            if (HttpContext.Session.GetString("Username") != null && (HttpContext.Session.GetString("role") != "Staff"))
           
            {
                return View();
            }
            return RedirectToAction("Login", "Login");
        }

        // POST: ItemManagements/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CategorieId,Name,Description,Quantity,CostPrice,SalePrice,MainImage,ItemCode,MainColor,Status")] ItemManagement itemManagement)
        {
            if (ModelState.IsValid)
            {
                _context.Add(itemManagement);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(itemManagement);
        }

        // GET: ItemManagements/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var itemManagement = await _context.ItemManagement.FindAsync(id);
            if (itemManagement == null)
            {
                return NotFound();
            }
            return View(itemManagement);
        }

        // POST: ItemManagements/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CategorieId,Name,Description,Quantity,CostPrice,SalePrice,MainImage,ItemCode,MainColor,Status")] ItemManagement itemManagement)
        {
            if (id != itemManagement.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(itemManagement);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ItemManagementExists(itemManagement.Id))
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
            return View(itemManagement);
        }

        // GET: ItemManagements/Delete/5
     public string Delete(int id)
        {
            _context.ItemManagement.Remove(_context.ItemManagement.Find(id));
            _context.SaveChanges();
            return "1";
        }
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var itemManagement = await _context.ItemManagement
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (itemManagement == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(itemManagement);
        //}

        //// POST: ItemManagements/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var itemManagement = await _context.ItemManagement.FindAsync(id);
        //    _context.ItemManagement.Remove(itemManagement);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        private bool ItemManagementExists(int id)
        {
            return _context.ItemManagement.Any(e => e.Id == id);
        }
    }
}

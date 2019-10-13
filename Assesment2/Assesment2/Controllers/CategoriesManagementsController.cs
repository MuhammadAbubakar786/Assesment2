using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Assesment2.Models;
using Microsoft.AspNetCore.Http;
using System.Net;

namespace Assesment2.Controllers
{
    public class CategoriesManagementsController : Controller
    {
        private readonly Assesment2Context _context;

        public CategoriesManagementsController(Assesment2Context context)
        {
            _context = context;
        }


        // GET: CategoriesManagements
        public async Task<IActionResult> Index(string temp = "")
        {
            if (HttpContext.Session.GetString("Username") != null)
            {
                if (temp == "")
                {
                    return View(await _context.CategoriesManagement.ToListAsync());
                }
                return View(await _context.CategoriesManagement.Where(a => a.Name.Contains(temp)).ToListAsync());
            }
            return RedirectToAction("Login", "Login");
        }
        // GET: CategoriesManagements/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categoriesManagement = await _context.CategoriesManagement
                .FirstOrDefaultAsync(m => m.Id == id);
            if (categoriesManagement == null)
            {
                return NotFound();
            }

            return View(categoriesManagement);
        }

        // GET: CategoriesManagements/Create
        public IActionResult Create()
        {     
         if (HttpContext.Session.GetString("Username") != null && (HttpContext.Session.GetString("role") != "Staff"))
            {
                return View();
            }
            return RedirectToAction("Login", "Login");
        }
    // POST: CategoriesManagements/Create
    // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
    // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Picture,Status")] CategoriesManagement categoriesManagement)
        {
            if (ModelState.IsValid)
            {
                _context.Add(categoriesManagement);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(categoriesManagement);
        }

        // GET: CategoriesManagements/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categoriesManagement = await _context.CategoriesManagement.FindAsync(id);
            if (categoriesManagement == null)
            {
                return NotFound();
            }
            return View(categoriesManagement);
        }

        // POST: CategoriesManagements/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Picture,Status")] CategoriesManagement categoriesManagement)
        {
           
                if (id != categoriesManagement.Id)
                {
                    return NotFound();
                }

                if (ModelState.IsValid)
                {
                    try
                    {
                        _context.Update(categoriesManagement);
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!CategoriesManagementExists(categoriesManagement.Id))
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
                return View(categoriesManagement);
            }
          
        // GET: CategoriesManagements/Delete/5
        public string Delete(int id)
        {
            if(HttpContext.Session.GetString("Username") != null)
            _context.CategoriesManagement.Remove(_context.CategoriesManagement.Find(id));
            _context.SaveChanges();
            return "1";
        }
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var categoriesManagement = await _context.CategoriesManagement
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (categoriesManagement == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(categoriesManagement);
        //}

        //// POST: CategoriesManagements/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var categoriesManagement = await _context.CategoriesManagement.FindAsync(id);
        //    _context.CategoriesManagement.Remove(categoriesManagement);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        private bool CategoriesManagementExists(int id)
        {
            return _context.CategoriesManagement.Any(e => e.Id == id);
        }
    }
}

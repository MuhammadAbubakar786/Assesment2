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
    public class LoginController : Controller
    {
        private readonly Assesment2Context _context;

        public LoginController(Assesment2Context context)
        {
            _context = context;
        }

        

        // GET: Login

            [HttpGet]
         public IActionResult Login()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Login(UsersManagement users)
        {
            var data = _context.UsersManagement.Where(temp => temp.UserName == users.UserName && temp.Password == users.Password && temp.Email == users.Email).FirstOrDefault();
            if(data != null)
            {
                HttpContext.Session.SetString("Username", users.UserName);
                HttpContext.Session.SetString("role", data.Role);

                if (data.Role == "Admin")
                {
                    return RedirectToAction(nameof(AdminDashBoard));
                }
                return RedirectToAction(nameof(StaffDashBoard));
            }
            return View();
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction(nameof(Login));
        }
        public IActionResult AdminDashBoard()
        {
            if (HttpContext.Session.GetString("Username") != null)
            {
                return View();
            }
            return RedirectToAction(nameof(Login));
        }
        public IActionResult StaffDashBoard()
        {
            if(HttpContext.Session.GetString("Username") != null)
            {
                return View();
            }
            return RedirectToAction(nameof(Login));
        }


        public async Task<IActionResult> Index()
        {
            if (HttpContext.Session.GetString("role") == "Staff")
            {
                return View(nameof(Login));
            }
            return View(await _context.UsersManagement.ToListAsync());
        }

        // GET: Login/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usersManagement = await _context.UsersManagement
                .FirstOrDefaultAsync(m => m.Id == id);
            if (usersManagement == null)
            {
                return NotFound();
            }

            return View(usersManagement);
        }

        // GET: Login/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Login/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserName,DisplayName,Password,Email,Status,Role,ProfilePicture,RegisteredData")] UsersManagement usersManagement)
        {
            if (ModelState.IsValid)
            {
                usersManagement.Role = "Staff";
               _context.Add(usersManagement);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(usersManagement);
        }

        // GET: Login/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usersManagement = await _context.UsersManagement.FindAsync(id);
            if (usersManagement == null)
            {
                return NotFound();
            }
            return View(usersManagement);
        }

        // POST: Login/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UserName,DisplayName,Password,Email,Status,Role,ProfilePicture,RegisteredData")] UsersManagement usersManagement)
        {
            if (id != usersManagement.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(usersManagement);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UsersManagementExists(usersManagement.Id))
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
            return View(usersManagement);
        }

        // GET: Login/Delete/5

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usersManagement = await _context.UsersManagement
                .FirstOrDefaultAsync(m => m.Id == id);
            if (usersManagement == null)
            {
                return NotFound();
            }

            return View(usersManagement);
        }

        // POST: Login/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var usersManagement = await _context.UsersManagement.FindAsync(id);
            _context.UsersManagement.Remove(usersManagement);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UsersManagementExists(int id)
        {
            return _context.UsersManagement.Any(e => e.Id == id);
        }
    }
}

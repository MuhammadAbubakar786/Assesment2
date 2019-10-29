using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Assesment2.Models;
using Microsoft.AspNetCore.Http;
using System.Net.Mail;
using Assesment2.EmailTemplate;
using System.Net;
using System.Text;

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
        [HttpGet]
        public IActionResult ForgetPassword()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ForgetPassword(string email)
        {
            
            var temp = _context.UsersManagement.Find(email);
            
            if(temp != null)
            {
                MailMessage mail = new MailMessage();
                mail.Subject = "Recover Password";
                mail.Body = string.Format(Email.ForgetPasswordTemplate, temp.UserName, temp.Password);
                mail.IsBodyHtml = true;
                mail.From =new MailAddress("mianabubakar131998@gmail.com");
                mail.To.Add(temp.Email);
                SmtpClient smtp = new SmtpClient();
                smtp.Host="smtp.gmail.com";
                smtp.Port = 587;
                smtp.Credentials = new NetworkCredential("mianabubakar131998@gmail.com", "16009065048");
                smtp.EnableSsl = true;
                try
                {
                    smtp.Send(mail);
                }
                catch(Exception ex)
                {
                    ViewBag.error = ex;
                }
            }
            else
            {
                return View();
            }
            return RedirectToAction(nameof(Login));
        }
        [HttpPost]
        public IActionResult Login(UsersManagement users)
        {
            var data = _context.UsersManagement.Where(temp => temp.UserName == users.UserName && temp.Password == users.Password && temp.Email == users.Email).FirstOrDefault();
            if(data != null)
            {
                string username = "923117752858";
                string password = "6498";
                string Masking = "TwoStep";
                string toNumber = users.PhoneNumber;
                string code = new System.Random().Next(1000, 9999).ToString();
                HttpContext.Session.SetString("verifycode", code);
                sendMessage(username, password, Masking, toNumber, code);

                HttpContext.Session.SetString("Username", users.UserName);
                HttpContext.Session.SetString("role", data.Role);

                //MailMessage mailMessage = new MailMessage();
                //mailMessage.To.Add("mianabubakar131998@gmail.com");
                //mailMessage.From = new MailAddress(users.Email);
                //mailMessage.Subject = "VerificationCode";
                //mailMessage.IsBodyHtml = true;
                //mailMessage.Body = string.Format("Hi <b>" + users.UserName + "</b>,<br><br>Your Verification Code is:" + code + "<br><br><br>Regards,<br>Theta Team");


                //SmtpClient smtpClient = new SmtpClient();
                //smtpClient.Host = "smtp.gmail.com";
                //smtpClient.Port = 587;
                //smtpClient.Credentials = new NetworkCredential("mianabubakar131998@gmail.com", "16009065048");
                //smtpClient.EnableSsl = true;
                //smtpClient.Send(mailMessage);

                return RedirectToAction(nameof(TwoStepVerification));
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
                MailMessage OEmail = new MailMessage();
                OEmail.Body = string.Format(Email.EmailTemplate,usersManagement.UserName,usersManagement.UserName,usersManagement.Password);
                OEmail.IsBodyHtml = true;
                OEmail.Subject = "Welcome Email";
                OEmail.From = new MailAddress("mianabubakar131998@gmail.com");
                OEmail.To.Add(usersManagement.Email);

                SmtpClient client = new SmtpClient();
                client.Host = "smtp.gmail.com";
                client.Port = 587;
                client.EnableSsl = true;
                client.Credentials =new NetworkCredential("mianabubakar131998@gmail.com","16009065048");

                try
                {
                    client.Send(OEmail);
                }
                catch(Exception ex)
                {
                    ViewBag.error = ex;
                }
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
        [HttpGet]
        public IActionResult TwoStepVerification()
        {
            return View();
        }
        [HttpPost]

        public IActionResult TwoStepVerification(string code)
        {
            if(code != null)
            {
                 
                if (code == HttpContext.Session.GetString("verifycode") && HttpContext.Session.GetString("role") == "Admin")
                {
                    return RedirectToAction(nameof(AdminDashBoard));
                }
                if (code == HttpContext.Session.GetString("verifycode") && HttpContext.Session.GetString("role") == "Staff")
                {
                    return RedirectToAction(nameof(StaffDashBoard));
                }
            }

            return View();
        }
        /// <summary>
        /// Send Message Using sendpk.com Api
        /// </summary>
        public void sendMessage(string username,string password,string Masking,string toNumber,string MessageText)
        {
            String URI = "https://Sendpk.com" +
            "/api/sms.php?" +
            "username=" + username +
            "&password=" + password +
            "&sender=" + Masking +
            "&mobile=" + toNumber +
            "&message=" + Uri.UnescapeDataString(MessageText);
            try {
                WebClient web = new WebClient();
                
                string ResponseFromSMSAPI = web.DownloadString(URI);
            }
            catch(Exception ex)
            {
                string x = ex.ToString();
            }


        }
    }
}

using System.Collections.Generic;
using System.Data;
using System.Web.Mvc;
using TeamReflection.Data;
using TeamReflection.Enum;

namespace TeamReflection.Controllers
{
    public class AccountController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        // POST: Login 
        [HttpPost]
        public ActionResult Login(string Username, string Password)
        {
            //make a call to the database
            DataTable data = DatabaseCall.Get(StoredProcedures.Procedures.sp_LoginAccount,
                                              new Dictionary<string, string>()
                                              {
                                                  { "@Username", Username },
                                                  { "@Password", Password }
                                              }
                );
            if (data.Rows.Count > 0)
            {
                //data was returned - successfull login
                TempData["successMessage"] = "Login Successfull.";
                return RedirectToAction("Index","Home");
            }
            //return view
            ViewBag.errorMessage = "Login failed";
            return View();
        }


        // GET: Register
        public ActionResult Register()
        {
            return View();
        }

        // POST: Register
        [HttpPost]
        public ActionResult Register(string Username, 
                                     string Fullname, 
                                     string Password, 
                                     string ConfirmPassword, 
                                     string Email, 
                                     string PhoneNumber, 
                                     string BillingFirstLine, 
                                     string BillingPostCode, 
                                     string BillingCounty)
        {
            if (Username.Length < 1 || Fullname.Length < 1 || Password.Length < 1 || ConfirmPassword.Length < 1 || Email.Length < 1 || PhoneNumber.Length < 1 || BillingFirstLine.Length < 1 || BillingPostCode.Length < 1 || BillingCounty.Length < 1)
            {
                ViewBag.errorMessage = "Registration failed";
                return View();
            }
            //make a call to the database
            DataTable data = DatabaseCall.Get(StoredProcedures.Procedures.sp_RegisterAccount,
                                              new Dictionary<string, string>()
                                              {
                                                  { "@Username", Username },
                                                  { "@Fullname", Fullname },
                                                  { "@Password", Password },
                                                  { "@Email", Email },
                                                  { "@PhoneNumber", PhoneNumber },
                                                  { "@BillingFirstLine", BillingFirstLine },
                                                  { "@BillingPostCode", BillingPostCode },
                                                  { "@BillingCounty", BillingCounty },
                                              }
                );
            if (data.Rows.Count > 0)
            {
                //data was returned - successfull login
                TempData["successMessage"] = "Registration Successfull.";
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
    }
}
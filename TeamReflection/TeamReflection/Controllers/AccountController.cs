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

        public ActionResult Register()
        {
            return View();
        }
    }
}
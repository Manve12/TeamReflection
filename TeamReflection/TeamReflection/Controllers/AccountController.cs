using System.Web.Mvc;

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

            //return view
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }
    }
}
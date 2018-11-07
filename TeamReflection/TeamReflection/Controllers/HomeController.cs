using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TeamReflection.Data;

namespace TeamReflection.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            ///CODE BELOW IS FOR CALLING A PROCEDURE TO THE DATABASE AND STORING IT INSIDE OF DATATABLE

            //SqlCommand cmd = DbConnect.ConnectionDatabase.CreateCommand();
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.CommandText = "sp_TestProcedure";

            //cmd.CommandTimeout = DbConnect.ConnectionTimeout;

            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataTable data = new DataTable();

            //DbConnect.OpenConnection();

            //da.Fill(data);

            //DbConnect.CloseConnection();


            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description sausage.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
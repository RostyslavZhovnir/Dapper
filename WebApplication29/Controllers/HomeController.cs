using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication29.Models;

namespace WebApplication29.Controllers
{
    public class HomeController : Controller
    {
        //USING DAPPER
        public ActionResult Index()
        {
            DbConnection a = new SqlConnection(ConfigurationManager.ConnectionStrings["DepartmentsDB"].ConnectionString);
            a.Open();
           var z = a.Query<Departments>("SELECT * FROM DEPARTMENTS").ToList();

          
         return View();
        }

        public ActionResult About()
        {
            ViewBag.Message="Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message="Your contact page.";

            return View();
        }
    }
}
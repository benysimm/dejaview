using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using gucci_frontend.Models;

//Test Commit AR

namespace gucci_frontend.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }


        public IActionResult Client()
        {
            return View();
        }

        public IActionResult CreateRoute()
        {
            return View();
        }

        public IActionResult TestDb()
        {
            try
            {
                var content = new StringBuilder();

                var queryString = "SELECT * FROM [dbo].[test]";
                var connectionString = "Server=tcp:guccidb-server.database.windows.net,1433;Initial Catalog=gucci-db;Persist Security Info=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;User Id=obiwan;Password=Gucci2018;";

                using (var connection = new SqlConnection(connectionString))
                {
                    var command = new SqlCommand(queryString, connection);
                    connection.Open();
                    var reader = command.ExecuteReader();
                    try
                    {
                        while (reader.Read())
                        {
                            content.AppendFormat("{0}, {1}\n", reader["id"], reader["name"]);
                        }
                    }
                    finally
                    {
                        reader.Close();
                    }
                }

                return Content(content.ToString());
            }
            catch (Exception e)
            {
                return Content($"{e.Message} {e.StackTrace} {e.InnerException?.Message}");
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

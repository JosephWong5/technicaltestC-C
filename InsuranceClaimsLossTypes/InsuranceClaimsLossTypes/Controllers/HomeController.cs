using InsuranceClaimsLossTypes.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace InsuranceClaimsLossTypes.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private string connectionString = "Data Source=interview-testing-server.database.windows.net;Initial Catalog=Interview;User ID=TestLogin;Password=5D9ej2G64s3sd^;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public SqlConnection conn2 = new SqlConnection();
        private string selUsername = "";
        private string selPassword = "";
        private bool loggedIn = false;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public ActionResult VerifyLogin(string userName, string passWord)
        {
            selUsername = userName;
            selPassword = passWord;
            return RedirectToAction("Index");
        }

        public bool VerifyUsername() {
            var UserNames = new List<string>();
            string confirmUser = "";
            var conn2 = new SqlConnection();
            conn2.ConnectionString = connectionString;
            string sqlCmd = "select username from users";
            SqlCommand cmd = new SqlCommand(sqlCmd, conn2);
            conn2.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    UserNames.Add(reader["username"].ToString());
                }
            }
            conn2.Close();
            
            foreach (var users in UserNames)
            {
                if (users.Equals(selUsername)) 
                {
                    confirmUser = selUsername;
                }
            }
            if (confirmUser.Equals(selUsername))
            {
                return true;
            }
            else {
                return false;
            }
        }

        public bool VerifyPassword() {
            bool verifyUser = VerifyUsername();
            if (verifyUser == false)
            {
                return false;
            }
            else
            {
                string password = "";
                var conn2 = new SqlConnection();
                conn2.ConnectionString = connectionString;
                string sqlCmd = "select password from users where username = '" + selUsername + "'";
                SqlCommand cmd = new SqlCommand(sqlCmd, conn2);
                conn2.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        password = reader["password"].ToString();
                    }
                }
                conn2.Close();

                if (password.Equals(selPassword))
                {
                    loggedIn = true;
                    return true;
                }
                loggedIn = false;
                return false;
            }
        }

        public IActionResult Index()
        {
            if (loggedIn == false && VerifyPassword() == false)
            {
                ViewBag.ErrorMessage = "Username or password not found or matched";
                return View();
            }
            else if (loggedIn == false)
            {
                return View();
            }
            else
            {
                ViewBag.ErrorMessage = "Authenticated";
                return View();
            }
        }
         
        public IActionResult LossInformation()
        {
            var idList = new List<string>();
            var codeList = new List<string>();
            var descList = new List<string>();
            var conn2 = new SqlConnection();
            conn2.ConnectionString = connectionString;
            string sqlCmd = "select LossTypeId, LossTypeCode, LossTypeDescription from LossTypes";
            SqlCommand cmd = new SqlCommand(sqlCmd, conn2);
            conn2.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    idList.Add(reader["LossTypeId"].ToString());
                    codeList.Add(reader["LossTypeCode"].ToString());
                    descList.Add(reader["LossTypeDescription"].ToString());
                }
            }
            conn2.Close();

            ViewData["lossTypeId"] = idList;
            ViewData["lossTypeCode"] = codeList;
            ViewData["lossTypeDescription"] = descList;
            return View();
        }
    }
}

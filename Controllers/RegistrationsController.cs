using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Eclerx.Minakshee.Question1.Models;

namespace Eclerx.Minakshee.Question1.Controllers
{
    public class RegistrationsController : Controller
    {
        public string value = "";
        // GET: Registrations
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Registration r)
        {
            if (Request.HttpMethod == "Post")
            {
                Registration rs = new Registration();
                using (SqlConnection con = new SqlConnection("Data Source=ECXLC5503SQLEXPRESS01;Integrated Security=true;Initial Catalog=hr"))
                {
                    using (SqlCommand cmd = new SqlCommand("usp_AddNewStudents", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@StudentId", r.StudentId);
                        cmd.Parameters.AddWithValue("@UserId", r.UserId);
                        cmd.Parameters.AddWithValue("@Passwords", r.PassWords);
                        cmd.Parameters.AddWithValue("@DateOfBirth", r.DateOfBirth.ToString());
                        cmd.Parameters.AddWithValue("@MobileNo", r.MobileNo.ToString());
                        cmd.Parameters.AddWithValue("@CreatedDate", r.CreatedDate.ToString());
                        con.Open();
                        ViewData["result"] = cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
            }
            return View();
        }
    


        }
    
}
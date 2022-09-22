using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab_Task_01.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Home()
        {
            return View();
        }
        public ActionResult Profile()
        {
            ViewBag.Name = "Anik Das";
            ViewBag.Email = "anikdas987000@gmail.com";
            ViewBag.Phone = "01723337444";
            //ViewData["Good"] = "Very much available";
            return View();
        }
        public ActionResult Education()
        {
            ViewBag.BScInstitution = "American Internation University-Bangladesh(AIUB)";
            ViewBag.Semester = "11th";
            ViewBag.CGPA = "3.92";
            ViewBag.HSCinstitution = "Birshreahtha Noor Mohammad Public College";
            ViewBag.SSCinstitution = "Sreenagar Pilot High School";
            ViewBag.HSCyear = "2017";
            ViewBag.HSCgpa = "5.00";
            ViewBag.SSCyear = "2015";
            ViewBag.SSCgpa = "5.00";
            return View();
        }
        public ActionResult Projects()
        {
            return View();
        }
        public ActionResult References()
        {
            return View();
        }
    }
}
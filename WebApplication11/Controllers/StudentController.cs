using WebApplication11.Models;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;



namespace WebApplication11.Controllers
{
    public class StudentController : Controller
    {
        [ViewData]
        public string? Title { get; set; }

        public IActionResult Index()
        {
            Title = "CSIT SIXTH";
            ViewData["Message"] = "Welcome back guys ";
            return View();
        }

        public IActionResult Index5()
        {
            return View();
        }

        public string Index1()
        {
            return "Hello Students, the controller works";
        }

        public string Index2(int id, string name)
        {
            return "Hello " + name + ", the controller works that takes your id " + id;
        }

        public string Index3(int id)
        {
            return "test " + id;
        }

        public IActionResult ViewDetails(int id)
        {
            Student student = new Student()
            {
                id = id,
                name = "Nischal",
                address = "Tandi",
                faculty = "CSIT"
            };

            return View(student);
        }

        public IActionResult ViewDataExample()
        {
            ViewData["Greeting"] = "Hello";
            ViewData["Students"] = new Student()
            {
                name = "Nichal",
                address = "RNP-2",
                faculty = "CSIT"
            };
            return View();
        }

        public IActionResult ViewBagExample()
        {
            ViewBag.Title = "Student Details Page";
            ViewBag.Header = "Student Details from ViewBag";
            Student? student = new Student()
            {
                id = 101,
                name = "Nischal",
                address = "Tandi",
                faculty = "CSIT"
            };
            ViewBag.Student = student;
            return View();
        }
    }
}

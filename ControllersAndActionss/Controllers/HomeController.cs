using Microsoft.AspNetCore.Mvc;

namespace ControllersAndActionss.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Data1 = "This is Abhishek gwari";
            ViewBag.Data2 = 47;
            ViewBag.Data3 = DateTime.Now.ToShortDateString();

            ViewData["data6"] = "This is view data but can access through view bag ";
            ViewBag.data7 = "This is view bag but can access through view data ";

            string[] arr = { "Abhishek ", "Aman", "Lokesh" };
            ViewBag.Data4 = arr;

            ViewBag.Data5 = new List<string>()
            {
            "Cricket ", "Football", "Hockey"

                };






                //ViewData ["Data1"] = "Abhishek gwari";
                //ViewData["Data2"] = 2;
                //ViewData["Data3"] = DateTime.Now.ToLongDateString();

                //string[] arr = { "Abhishek ", "Aman", "Lokesh" };
                //ViewData["Data4"] = arr;

                //ViewData["Data5"] = new List<string>() {             
                //"Cricket ", "Football", "Hockey"

                //};
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public string Display()
        {
            return "Hey this is abhishek";
        }

        public int Displayid(int id)
        {
            return id;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BradWeb.Controllers
{
    public class HomeController : Controller
    {
        public string Index(int n = 3)
        {
            string b;
            BradApp.Bradmat m = new BradApp.Bradmat();
            int s = (n + 1) * (n + 2) / 2 + 1;
            int[,] a = new int[s, 2 * n + 1];
            a=m.crearebrad(n, s);
            b = "";
            int i, j;
            for (i = 0; i < s; i++)
            {
                for (j = 0; j <= n * 2; j++) if (a[i, j] == 1) b = b + "*";
                    else b = b + " ";
                b = b + "\n";

            }
            return b;
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

        public IActionResult Error()
        {
            return View();
        }
    }
}

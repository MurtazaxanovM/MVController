using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVController.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


namespace MVController.Controllers
{
    public class HomeController : Controller
    {

        List<Post> Posts;

        public HomeController()
        {
            Posts = new List<Post>()
            {
                new Post()
                {
                    Id = 1,
                    Title = ".NET bo'yicha maqola yozish mavsumimiz yana boshlandi  ",
                    Body = "Agar kimdir kitob yozmoqchi bo'lsa Diyorbek Mamataliyev (http://t.me/diyorbek_mamataliyev) ga murojaat qilsin.",
                    CreatedTime = DateTime.Now,
                    ImagePath = "logo.jpg"


                },
                new Post()
                {
                    Id = 2,
                    Title = ".NET bo'yicha maqola yozish mavsumimiz yana boshlandi  ",
                    Body = "Agar kimdir kitob yozmoqchi bo'lsa Diyorbek Mamataliyev (http://t.me/diyorbek_mamataliyev) ga murojaat qilsin.",
                    CreatedTime = DateTime.Now,
                    ImagePath = "logo.jpg"


                },
                new Post()
                {
                    Id = 3,
                    Title = ".NET bo'yicha maqola yozish mavsumimiz yana boshlandi  ",
                    Body = "Agar kimdir kitob yozmoqchi bo'lsa Diyorbek Mamataliyev (http://t.me/diyorbek_mamataliyev) ga murojaat qilsin.",
                    CreatedTime = DateTime.Now,
                    ImagePath = "logo.jpg"


                }


            };
        }


        public IActionResult Index()
        {
            return View(Posts);
        }

        public IActionResult Add()
        {
            return View();
        }
        public IActionResult Edit()
        {
            return View();
        }

        public IActionResult Detail()
        {
            return View();
        }


    }
        
}

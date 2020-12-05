using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PhotoCore.Mvc.Models;
using PhotoCore.DataAccess.Models;
using PhotoCore.DataAccess.MySql.Models;
using PhotoCore.Mvc.Models.Home;

namespace PhotoCore.DataAccess.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly PhotoCoreContext db;
        private readonly firstdi_coppermineContext mysql;

        public HomeController(ILogger<HomeController> logger, PhotoCoreContext db, firstdi_coppermineContext mysql)
        {
            _logger = logger;
            this.db = db;
            this.mysql = mysql;
        }

        public IActionResult Index()
        {
            var myusers = mysql.CmineUsers
                .Where(user => user.CmineAlbums.Any() && user.CmineAlbums.Any(al => al.CminePictures.Any()))
                .ToList();
            
            var model = new PhotoCore.Mvc.Models.Home.IndexModel{
                Users = myusers
            };

            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

using PhotoCore.DataAccess.MySql.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using PhotoCore.Mvc.Models.UserPhotos;

namespace PhotoCore.Mvc.Controllers
{

    public class UserPhotosController : Controller
    {
        private readonly firstdi_coppermineContext mysql;
        
        public UserPhotosController(firstdi_coppermineContext mysql)
        {
            this.mysql = mysql;
        }

        public IActionResult Index(int id)
        {
            var photos = mysql.CminePictures
                .Where(a => a.Aid == id)
                .ToList();

            var model = new IndexModel
            {
                Pictures = photos
            };

            return View(model);
        }
    }
}
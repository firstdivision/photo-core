using PhotoCore.DataAccess.MySql.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using PhotoCore.Mvc.Models.UserAlbums;

namespace PhotoCore.Mvc.Controllers
{

    public class UserAlbumsController : Controller
    {
        private readonly firstdi_coppermineContext mysql;
        
        public UserAlbumsController(firstdi_coppermineContext mysql)
        {
            this.mysql = mysql;
        }

        public IActionResult Index(int id)
        {
            var albums = mysql.CmineAlbums
                .Where(a => a.Owner == id)
                .ToList();

            var model = new IndexModel
            {
                Albums = albums
            };

            return View(model);
        }
    }
}
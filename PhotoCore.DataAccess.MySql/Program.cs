using System;
using System.Collections.Generic;
using System.Linq;
using PhotoCore.DataAccess.MySql.Models;

namespace PhotoCore.DataAccess.MySql
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new firstdi_coppermineContext())
            {
                var query = (from user in db.CmineUsers
                    join albums in db.CmineAlbums on user.UserId equals albums.Owner
                    select new {user, albums})
                    .ToList()
                    .GroupBy(g => new {g.user})
                    .Select(g => new {
                        User = g.Key.user,
                        Albums = g.Select(gg => gg.albums)
                    });
             
                foreach (var user in query)
                {
                    Console.WriteLine(user.User.UserName);

                    foreach (var album in user.Albums)
                    {
                        Console.WriteLine($"\t{album.Title}");
                    }
                    
                }
            }
        }
    }
}

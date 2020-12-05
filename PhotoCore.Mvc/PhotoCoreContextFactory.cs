/*
using System.IO;
using Microsoft.EntityFrameworkCore;

public class PhotoCoreContextFactory : IDesignTimeDbContextFactory
{
   public PhotoCoreContextFactory CreateDbContext(string[] args)
   {
      var configuration = new ConfigurationBuilder()
           .SetBasePath(Directory.GetCurrentDirectory())
           .AddJsonFile("appsettings.json")
           .Build();
 
      var dbContextBuilder = new DbContextOptionsBuilder();
 
      var connectionString = configuration
                  .GetConnectionString("SqlConnectionString");
 
      dbContextBuilder.UseSqlServer(connectionString);
 
      return new PhotoCoreContext(dbContextBuilder.Options);
    }
}
*/
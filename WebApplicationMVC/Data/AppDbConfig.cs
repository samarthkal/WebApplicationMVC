using Microsoft.EntityFrameworkCore;
using WebApplicationMVC.Models;

namespace WebApplicationMVC.Data
{
    public class AppDbConfig : DbContext
    {

        public AppDbConfig(DbContextOptions<AppDbConfig> options):base(options) {
         

        
        }

       DbSet<Category> Categories { get; set; }
        
            
       
    }
}

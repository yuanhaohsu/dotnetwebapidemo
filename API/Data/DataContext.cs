using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions options) : base(options) //Base = DBContext; options will be add #13
        {
        }

        public DbSet<AppUser> Users { get; set; }
         //Add this line
    }
}

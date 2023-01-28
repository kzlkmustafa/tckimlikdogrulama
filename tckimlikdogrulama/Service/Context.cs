using tckimlikdogrulama.Model;
using Microsoft.EntityFrameworkCore;

namespace tckimlikdogrulama.Service
{
    public class Context: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-GBUCNUJ;database=tcidwithSignupDb; integrated security=true;");
            optionsBuilder.EnableSensitiveDataLogging();

        }
        public DbSet<signupModel> signupModels { get; set; }
    }
}

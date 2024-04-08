
using Api_Task.Models;
using Api_Task.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace Demo_api.Data
{
    public class ApplicationDbContext : DbContext
    {
      
        public ApplicationDbContext()
        {

        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            var builder = new ConfigurationBuilder()
               .AddJsonFile("appsettings.json", true, true)
               .Build()
               .GetConnectionString("DefaultConnection");

            optionsBuilder.UseSqlServer(builder);
        }
        public DbSet<Product> products { get; set; } = default!;
      //  public DbSet<ProductDTO> productsDTO { get; set; } = default!;
    }
}

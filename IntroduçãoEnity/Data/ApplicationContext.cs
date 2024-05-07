using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
namespace CursoEFCore.Data
{
    public class ApplicationContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data source=(localdb)\\mssqllocaldb;Initial Catalog=CursoEFCore; Integrated Security=true");
        }
    }

}
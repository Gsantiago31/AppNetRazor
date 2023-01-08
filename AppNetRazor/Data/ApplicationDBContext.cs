using AppNetRazor.Models;
using Microsoft.EntityFrameworkCore;

namespace AppNetRazor.Data
{
    public class ApplicationDBContext : DbContext
    {

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }


        public DbSet<Curso> Curso { get; set; }
    }
}

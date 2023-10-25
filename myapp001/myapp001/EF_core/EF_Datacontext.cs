using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace myapp001.EF_core
{
    public class EF_Datacontext : DbContext
    {
        public EF_Datacontext(DbContextOptions<EF_Datacontext> options) : base(options) { }
        public DbSet<Student> students { get; set; }
        
       

    }
}

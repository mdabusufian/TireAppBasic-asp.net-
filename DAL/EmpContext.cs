using DAL.Models;
using System.Data.Entity;

namespace DAL
{
    public class EmpContext : DbContext
    {
        public DbSet<Test> Tests { get; set; }
    }
}

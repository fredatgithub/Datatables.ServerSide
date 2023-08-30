using Datatables.ServerSide.Models;
using Microsoft.EntityFrameworkCore;

namespace Datatables.ServerSide.Data
{
  public class ApplicationDbContext : DbContext
  {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
    public DbSet<Customer> Customers { get; set; }
  }
}

using Domain.Entities;
using Microsoft.EntityFrameworkCore;
namespace Infrastruvture.Data;

public class DataContext:DbContext
{

    public DataContext(DbContextOptions<DataContext> options):base(options)
    {
        
    }
    public DbSet<Contact> Boks {get;set;}
     public DbSet<User> Users { get; set; }
    public DbSet<Company> Companies { get; set; }

    

}

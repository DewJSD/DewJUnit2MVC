using Microsoft.EntityFrameworkCore;

// the CustContext class contains the initial entries for the database
namespace DewJUnit2MVC.Models
{
    public class CustContext: DbContext
    {
        public CustContext() { }

        public CustContext(DbContextOptions<CustContext> options)
        : base(options)
        { 
        }

        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(
                new Customer
                {
                    CustID = 1,
                    Name = "John Doe",
                    Username = "AnonyMouse",
                    Password = "tacosauce3000",
                },
                new Customer
                {
                    CustID = 2,
                    Name = "Solomon Batman",
                    Username = "DCgothboy",
                    Password = "batfamWebtoon",

                },
                new Customer
                {
                    CustID = 3,
                    Name = "Sally Acorn",
                    Username = "DenimVest",
                    Password = "KenPenderIsAHack",
                }
            );
        }
    }
}

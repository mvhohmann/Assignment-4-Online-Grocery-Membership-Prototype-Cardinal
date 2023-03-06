using System;
using Microsoft.EntityFrameworkCore;

namespace Assignment2 // You can use any namespace you like. Remember to add the using directive to Program.cs
{
    public class DBContext : DbContext
    {
        public DBContext (DbContextOptions<DBContext> options)
			: base(options)
		{
		}
        public DbSet<persons> persons {get; set;}=null!;
        public DbSet<address> address {get; set;}=null!;
        public DbSet<restaurants> restaurants {get; set;}=null!;
        public DbSet<drivers> drivers {get; set;}=null!;
        public DbSet<shoppers> shoppers {get; set;}=null!;
        public DbSet<menuItems> menuItems {get; set;}=null!;
        public DbSet<orders> orders {get; set;}=null!;
        public DbSet<menuOrders> menuOrders {get; set;}=null!;
    }
}
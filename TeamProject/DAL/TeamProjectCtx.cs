using System.Data.Entity;
using TeamProject.Models;

namespace TeamProject.DAL
{
    public class TeamProjectCtx : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<RequestList> RequestLists { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
    }
}
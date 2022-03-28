using System.Data.Entity;

namespace OnlineTicariOtomasyon.Models.Classes
{
    public class Context:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<SalesMove> SalesMoves { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<InvoiceItem> InvoiceItems { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Category> Categories { get; set; }


    }
}
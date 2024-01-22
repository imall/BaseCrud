using BaseCrud.Models;
using Microsoft.EntityFrameworkCore;

namespace BaseCrud.Data
{
    public class CmsContext : DbContext
    {
        public CmsContext(DbContextOptions<CmsContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employee { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee { Id = 1, Name = "imall", Mobile = "0987654321", Email = "imall@gmail.com", Department = "產品部", Title = "經理" },
                new Employee { Id = 2, Name = "Alice", Mobile = "0987654322", Email = "alice@gmail.com", Department = "行銷部", Title = "專員" },
                new Employee { Id = 3, Name = "Bob", Mobile = "0987654323", Email = "bob@gmail.com", Department = "財務部", Title = "經理" },
                new Employee { Id = 4, Name = "Carol", Mobile = "0987654324", Email = "carol@gmail.com", Department = "人力資源部", Title = "主管" },
                new Employee { Id = 5, Name = "David", Mobile = "0987654325", Email = "david@gmail.com", Department = "技術部", Title = "工程師" },
                new Employee { Id = 6, Name = "Eva", Mobile = "0987654326", Email = "eva@gmail.com", Department = "業務部", Title = "業務員" },
                new Employee { Id = 7, Name = "Frank", Mobile = "0987654327", Email = "frank@gmail.com", Department = "研發部", Title = "研究員" },
                new Employee { Id = 8, Name = "Grace", Mobile = "0987654328", Email = "grace@gmail.com", Department = "客服部", Title = "客服" },
                new Employee { Id = 9, Name = "Henry", Mobile = "0987654329", Email = "henry@gmail.com", Department = "採購部", Title = "專員" },
                new Employee { Id = 10, Name = "Ivy", Mobile = "0987654330", Email = "ivy@gmail.com", Department = "行政部", Title = "行政助理" }
                );
        }
    }
}

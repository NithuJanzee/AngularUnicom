using Microsoft.EntityFrameworkCore;
using ToDoList.Models;

namespace ToDoList.AppDbContext

{
    public class TaskDBContext : DbContext
    {
        public TaskDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<TaskItems> Tasks { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(o => o.Tasks)
                .WithOne(p => p.Assignee)
                .HasForeignKey(o => o.AssigneeId);


            modelBuilder.Entity<User>()
                .HasOne(a => a.Addreess)
                .WithOne(b => b.User)
                .HasForeignKey<Address>(c => c.UserId);

            base.OnModelCreating(modelBuilder);
        }
    }
}

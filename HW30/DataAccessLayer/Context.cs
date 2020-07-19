using DataAccessLayer.Models;
using System.Data.Entity;



namespace DataAccessLayer
{
    public class Context:DbContext
    {
        public Context(): base("DefaultConnection")
        {
            Database.SetInitializer(new CustomInitializer());
        }

        public DbSet<Task> Tasks { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CompletedTask> CompletedTasks { get; set; }
    }
}

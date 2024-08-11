using Microsoft.EntityFrameworkCore;

namespace Task_Manager.Contex
{

    public class TaskContext : DbContext
    {
        public DbSet<Task> Tasks { get; set; }

        public TaskContext(DbContextOptions<TaskContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuración adicional si es necesaria
        }
    }
}
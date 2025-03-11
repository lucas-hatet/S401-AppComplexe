using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace API_Vinted.Models.EntityFramework
{
    public class VintedDBContext : DbContext
    {
        public VintedDBContext()
        {
        }

        public VintedDBContext(DbContextOptions<VintedDBContext> options)
        : base(options)
        {
        }

       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.

        => optionsBuilder.EnableSensitiveDataLogging().UseNpgsql("Server=localhost;port=5432;Database=VintedDB; uid=postgres; password=postgres;");
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");

            base.OnModelCreating(modelBuilder);
        }
    }
}

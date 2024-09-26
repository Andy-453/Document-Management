using DocumentManagementBackend.Model;
using Microsoft.EntityFrameworkCore;

namespace DocumentManagementBackend.Context
{
    public class DMDbContext : DbContext
    {

        public DMDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<UserType> UserTypes { get; set; }
        public DbSet<Persons> Persons { get; set; }
        public DbSet<Permissions> Permissions { get; set; }
        public DbSet<UserTypeHasPermissions> UserTypeHasPermissions { get; set; }
        public DbSet<Documents> Documents { get; set; }
        public DbSet<Historic> Historics { get; set; }
        public DbSet<DocumentsHasUsers> Members { get; set; }
        public DbSet<DocumentsHasHistory> DocumentsHasHistories { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                .HasKey(u => u.Id);

            modelBuilder.Entity<UserTypeHasPermissions>()
                .HasNoKey();

            modelBuilder.Entity<DocumentsHasHistory>()
                .HasNoKey();

            modelBuilder.Entity<DocumentsHasUsers>()
                .HasNoKey();
        }
    }
} 

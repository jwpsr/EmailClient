using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Data.DbContexts
{
    public class EmailContext : DbContext
    {
        private IConfigurationRoot _config;

        public EmailContext(DbContextOptions options, IConfigurationRoot config)
            : base(options)
        {
            _config = config;
        }

        public DbSet<Email> Emails { get; set; }
        public DbSet<Recipient> Recipients { get; set; }
        public DbSet<EmailTemplate> EmailTemplates { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(_config.GetConnectionString("EmailContext"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Email>()
                .ToTable("Email")
                .Property(x => x.EmailId).UseSqlServerIdentityColumn();

            modelBuilder.Entity<EmailRecipient>()
                .ToTable("EmailRecipient")
                .Property(x => x.EmailRecipientId).UseSqlServerIdentityColumn();

            modelBuilder.Entity<Recipient>()
                .ToTable("Recipient")
                .Property(x => x.RecipientId).UseSqlServerIdentityColumn();

            modelBuilder.Entity<EmailTemplate>()
                .ToTable("EmailTemplate")
                .Property(x => x.Id).UseSqlServerIdentityColumn();
        }
    }
}

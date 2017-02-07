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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(_config.GetConnectionString("EmailContext"));
        }
    }
}

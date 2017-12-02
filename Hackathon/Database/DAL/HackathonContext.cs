using Hackathon.Database.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hackathon.Database.DAL
{
    public class HackathonContext : DbContext
    {
        public HackathonContext(DbContextOptions options) : base(options){ }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Disability> Disabilities { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<FeatureSchool> FeaturesSchools { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;Database=Hackathon;Trusted_Connection=true;MultipleActiveResultSets=true;connect timeout=100000");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<FeatureSchool>()
                .HasKey(fs => new { fs.FeatureId, fs.SchoolId });

            builder.Entity<FeatureSchool>()
                .HasOne(fs => fs.School)
                .WithMany(f => f.FeaturesSchools)
                .HasForeignKey(s => s.SchoolId);

            builder.Entity<FeatureSchool>()
                .HasOne(fs => fs.Feature)
                .WithMany(fs => fs.FeaturesSchools)
                .HasForeignKey(f => f.FeatureId);
        }
    }
}

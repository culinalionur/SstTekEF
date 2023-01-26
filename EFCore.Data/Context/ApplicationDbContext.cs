using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCore.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCore.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
       
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer();
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("dbo");
            

            modelBuilder.Entity<Student>().Property(i => i.FirstName)
                .HasColumnName("first_name")
                .HasColumnType("nvarchar")
                .HasMaxLength(100);

            modelBuilder.Entity<Student>(entity =>
            {
                entity.Property(i => i.Id)
                .HasColumnName("id")
                .HasColumnType("int")
                .UseIdentityColumn()
                .IsRequired();
            });
        }
    }
}

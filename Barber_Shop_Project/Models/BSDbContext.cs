using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Barber_Shop_Project.Models
{
    public class BSDbContext : IdentityDbContext<User>
    {
        public BSDbContext(DbContextOptions<BSDbContext> options) : base(options)
        {
        }

        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.Fname)
                    .IsRequired()
                    .HasColumnName("FName");

                entity.Property(e => e.Lname)
                    .IsRequired()
                    .HasColumnName("LName");

                entity.Property(e => e.Position).IsRequired();
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.Date)
                    .IsRequired()
                    .HasColumnType("NUMERIC");

                entity.Property(e => e.DateOfRecording)
                    .IsRequired()
                    .HasColumnType("NUMERIC");

                entity.Property(e => e.HaircutName).IsRequired();

                entity.Property(e => e.UsersId).IsRequired();

                entity.HasOne(d => d.Employees)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.EmployeesId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Users)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.UsersId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Employee>().HasData(new[]
            {
                new Employee()  { Fname = "Denis",   Lname = "Alejandro", MobilePhone = "+375292436302",  Position = "Hairdresser", Id = 1},
                new Employee()  { Fname = "George",  Lname = "Fletcher",  MobilePhone = "+375292436300",  Position = "Hairdresser", Id = 2},
                new Employee()  { Fname = "Oliver",  Lname = " O’Neal",   MobilePhone = "+375292856302",  Position = "Hairdresser", Id = 3},
                new Employee()  { Fname = "Peter",   Lname = "Hampton",   MobilePhone = "+375292436356",  Position = "Hairdresser", Id = 4},
                new Employee()  { Fname = "Terence", Lname = "Floyd",     MobilePhone = "+375292436323",  Position = "Hairdresser", Id = 5},
                new Employee()  { Fname = "Matthew", Lname = "Johnson",   MobilePhone = "+3752924363087", Position = "Hairdresser", Id = 6},
            });
        }
    }
}
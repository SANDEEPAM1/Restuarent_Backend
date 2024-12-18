﻿using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Restuarent_Backend.Models.CustomerEntity;
using Restuarent_Backend.Models.DeliveryPersonEntitiiy;
using Restuarent_Backend.Models.LoginHistoryEntity;
using Restuarent_Backend.Models.MenuEntity;
using Restuarent_Backend.Models.OrderEntitiy;
using Restuarent_Backend.Models.OrderItemEntity;
using Restuarent_Backend.Models.PaymentEntity;
using Restuarent_Backend.Models.PhysicalTableEntity;
using Restuarent_Backend.Models.ReservationEntity;
using Restuarent_Backend.Utilities;
using Restuarent_Backend.Models;


namespace Restuarent_Backend.Data
{
    public class ResturantDBContext : IdentityDbContext<IdentityUser>
    {
        public ResturantDBContext(DbContextOptions<ResturantDBContext> options) :base(options)
        {
            
        }

        public DbSet<MenuTable> MenuItems { get; set; }
        public DbSet<CustomerProfile> CustomerProfiles { get; set; }
        public DbSet<LoginHistoryTable> LoginHistorys { get; set; }
        public DbSet<DeliveryPerson> DeliveryPersons { get; set; }
        public DbSet<OrderTable> OrderTables { get; set; }
        public DbSet<OrderItemTable> OrderItemTables { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<PhysicalTable> PhysicalTables { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<AdminEntity> AdminEntities { get; set; }
        public DbSet<ChefEntity> chefEntities { get; set; }
        public DbSet<WaiterEntity> waiterEntities { get; set; }
        public DbSet<Comment> comments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)

          
        {
              base.OnModelCreating(modelBuilder);
                // CustomerProfile to LoginHistoryTable (One-to-One)
                modelBuilder.Entity<CustomerProfile>()
                    .HasOne(c => c.LoginHistoryTable)
                    .WithOne(l => l.CustomerProfile)
                    .HasForeignKey<LoginHistoryTable>(l => l.CustomerId);

                // CustomerProfile to OrderTable (One-to-Many)
                modelBuilder.Entity<CustomerProfile>()
                    .HasMany(c => c.OrderTables)
                    .WithOne(o => o.CustomerProfile)
                    .HasForeignKey(o => o.CustomerId);

                modelBuilder.Entity<CustomerProfile>()
                    .HasOne(cp => cp.User)  // Navigation property in CustomerProfile
                    .WithMany()          
                    .HasForeignKey(cp => cp.UserId)  
                    .OnDelete(DeleteBehavior.Cascade);

                        // DeliveryPerson to OrderTable (One-to-Many)
                modelBuilder.Entity<DeliveryPerson>()
                    .HasMany(d => d.OrderTables)
                    .WithOne(o => o.DeliveryPerson)
                    .HasForeignKey(o => o.DeliveryPerosnId)
                    .OnDelete(DeleteBehavior.SetNull);


            // OrderTable to OrderItemTable (One-to-Many)
            modelBuilder.Entity<OrderTable>()
                .HasMany(o => o.OrderItems)
                .WithOne(oi => oi.OrderTable)
                .HasForeignKey(oi => oi.OrderID)
                .OnDelete(DeleteBehavior.Cascade);

                // OrderTable to Payment (One-to-One)
                modelBuilder.Entity<OrderTable>()
                    .HasOne(o => o.Payment)
                    .WithOne(p => p.OrderTable)
                    .HasForeignKey<Payment>(p => p.OrderId)
                    .OnDelete(DeleteBehavior.Cascade);

                // MenuTable to OrderItemTable (One-to-Many)
                modelBuilder.Entity<MenuTable>()
                    .HasMany(m => m.OrderItemTables)
                    .WithOne(oi => oi.MenuTable)
                    .HasForeignKey(oi => oi.MenuItemId);

                // PhysicalTable to Reservation (One-to-Many)
                modelBuilder.Entity<PhysicalTable>()
                    .HasMany(p => p.Reservations)
                    .WithOne(r => r.PhysicalTable)
                    .HasForeignKey(r => r.TableId);

                // CustomerProfile to Reservation (One-to-Many)
                modelBuilder.Entity<CustomerProfile>()
                    .HasMany(c => c.Reservations)
                    .WithOne(r => r.CustomerProfile)
                    .HasForeignKey(r => r.CustomerId);

                modelBuilder.Entity<WaiterEntity>()
                    .HasOne(w => w.User) // Navigation property to IdentityUser
                    .WithMany()          // No reverse navigation in IdentityUser
                    .HasForeignKey(w => w.UserId) // Foreign key in WaiterEntity
                    .OnDelete(DeleteBehavior.Cascade); // Enable cascading deletes

            // Configure ChefEntity relationship
                    modelBuilder.Entity<ChefEntity>()
                        .HasOne(c => c.User) // Navigation property to IdentityUser
                        .WithMany()          // No reverse navigation in IdentityUser
                        .HasForeignKey(c => c.UserId) // Foreign key in ChefEntity
                        .OnDelete(DeleteBehavior.Cascade); // Enable cascading deletes

            // Configure AdminEntity relationship
                modelBuilder.Entity<AdminEntity>()
                    .HasOne(a => a.User) // Navigation property to IdentityUser
                    .WithMany()          // No reverse navigation in IdentityUser
                    .HasForeignKey(a => a.UserId) // Foreign key in AdminEntity
                    .OnDelete(DeleteBehavior.Cascade);

            //modelBuilder.Entity<DeliveryPerson>()
            //   .HasOne(dp => dp.User) // Navigation property to IdentityUser
            //   .WithMany()            // No reverse navigation in IdentityUser
            //   .HasForeignKey(dp => dp.UserId) // Foreign key in DeliveryPerson
            //   .OnDelete(DeleteBehavior.Cascade);

            // Setting default value for IsAvailable fields
            modelBuilder.Entity<DeliveryPerson>()
                    .Property(dp => dp.IsAvailable)
                    .HasDefaultValue(false);

                modelBuilder.Entity<PhysicalTable>()
                    .Property(pt => pt.IsAvailable)
                    .HasDefaultValue(true);

                modelBuilder.Entity<MenuTable>()
                    .Property(mt => mt.IsAvailable)
                    .HasDefaultValue(true);


            //Seeding data for roles, customer and admin
          
            string adminRoleId = Guid.NewGuid().ToString();
            string customerRoleId = Guid.NewGuid().ToString();
            string chefRoleId = Guid.NewGuid().ToString();
            string deliveryPersonRoleId = Guid.NewGuid().ToString();
            string waiterRoleId = Guid.NewGuid().ToString();

            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = adminRoleId,
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                },
                new IdentityRole
                {
                    Id = customerRoleId,
                    Name = "Customer",
                    NormalizedName = "CUSTOMER"
                },
                 new IdentityRole
                 {
                     Id = chefRoleId,
                     Name = "Chef",
                     NormalizedName = "CHEF"
                 },
                new IdentityRole
                {
                    Id = deliveryPersonRoleId,
                    Name = "DeliveryPerson",
                    NormalizedName = "DELIVERYPERSON"
                },
                new IdentityRole
                {
                    Id = waiterRoleId,
                    Name = "Waiter",
                    NormalizedName = "WAITER"
                }
            );

            // Create password hasher to hash the passwords
            var hasher = new PasswordHasher<IdentityUser>();

            // Seed admin user
            var adminUserId = Guid.NewGuid().ToString();
            modelBuilder.Entity<IdentityUser>().HasData(
                new IdentityUser
                {
                    Id = adminUserId,
                    UserName = "admin@example.com",
                    NormalizedUserName = "ADMIN@EXAMPLE.COM",
                    Email = "admin@example.com",
                    NormalizedEmail = "ADMIN@EXAMPLE.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "YourSecureAdminPassword123!")  // Admin password
                }
            );

            // Seed customer user
            var customerUserId = Guid.NewGuid().ToString();
            var customerUserName = "Sandeepa#";
            var customerEmail = "sandeepa@example.com";

            modelBuilder.Entity<IdentityUser>().HasData(
                new IdentityUser
                {
                    Id = customerUserId,
                    UserName = customerUserName,
                    NormalizedUserName = "SANDEEPA#",
                    Email = customerEmail,
                    NormalizedEmail = "SANDEEPA@EXAMPLE.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "sandeepa123!")  // Customer password
                }
            );

            // Assign roles to users
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    UserId = adminUserId,
                    RoleId = adminRoleId
                },
                new IdentityUserRole<string>
                {
                    UserId = customerUserId,
                    RoleId = customerRoleId
                }
            );

             modelBuilder.Entity<CustomerProfile>().HasData(
               new CustomerProfile
               {
                   CustomerId = GenerateCustomerId.customIdGenerator(customerUserName, customerEmail), // Assuming this generates a unique ID
                   UserName = customerUserName,
                   Email = customerEmail,
                   RegistrationDate = DateTime.Now,
                   IsActive = true,
                   IsLoggin = false,
                   UserId = customerUserId // Link to the IdentityUser
               }
           );

            modelBuilder.Entity<DeliveryPerson>().HasData(
           new DeliveryPerson
           {
               DeliveryPersonId = 1,
               FullName = "John Doe",
               PhoneNumber = "123456789",
               IsAvailable = true
           },
           new DeliveryPerson
           {
               DeliveryPersonId = 2,
               FullName = "Jane Smith",
               PhoneNumber = "987654321",
               IsAvailable = true
           }
       );


        }

    }
}

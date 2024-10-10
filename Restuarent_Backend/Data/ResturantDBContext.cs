using Microsoft.EntityFrameworkCore;
using Restuarent_Backend.Models.CustomerEntity;
using Restuarent_Backend.Models.DeliveryPersonEntitiiy;
using Restuarent_Backend.Models.LoginHistoryEntity;
using Restuarent_Backend.Models.MenuEntity;
using Restuarent_Backend.Models.OrderEntitiy;
using Restuarent_Backend.Models.OrderItemEntity;
using Restuarent_Backend.Models.PaymentEntity;
using Restuarent_Backend.Models.PhysicalTableEntity;
using Restuarent_Backend.Models.ReservationEntity;

namespace Restuarent_Backend.Data
{
    public class ResturantDBContext : DbContext
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
{
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

    // DeliveryPerson to OrderTable (One-to-Many)
    modelBuilder.Entity<DeliveryPerson>()
        .HasMany(d => d.OrderTables)
        .WithOne(o => o.DeliveryPerson)
        .HasForeignKey(o => o.DeliveryPerosnId);

    // OrderTable to OrderItemTable (One-to-Many)
    modelBuilder.Entity<OrderTable>()
        .HasMany(o => o.OrderItems)
        .WithOne(oi => oi.OrderTable)
        .HasForeignKey(oi => oi.OrderID);

    // OrderTable to Payment (One-to-One)
    modelBuilder.Entity<OrderTable>()
        .HasOne(o => o.Payment)
        .WithOne(p => p.OrderTable)
        .HasForeignKey<Payment>(p => p.OrderId);

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
}

    }
}

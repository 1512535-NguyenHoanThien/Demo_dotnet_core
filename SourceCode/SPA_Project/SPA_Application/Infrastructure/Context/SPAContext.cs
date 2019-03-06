using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SPA_Application.Domains.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPA_Application.Infrastructure.Context
{
    public class SPAContext : IdentityDbContext<User>
    {
        public SPAContext(DbContextOptions<SPAContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //Config AppointmentDetail Entity
            modelBuilder.Entity<AppointmentDetail>().HasKey(key => new { key.AppointmentId, key.ServiceId, key.Order});

            //Config TherapistAbility Entity
            modelBuilder.Entity<TherapistAbility>().HasKey(key => new { key.ServiceId, key.TherapistId });
            modelBuilder.Entity<TherapistAbility>()
                .HasOne<User>(p => p.Therapist)
                .WithMany(p => p.TherapistAbilities)
                .HasForeignKey(p => p.TherapistId);

            //Config BufferTime Entity
            modelBuilder.Entity<BufferTime>().HasKey(key => new { key.TherapistId, key.ServiceId });
            modelBuilder.Entity<BufferTime>()
                .HasOne<User>(p => p.Therapist)
                .WithMany(p => p.BufferTimes)
                .HasForeignKey(p => p.TherapistId);

            //Config BedAbility Entity
            modelBuilder.Entity<BedAbility>().HasKey(key => new { key.ServiceId, key.BedId });

            //Config Outlet Ability Entity
            modelBuilder.Entity<OutletAbility>().HasKey(key => new { key.ServiceId, key.OutletId });
        }

        public DbSet<Appointment> Appointments { set; get; }
        public DbSet<Bed> Beds { set; get; }
        public DbSet<BufferTime> BufferTimes { set; get; }
        public DbSet<FeedBack> FeedBacks { set; get; }
        public DbSet<Note> Notes { set; get; }
        public DbSet<Notification> Notifications { set; get; }
        public DbSet<Outlet> Outlets { set; get; }
        public DbSet<Result> Results { set; get; }
        public DbSet<Room> Rooms { set; get; }
        public DbSet<Service> Services { set; get; }
       
        public DbSet<Term> Terms { set; get; }
        public DbSet<AppointmentDetail> AppointmentDetails { set; get; }
        public DbSet<TherapistAbility> TherapistAbilities { set; get; }
        public DbSet<BedAbility> BedAbilities { set; get; }
        public DbSet<ServiceType> ServiceTypes { set; get; }

        public DbSet<StaffManager> StaffManagers { set; get; }
    }
}

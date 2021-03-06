﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SPA_Application.Infrastructure.Context;

namespace SPA_Application.Migrations
{
    [DbContext(typeof(SPAContext))]
    [Migration("20181222182015_commentBedProperty")]
    partial class commentBedProperty
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("SPA_Application.Domains.Entity.Appointment", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateBooked");

                    b.Property<bool>("EntityStatus");

                    b.Property<string>("ExtraNote");

                    b.Property<bool>("IsPaid");

                    b.Property<DateTime>("LastCreatedDate");

                    b.Property<DateTime>("LastUpdatedDate");

                    b.Property<long>("OutletId");

                    b.Property<int>("Status");

                    b.Property<long>("TotalPrice");

                    b.Property<int>("TotalTime");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("OutletId");

                    b.HasIndex("UserId");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("SPA_Application.Domains.Entity.AppointmentDetail", b =>
                {
                    b.Property<long>("AppointmentId");

                    b.Property<long>("ServiceId");

                    b.Property<int>("Order");

                    b.Property<long?>("BedId");

                    b.Property<bool>("EntityStatus");

                    b.Property<DateTime>("FinishTime");

                    b.Property<DateTime>("LastCreatedDate");

                    b.Property<DateTime>("LastUpdatedDate");

                    b.Property<DateTime>("StartTime");

                    b.HasKey("AppointmentId", "ServiceId", "Order");

                    b.HasIndex("BedId");

                    b.HasIndex("ServiceId");

                    b.ToTable("AppointmentDetails");
                });

            modelBuilder.Entity("SPA_Application.Domains.Entity.Bed", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("EntityStatus");

                    b.Property<string>("ExtraNote");

                    b.Property<DateTime>("LastCreatedDate");

                    b.Property<DateTime>("LastUpdatedDate");

                    b.Property<long>("RoomId");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.HasIndex("RoomId");

                    b.ToTable("Beds");
                });

            modelBuilder.Entity("SPA_Application.Domains.Entity.BedAbility", b =>
                {
                    b.Property<long>("ServiceId");

                    b.Property<long>("BedId");

                    b.Property<bool>("EntityStatus");

                    b.Property<DateTime>("LastCreatedDate");

                    b.Property<DateTime>("LastUpdatedDate");

                    b.HasKey("ServiceId", "BedId");

                    b.HasIndex("BedId");

                    b.ToTable("BedAbilities");
                });

            modelBuilder.Entity("SPA_Application.Domains.Entity.BufferTime", b =>
                {
                    b.Property<string>("TherapistId");

                    b.Property<long>("ServiceId");

                    b.Property<bool>("EntityStatus");

                    b.Property<DateTime>("LastCreatedDate");

                    b.Property<DateTime>("LastUpdatedDate");

                    b.Property<int>("Time");

                    b.HasKey("TherapistId", "ServiceId");

                    b.HasIndex("ServiceId");

                    b.ToTable("BufferTimes");
                });

            modelBuilder.Entity("SPA_Application.Domains.Entity.FeedBack", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content");

                    b.Property<bool>("EntityStatus");

                    b.Property<long>("IdTarget");

                    b.Property<DateTime>("LastCreatedDate");

                    b.Property<DateTime>("LastUpdatedDate");

                    b.Property<int>("Star");

                    b.Property<int>("TargetType");

                    b.Property<long>("UserId");

                    b.Property<string>("UserId1");

                    b.HasKey("Id");

                    b.HasIndex("UserId1");

                    b.ToTable("FeedBacks");
                });

            modelBuilder.Entity("SPA_Application.Domains.Entity.Note", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content");

                    b.Property<bool>("EntityStatus");

                    b.Property<DateTime>("LastCreatedDate");

                    b.Property<DateTime>("LastUpdatedDate");

                    b.HasKey("Id");

                    b.ToTable("Notes");
                });

            modelBuilder.Entity("SPA_Application.Domains.Entity.Notification", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content");

                    b.Property<bool>("EntityStatus");

                    b.Property<DateTime>("LastCreatedDate");

                    b.Property<DateTime>("LastUpdatedDate");

                    b.Property<int>("TargetType");

                    b.Property<long>("UserId");

                    b.HasKey("Id");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("SPA_Application.Domains.Entity.Outlet", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<bool>("EntityStatus");

                    b.Property<DateTime>("LastCreatedDate");

                    b.Property<DateTime>("LastUpdatedDate");

                    b.Property<double>("Latitude");

                    b.Property<double>("Longitude");

                    b.Property<string>("Name");

                    b.Property<string>("Phone");

                    b.HasKey("Id");

                    b.ToTable("Outlets");
                });

            modelBuilder.Entity("SPA_Application.Domains.Entity.OutletAbility", b =>
                {
                    b.Property<long>("ServiceId");

                    b.Property<long>("OutletId");

                    b.Property<bool>("EntityStatus");

                    b.Property<DateTime>("LastCreatedDate");

                    b.Property<DateTime>("LastUpdatedDate");

                    b.HasKey("ServiceId", "OutletId");

                    b.HasIndex("OutletId");

                    b.ToTable("OutletAbility");
                });

            modelBuilder.Entity("SPA_Application.Domains.Entity.Result", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("AppointmentId");

                    b.Property<int>("BMI");

                    b.Property<int>("BodyMass");

                    b.Property<bool>("EntityStatus");

                    b.Property<int>("FatContent");

                    b.Property<int>("Height");

                    b.Property<DateTime>("LastCreatedDate");

                    b.Property<DateTime>("LastUpdatedDate");

                    b.Property<int>("MuscleContent");

                    b.Property<int>("StomachFat");

                    b.Property<int>("Weight");

                    b.HasKey("Id");

                    b.HasIndex("AppointmentId")
                        .IsUnique();

                    b.ToTable("Results");
                });

            modelBuilder.Entity("SPA_Application.Domains.Entity.Room", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("EntityStatus");

                    b.Property<string>("ExtraNote");

                    b.Property<DateTime>("LastCreatedDate");

                    b.Property<DateTime>("LastUpdatedDate");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("SPA_Application.Domains.Entity.Service", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content");

                    b.Property<bool>("EntityStatus");

                    b.Property<string>("ImgUrl");

                    b.Property<DateTime>("LastCreatedDate");

                    b.Property<DateTime>("LastUpdatedDate");

                    b.Property<long>("Price");

                    b.Property<string>("ServiceName");

                    b.Property<int>("ServiceTypeId");

                    b.Property<int>("Time");

                    b.HasKey("Id");

                    b.HasIndex("ServiceTypeId");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("SPA_Application.Domains.Entity.ServiceType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("EntityStatus");

                    b.Property<string>("ImageUrl");

                    b.Property<DateTime>("LastCreatedDate");

                    b.Property<DateTime>("LastUpdatedDate");

                    b.Property<string>("ServiceName");

                    b.HasKey("Id");

                    b.ToTable("ServiceTypes");
                });

            modelBuilder.Entity("SPA_Application.Domains.Entity.Term", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content");

                    b.Property<bool>("EntityStatus");

                    b.Property<DateTime>("LastCreatedDate");

                    b.Property<DateTime>("LastUpdatedDate");

                    b.HasKey("Id");

                    b.ToTable("Terms");
                });

            modelBuilder.Entity("SPA_Application.Domains.Entity.TherapistAbility", b =>
                {
                    b.Property<long>("ServiceId");

                    b.Property<string>("TherapistId");

                    b.Property<bool>("EntityStatus");

                    b.Property<DateTime>("LastCreatedDate");

                    b.Property<DateTime>("LastUpdatedDate");

                    b.Property<int>("level");

                    b.HasKey("ServiceId", "TherapistId");

                    b.HasIndex("TherapistId");

                    b.ToTable("TherapistAbilities");
                });

            modelBuilder.Entity("SPA_Application.Domains.Entity.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("Address");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FullName");

                    b.Property<int>("Gender");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("SPA_Application.Domains.Entity.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("SPA_Application.Domains.Entity.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SPA_Application.Domains.Entity.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("SPA_Application.Domains.Entity.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SPA_Application.Domains.Entity.Appointment", b =>
                {
                    b.HasOne("SPA_Application.Domains.Entity.Outlet", "Outlet")
                        .WithMany("Appointments")
                        .HasForeignKey("OutletId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SPA_Application.Domains.Entity.User", "User")
                        .WithMany("Appointments")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("SPA_Application.Domains.Entity.AppointmentDetail", b =>
                {
                    b.HasOne("SPA_Application.Domains.Entity.Appointment", "Appointment")
                        .WithMany("AppointmentDetails")
                        .HasForeignKey("AppointmentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SPA_Application.Domains.Entity.Bed")
                        .WithMany("AppointmentDetails")
                        .HasForeignKey("BedId");

                    b.HasOne("SPA_Application.Domains.Entity.Service", "Service")
                        .WithMany("AppointmentDetails")
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SPA_Application.Domains.Entity.Bed", b =>
                {
                    b.HasOne("SPA_Application.Domains.Entity.Room", "Room")
                        .WithMany("Beds")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SPA_Application.Domains.Entity.BedAbility", b =>
                {
                    b.HasOne("SPA_Application.Domains.Entity.Bed", "Bed")
                        .WithMany()
                        .HasForeignKey("BedId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SPA_Application.Domains.Entity.Service", "Service")
                        .WithMany()
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SPA_Application.Domains.Entity.BufferTime", b =>
                {
                    b.HasOne("SPA_Application.Domains.Entity.Service", "Service")
                        .WithMany()
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SPA_Application.Domains.Entity.User", "Therapist")
                        .WithMany("BufferTimes")
                        .HasForeignKey("TherapistId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SPA_Application.Domains.Entity.FeedBack", b =>
                {
                    b.HasOne("SPA_Application.Domains.Entity.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId1");
                });

            modelBuilder.Entity("SPA_Application.Domains.Entity.OutletAbility", b =>
                {
                    b.HasOne("SPA_Application.Domains.Entity.Outlet", "Outlet")
                        .WithMany("OutletAbilities")
                        .HasForeignKey("OutletId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SPA_Application.Domains.Entity.Service", "Service")
                        .WithMany("OutletAbilities")
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SPA_Application.Domains.Entity.Result", b =>
                {
                    b.HasOne("SPA_Application.Domains.Entity.Appointment", "Appointment")
                        .WithOne("Result")
                        .HasForeignKey("SPA_Application.Domains.Entity.Result", "AppointmentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SPA_Application.Domains.Entity.Service", b =>
                {
                    b.HasOne("SPA_Application.Domains.Entity.ServiceType", "ServiceType")
                        .WithMany("Services")
                        .HasForeignKey("ServiceTypeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SPA_Application.Domains.Entity.TherapistAbility", b =>
                {
                    b.HasOne("SPA_Application.Domains.Entity.Service", "Service")
                        .WithMany()
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SPA_Application.Domains.Entity.User", "Therapist")
                        .WithMany("TherapistAbilities")
                        .HasForeignKey("TherapistId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

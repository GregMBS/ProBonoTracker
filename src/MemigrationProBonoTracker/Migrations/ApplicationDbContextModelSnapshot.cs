﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using MemigrationProBonoTracker.Data;

namespace MemigrationProBonoTracker.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MemigrationProBonoTracker.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id");

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedUserName")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("MemigrationProBonoTracker.Models.AssociatedPerson", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CaseId");

                    b.Property<int?>("PersonId");

                    b.Property<string>("Relationship");

                    b.HasKey("Id");

                    b.HasIndex("CaseId");

                    b.HasIndex("PersonId");

                    b.ToTable("AssociatedPerson");
                });

            modelBuilder.Entity("MemigrationProBonoTracker.Models.Attorney", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BarNumber");

                    b.Property<double>("ClcContribution");

                    b.Property<bool>("DesiredVolunteer");

                    b.Property<string>("FirstName");

                    b.Property<int>("Gender");

                    b.Property<bool>("HasImmigrationExperience");

                    b.Property<bool>("HasJuvenileExperience");

                    b.Property<bool>("HasProbateExperience");

                    b.Property<bool>("InterestedVolunteer");

                    b.Property<bool>("IsAssigningAttorney");

                    b.Property<string>("LastName");

                    b.Property<double>("LatinoMemContribution");

                    b.Property<double>("MiaContribution");

                    b.Property<string>("Notes");

                    b.Property<string>("OrganizationName");

                    b.Property<DateTime>("RecruitmentDate");

                    b.Property<int>("RecruitmentMethod");

                    b.Property<bool>("SpeaksSpanish");

                    b.HasKey("Id");

                    b.ToTable("Attorneys");
                });

            modelBuilder.Entity("MemigrationProBonoTracker.Models.AttorneyAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AttorneyId");

                    b.Property<string>("City");

                    b.Property<bool>("PrimaryAddress");

                    b.Property<int?>("State");

                    b.Property<string>("StreetAddress1");

                    b.Property<string>("StreetAddress2");

                    b.Property<string>("ZipCode");

                    b.HasKey("Id");

                    b.HasIndex("AttorneyId");

                    b.ToTable("AttorneyAddresses");
                });

            modelBuilder.Entity("MemigrationProBonoTracker.Models.AttorneyPhoneNumber", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AttorneyId");

                    b.Property<string>("Number");

                    b.Property<bool>("PrimaryContactNumber");

                    b.HasKey("Id");

                    b.HasIndex("AttorneyId");

                    b.ToTable("AttorneyPhoneNumbers");
                });

            modelBuilder.Entity("MemigrationProBonoTracker.Models.Case", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<int?>("AssigningAttorneyId");

                    b.Property<double>("AttorneyWorkedHours");

                    b.Property<int?>("AttorneyWorkerId");

                    b.Property<string>("CaseNotes");

                    b.Property<int?>("LeadClientId");

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.HasIndex("AssigningAttorneyId");

                    b.HasIndex("AttorneyWorkerId");

                    b.HasIndex("LeadClientId");

                    b.ToTable("Cases");
                });

            modelBuilder.Entity("MemigrationProBonoTracker.Models.CaseEventDate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CaseId");

                    b.Property<string>("Event");

                    b.Property<DateTime>("EventDate");

                    b.HasKey("Id");

                    b.HasIndex("CaseId");

                    b.ToTable("CaseEvents");
                });

            modelBuilder.Entity("MemigrationProBonoTracker.Models.ContactLogEntry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CaseId");

                    b.Property<DateTime>("EntryDate");

                    b.Property<string>("EntryNotes");

                    b.HasKey("Id");

                    b.HasIndex("CaseId");

                    b.ToTable("LogEntries");
                });

            modelBuilder.Entity("MemigrationProBonoTracker.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age");

                    b.Property<string>("FirstName");

                    b.Property<int>("Gender");

                    b.Property<string>("LastName");

                    b.Property<int>("Nationality");

                    b.Property<string>("Notes");

                    b.HasKey("Id");

                    b.ToTable("People");
                });

            modelBuilder.Entity("MemigrationProBonoTracker.Models.PersonAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City");

                    b.Property<int?>("PersonId");

                    b.Property<bool>("PrimaryAddress");

                    b.Property<int?>("State");

                    b.Property<string>("StreetAddress1");

                    b.Property<string>("StreetAddress2");

                    b.Property<string>("ZipCode");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("PersonAddresses");
                });

            modelBuilder.Entity("MemigrationProBonoTracker.Models.PersonPhoneNumber", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Number");

                    b.Property<int?>("PersonId");

                    b.Property<bool>("PrimaryContactNumber");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("PersonPhoneNumbers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("MemigrationProBonoTracker.Models.AssociatedPerson", b =>
                {
                    b.HasOne("MemigrationProBonoTracker.Models.Case")
                        .WithMany("AssociatedPeopleList")
                        .HasForeignKey("CaseId");

                    b.HasOne("MemigrationProBonoTracker.Models.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId");
                });

            modelBuilder.Entity("MemigrationProBonoTracker.Models.AttorneyAddress", b =>
                {
                    b.HasOne("MemigrationProBonoTracker.Models.Attorney")
                        .WithMany("AddressList")
                        .HasForeignKey("AttorneyId");
                });

            modelBuilder.Entity("MemigrationProBonoTracker.Models.AttorneyPhoneNumber", b =>
                {
                    b.HasOne("MemigrationProBonoTracker.Models.Attorney")
                        .WithMany("PhoneList")
                        .HasForeignKey("AttorneyId");
                });

            modelBuilder.Entity("MemigrationProBonoTracker.Models.Case", b =>
                {
                    b.HasOne("MemigrationProBonoTracker.Models.Attorney", "AssigningAttorney")
                        .WithMany()
                        .HasForeignKey("AssigningAttorneyId");

                    b.HasOne("MemigrationProBonoTracker.Models.Attorney", "AttorneyWorker")
                        .WithMany()
                        .HasForeignKey("AttorneyWorkerId");

                    b.HasOne("MemigrationProBonoTracker.Models.Person", "LeadClient")
                        .WithMany()
                        .HasForeignKey("LeadClientId");
                });

            modelBuilder.Entity("MemigrationProBonoTracker.Models.CaseEventDate", b =>
                {
                    b.HasOne("MemigrationProBonoTracker.Models.Case")
                        .WithMany("MajorDates")
                        .HasForeignKey("CaseId");
                });

            modelBuilder.Entity("MemigrationProBonoTracker.Models.ContactLogEntry", b =>
                {
                    b.HasOne("MemigrationProBonoTracker.Models.Case")
                        .WithMany("ContactLogEntries")
                        .HasForeignKey("CaseId");
                });

            modelBuilder.Entity("MemigrationProBonoTracker.Models.PersonAddress", b =>
                {
                    b.HasOne("MemigrationProBonoTracker.Models.Person")
                        .WithMany("AddressList")
                        .HasForeignKey("PersonId");
                });

            modelBuilder.Entity("MemigrationProBonoTracker.Models.PersonPhoneNumber", b =>
                {
                    b.HasOne("MemigrationProBonoTracker.Models.Person")
                        .WithMany("PhoneList")
                        .HasForeignKey("PersonId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Claims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("MemigrationProBonoTracker.Models.ApplicationUser")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("MemigrationProBonoTracker.Models.ApplicationUser")
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MemigrationProBonoTracker.Models.ApplicationUser")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
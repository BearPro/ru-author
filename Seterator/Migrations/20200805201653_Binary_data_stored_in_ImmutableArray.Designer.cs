﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Seterator;

namespace Seterator.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20200805201653_Binary_data_stored_in_ImmutableArray")]
    partial class Binary_data_stored_in_ImmutableArray
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Seterator.Models.Competition", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("CreatorUserGuid")
                        .HasColumnType("char(36)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Extra")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ShortDescription")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Guid");

                    b.HasIndex("CreatorUserGuid");

                    b.ToTable("Competitions");
                });

            modelBuilder.Entity("Seterator.Models.CompetitionCategory", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Guid");

                    b.ToTable("CompetitionCategories");
                });

            modelBuilder.Entity("Seterator.Models.CompetitionConstraint", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("CheckedValue")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<Guid>("CompetitionGuid")
                        .HasColumnType("char(36)");

                    b.Property<int>("Max")
                        .HasColumnType("int");

                    b.Property<int>("Min")
                        .HasColumnType("int");

                    b.HasKey("Guid");

                    b.HasIndex("CompetitionGuid");

                    b.ToTable("CompetitionConstraints");
                });

            modelBuilder.Entity("Seterator.Models.CompetitionRelCategory", b =>
                {
                    b.Property<Guid>("CategoryGuid")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("CompetitionGuid")
                        .HasColumnType("char(36)");

                    b.HasKey("CategoryGuid", "CompetitionGuid");

                    b.HasIndex("CompetitionGuid");

                    b.ToTable("CompetitionRelCategories");
                });

            modelBuilder.Entity("Seterator.Models.CompetitionRelJury", b =>
                {
                    b.Property<Guid>("CompetitionGuid")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("JuryUserGuid")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("JuryGuid")
                        .HasColumnType("char(36)");

                    b.HasKey("CompetitionGuid", "JuryUserGuid");

                    b.HasIndex("JuryGuid");

                    b.ToTable("CompetitionRelJuries");
                });

            modelBuilder.Entity("Seterator.Models.Participant", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("CompetitionGuid")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nickname")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<Guid>("UserGuid")
                        .HasColumnType("char(36)");

                    b.HasKey("Guid");

                    b.HasIndex("CompetitionGuid");

                    b.HasIndex("UserGuid");

                    b.ToTable("Participants");
                });

            modelBuilder.Entity("Seterator.Models.ParticipantAssessment", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<int?>("Assessment")
                        .HasColumnType("int");

                    b.Property<Guid>("JuryGuid")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("ParticipantGuid")
                        .HasColumnType("char(36)");

                    b.HasKey("Guid");

                    b.HasIndex("ParticipantGuid");

                    b.ToTable("ParticipantAssessments");
                });

            modelBuilder.Entity("Seterator.Models.Poem", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("ParticipantGuid")
                        .HasColumnType("char(36)");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Guid");

                    b.HasIndex("ParticipantGuid");

                    b.ToTable("Poems");
                });

            modelBuilder.Entity("Seterator.Models.Prize", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<int>("BeginPlace")
                        .HasColumnType("int");

                    b.Property<Guid>("CompetitionGuid")
                        .HasColumnType("char(36)");

                    b.Property<int>("EndPlace")
                        .HasColumnType("int");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Guid");

                    b.HasIndex("CompetitionGuid");

                    b.ToTable("Prizes");
                });

            modelBuilder.Entity("Seterator.Models.Role", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("UserGuid")
                        .HasColumnType("char(36)");

                    b.Property<int>("UserRole")
                        .HasColumnType("int");

                    b.HasKey("Guid");

                    b.HasIndex("UserGuid");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Seterator.Models.User", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("FbProfile")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("INN")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("InstProfile")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("varchar(128)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("longblob");

                    b.Property<string>("PrivateEmail")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("PrivatePhone")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ProfilePicture")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("PublicEmail")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("PublicPhone")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("RegisterAddress")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("SNILS")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("SecondName")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("UserUrlsJson")
                        .IsRequired()
                        .HasColumnName("UserUrls")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("Verified")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("VkProfile")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Guid");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Seterator.Models.UserDocument", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("bigint");

                    b.Property<byte[]>("Data")
                        .IsRequired()
                        .HasColumnName("data")
                        .HasColumnType("longblob");

                    b.Property<Guid>("OwnerGuid")
                        .HasColumnName("OwnerGuid")
                        .HasColumnType("char(36)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnName("type")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.HasIndex("OwnerGuid");

                    b.ToTable("Documents");
                });

            modelBuilder.Entity("Seterator.Models.UserProfile", b =>
                {
                    b.Property<Guid>("RoleGuid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ShortLink")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("RoleGuid");

                    b.ToTable("Profiles");
                });

            modelBuilder.Entity("Seterator.Models.Competition", b =>
                {
                    b.HasOne("Seterator.Models.User", "Creator")
                        .WithMany()
                        .HasForeignKey("CreatorUserGuid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Seterator.Models.CompetitionConstraint", b =>
                {
                    b.HasOne("Seterator.Models.Competition", null)
                        .WithMany("Constraints")
                        .HasForeignKey("CompetitionGuid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Seterator.Models.CompetitionRelCategory", b =>
                {
                    b.HasOne("Seterator.Models.CompetitionCategory", "Category")
                        .WithMany("Competitions")
                        .HasForeignKey("CategoryGuid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Seterator.Models.Competition", "Competition")
                        .WithMany("Categories")
                        .HasForeignKey("CompetitionGuid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Seterator.Models.CompetitionRelJury", b =>
                {
                    b.HasOne("Seterator.Models.Competition", "Competition")
                        .WithMany("Jury")
                        .HasForeignKey("CompetitionGuid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Seterator.Models.User", "Jury")
                        .WithMany()
                        .HasForeignKey("JuryGuid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Seterator.Models.Participant", b =>
                {
                    b.HasOne("Seterator.Models.Competition", "Competition")
                        .WithMany("Participants")
                        .HasForeignKey("CompetitionGuid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Seterator.Models.User", "User")
                        .WithMany("Participants")
                        .HasForeignKey("UserGuid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Seterator.Models.ParticipantAssessment", b =>
                {
                    b.HasOne("Seterator.Models.Participant", "Participant")
                        .WithMany()
                        .HasForeignKey("ParticipantGuid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Seterator.Models.Poem", b =>
                {
                    b.HasOne("Seterator.Models.Participant", "Author")
                        .WithMany("Poems")
                        .HasForeignKey("ParticipantGuid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Seterator.Models.Prize", b =>
                {
                    b.HasOne("Seterator.Models.Competition", null)
                        .WithMany("Prizes")
                        .HasForeignKey("CompetitionGuid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Seterator.Models.Role", b =>
                {
                    b.HasOne("Seterator.Models.User", "User")
                        .WithMany("Roles")
                        .HasForeignKey("UserGuid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Seterator.Models.UserDocument", b =>
                {
                    b.HasOne("Seterator.Models.User", "Owner")
                        .WithMany("Documents")
                        .HasForeignKey("OwnerGuid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

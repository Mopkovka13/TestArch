﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestArchitecture.DA;

#nullable disable

namespace TestArchitecture.DA.Migrations
{
    [DbContext(typeof(TestArchitectureDbContext))]
    [Migration("20220730093756_AddTables")]
    partial class AddTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("HomeworkMember", b =>
                {
                    b.Property<int>("HomeworksId")
                        .HasColumnType("int");

                    b.Property<int>("MembersId")
                        .HasColumnType("int");

                    b.HasKey("HomeworksId", "MembersId");

                    b.HasIndex("MembersId");

                    b.ToTable("HomeworkMember");
                });

            modelBuilder.Entity("TestArchitecture.DA.Entities.GithubAccount", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int>("MemberId")
                        .HasColumnType("int");

                    b.Property<string>("Nickname")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("GitHubAccounts");
                });

            modelBuilder.Entity("TestArchitecture.DA.Entities.Homework", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<int>("LessonId")
                        .HasColumnType("int");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.ToTable("Homeworks");
                });

            modelBuilder.Entity("TestArchitecture.DA.Entities.Lesson", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<int>("HomeworkId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("Id");

                    b.HasIndex("HomeworkId")
                        .IsUnique();

                    b.ToTable("Lessons");
                });

            modelBuilder.Entity("TestArchitecture.DA.Entities.Member", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<Guid?>("GithubAccountId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("GithubAccountMemberId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("GithubAccountMemberId")
                        .IsUnique();

                    b.ToTable("Members");
                });

            modelBuilder.Entity("HomeworkMember", b =>
                {
                    b.HasOne("TestArchitecture.DA.Entities.Homework", null)
                        .WithMany()
                        .HasForeignKey("HomeworksId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TestArchitecture.DA.Entities.Member", null)
                        .WithMany()
                        .HasForeignKey("MembersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TestArchitecture.DA.Entities.Lesson", b =>
                {
                    b.HasOne("TestArchitecture.DA.Entities.Homework", "Homework")
                        .WithOne("Lesson")
                        .HasForeignKey("TestArchitecture.DA.Entities.Lesson", "HomeworkId")
                        .HasPrincipalKey("TestArchitecture.DA.Entities.Homework", "LessonId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Homework");
                });

            modelBuilder.Entity("TestArchitecture.DA.Entities.Member", b =>
                {
                    b.HasOne("TestArchitecture.DA.Entities.GithubAccount", "GithubAccount")
                        .WithOne("Member")
                        .HasForeignKey("TestArchitecture.DA.Entities.Member", "GithubAccountMemberId")
                        .HasPrincipalKey("TestArchitecture.DA.Entities.GithubAccount", "MemberId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("GithubAccount");
                });

            modelBuilder.Entity("TestArchitecture.DA.Entities.GithubAccount", b =>
                {
                    b.Navigation("Member")
                        .IsRequired();
                });

            modelBuilder.Entity("TestArchitecture.DA.Entities.Homework", b =>
                {
                    b.Navigation("Lesson")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

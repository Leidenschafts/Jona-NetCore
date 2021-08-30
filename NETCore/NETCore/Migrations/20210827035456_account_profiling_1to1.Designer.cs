﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NETCore.Context;

namespace NETCore.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20210827035456_account_profiling_1to1")]
    partial class account_profiling_1to1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NETCore.Models.Account", b =>
                {
                    b.Property<string>("NIK")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NIK");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("NETCore.Models.Person", b =>
                {
                    b.Property<string>("NIK")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Salary")
                        .HasColumnType("int");

                    b.Property<int>("gender")
                        .HasColumnType("int");

                    b.HasKey("NIK");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("NETCore.Models.Profiling", b =>
                {
                    b.Property<string>("NIK")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Education_Id")
                        .HasColumnType("int");

                    b.HasKey("NIK");

                    b.ToTable("Profiling");
                });

            modelBuilder.Entity("NETCore.Models.Account", b =>
                {
                    b.HasOne("NETCore.Models.Person", "Person")
                        .WithOne("Account")
                        .HasForeignKey("NETCore.Models.Account", "NIK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("NETCore.Models.Profiling", b =>
                {
                    b.HasOne("NETCore.Models.Account", "Account")
                        .WithOne("Profiling")
                        .HasForeignKey("NETCore.Models.Profiling", "NIK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("NETCore.Models.Account", b =>
                {
                    b.Navigation("Profiling");
                });

            modelBuilder.Entity("NETCore.Models.Person", b =>
                {
                    b.Navigation("Account");
                });
#pragma warning restore 612, 618
        }
    }
}

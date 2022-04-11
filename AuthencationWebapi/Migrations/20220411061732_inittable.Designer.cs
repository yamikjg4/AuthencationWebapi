﻿// <auto-generated />
using AuthencationWebapi.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AuthencationWebapi.Migrations
{
    [DbContext(typeof(UserContext))]
    [Migration("20220411061732_inittable")]
    partial class inittable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AuthencationWebapi.Model.tbluser", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("Nvarchar(255)");

                    b.Property<string>("fname")
                        .IsRequired()
                        .HasColumnType("Nvarchar(50)");

                    b.Property<string>("lname")
                        .IsRequired()
                        .HasColumnType("Nvarchar(50)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("Nvarchar(15)");

                    b.HasKey("id");

                    b.ToTable("Tblusers");
                });
#pragma warning restore 612, 618
        }
    }
}

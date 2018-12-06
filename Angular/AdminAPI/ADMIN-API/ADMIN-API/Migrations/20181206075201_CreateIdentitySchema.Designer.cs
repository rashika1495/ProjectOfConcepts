﻿// <auto-generated />
using System;
using ADMINAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ADMINAPI.Migrations
{
    [DbContext(typeof(ContactDbContext))]
    [Migration("20181206075201_CreateIdentitySchema")]
    partial class CreateIdentitySchema
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.2-rtm-30932")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ADMINAPI.Models.Contact", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("Birth")
                        .HasColumnName("birth");

                    b.Property<string>("Email")
                        .HasColumnName("email");

                    b.Property<byte>("Gender")
                        .HasColumnName("gender");

                    b.Property<string>("Message")
                        .HasColumnName("message");

                    b.Property<string>("Name")
                        .HasColumnName("name");

                    b.Property<string>("Techno")
                        .HasColumnName("techno");

                    b.HasKey("Id");

                    b.ToTable("Contact");
                });
#pragma warning restore 612, 618
        }
    }
}
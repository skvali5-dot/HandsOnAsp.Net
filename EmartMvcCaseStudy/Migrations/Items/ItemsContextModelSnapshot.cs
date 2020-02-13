﻿// <auto-generated />
using System;
using EmartMvcCaseStudy.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EmartMvcCaseStudy.Migrations.Items
{
    [DbContext(typeof(ItemsContext))]
    partial class ItemsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EmartMvcCaseStudy.Models.Items", b =>
                {
                    b.Property<int>("IID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ABOUTITEM")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CID")
                        .HasColumnType("int");

                    b.Property<string>("INAME")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("IPRICE")
                        .HasColumnType("float");

                    b.Property<int>("SCID")
                        .HasColumnType("int");

                    b.Property<int>("STOCK")
                        .HasColumnType("int");

                    b.Property<byte[]>("image")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("remarks")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IID");

                    b.ToTable("items");
                });
#pragma warning restore 612, 618
        }
    }
}

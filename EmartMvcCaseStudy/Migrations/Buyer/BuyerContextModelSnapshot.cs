﻿// <auto-generated />
using System;
using EmartMvcCaseStudy.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EmartMvcCaseStudy.Migrations.Buyer
{
    [DbContext(typeof(BuyerContext))]
    partial class BuyerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EmartMvcCaseStudy.Models.Buyer", b =>
                {
                    b.Property<int>("BID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BEMAILID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BLDT")
                        .HasColumnType("datetime2");

                    b.Property<double>("BMOBILENO")
                        .HasColumnType("float");

                    b.Property<string>("BPASSWORD")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BUSERNAME")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BID");

                    b.ToTable("Buyers");
                });
#pragma warning restore 612, 618
        }
    }
}

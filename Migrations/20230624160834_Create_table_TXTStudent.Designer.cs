﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace truongblu001.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230624160834_Create_table_TXTStudent")]
    partial class Create_table_TXTStudent
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.8");

            modelBuilder.Entity("truongblu001.Models.TXTCompany", b =>
                {
                    b.Property<string>("CompanyID")
                        .HasColumnType("TEXT");

                    b.Property<string>("AddressID")
                        .HasColumnType("TEXT");

                    b.Property<string>("CompanyName")
                        .HasColumnType("TEXT");

                    b.HasKey("CompanyID");

                    b.ToTable("TXTCompany");
                });

            modelBuilder.Entity("truongblu001.Models.TXTStudent", b =>
                {
                    b.Property<string>("TXTID")
                        .HasColumnType("TEXT");

                    b.Property<string>("TXTNAME")
                        .HasColumnType("TEXT");

                    b.Property<string>("TXTSEX")
                        .HasColumnType("TEXT");

                    b.HasKey("TXTID");

                    b.ToTable("TXTStudent");
                });
#pragma warning restore 612, 618
        }
    }
}

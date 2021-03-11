﻿// <auto-generated />
using System;
using BasicFilmDbProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BasicFilmDbProject.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210311213957_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("BasicFilmDbProject.Models.Film", b =>
                {
                    b.Property<int>("FilmID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("FilmCertificate")
                        .IsRequired()
                        .HasColumnType("varchar(5)");

                    b.Property<string>("FilmDescription")
                        .HasColumnType("text");

                    b.Property<string>("FilmImage")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("FilmPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("FilmTitle")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Stars")
                        .HasColumnType("int");

                    b.HasKey("FilmID");

                    b.ToTable("Films");
                });
#pragma warning restore 612, 618
        }
    }
}

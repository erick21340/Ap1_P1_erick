﻿// <auto-generated />
using System;
using Ap1_P1_erick.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Ap1_P1_erick.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20240603232217_inicial")]
    partial class inicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.5");

            modelBuilder.Entity("Ap1_P1_erick.Models.Articulos", b =>
                {
                    b.Property<int>("ArticulosId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal?>("Costo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal?>("ganacia")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal?>("precio")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ArticulosId");

                    b.ToTable("Articulos");
                });
#pragma warning restore 612, 618
        }
    }
}

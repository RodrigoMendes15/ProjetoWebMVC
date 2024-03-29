﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoWebMVC.Models;

namespace ProjetoWebMVC.Migrations
{
    [DbContext(typeof(ProjetoWebMVCContext))]
    partial class ProjetoWebMVCContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ProjetoWebMVC.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("ProjetoWebMVC.Models.SalesRecord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Data");

                    b.Property<int>("Status");

                    b.Property<double>("Valor");

                    b.Property<int?>("VendasId");

                    b.HasKey("Id");

                    b.HasIndex("VendasId");

                    b.ToTable("SalesRecord");
                });

            modelBuilder.Entity("ProjetoWebMVC.Models.Seller", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataNascimento");

                    b.Property<int>("DepartmentId");

                    b.Property<string>("Email");

                    b.Property<string>("Nome");

                    b.Property<double>("SalarioBase");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Seller");
                });

            modelBuilder.Entity("ProjetoWebMVC.Models.SalesRecord", b =>
                {
                    b.HasOne("ProjetoWebMVC.Models.Seller", "Vendas")
                        .WithMany("Vendas")
                        .HasForeignKey("VendasId");
                });

            modelBuilder.Entity("ProjetoWebMVC.Models.Seller", b =>
                {
                    b.HasOne("ProjetoWebMVC.Models.Department", "Departamento")
                        .WithMany("Vendedor")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

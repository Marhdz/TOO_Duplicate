﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using tiendaOnline.Data;

namespace tiendaOnline.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20191108080527_probandouser")]
    partial class probandouser
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("tiendaOnline.Areas.Identity.Data.tiendaOnlineUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<int>("CarritoID");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("Nombres");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.Property<string>("apellidos");

                    b.HasKey("Id");

                    b.HasIndex("CarritoID");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("tiendaOnline.Models.Carrito", b =>
                {
                    b.Property<int>("CarritoID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("CarritoID");

                    b.ToTable("Carrito");
                });

            modelBuilder.Entity("tiendaOnline.Models.Categoria", b =>
                {
                    b.Property<int>("CategoriaID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("nombre_categoria")
                        .IsRequired();

                    b.HasKey("CategoriaID");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("tiendaOnline.Models.Departamento", b =>
                {
                    b.Property<int>("DepartamentoID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("nombreDepartamento")
                        .IsRequired();

                    b.HasKey("DepartamentoID");

                    b.ToTable("Departamento");
                });

            modelBuilder.Entity("tiendaOnline.Models.DetalleProducto", b =>
                {
                    b.Property<int>("DetalleProductoID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Color");

                    b.Property<string>("Descripcion");

                    b.Property<string>("Modelo");

                    b.Property<string>("PesoKg");

                    b.Property<string>("Talla");

                    b.HasKey("DetalleProductoID");

                    b.ToTable("DetalleProducto");
                });

            modelBuilder.Entity("tiendaOnline.Models.Direccion", b =>
                {
                    b.Property<int>("DireccionID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MunicipioID");

                    b.Property<string>("direccion")
                        .IsRequired();

                    b.Property<string>("tiendaOnlineUserID");

                    b.HasKey("DireccionID");

                    b.HasIndex("MunicipioID");

                    b.HasIndex("tiendaOnlineUserID");

                    b.ToTable("Direccion");
                });

            modelBuilder.Entity("tiendaOnline.Models.Municipio", b =>
                {
                    b.Property<int>("MunicipioID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DepartamentoID");

                    b.Property<string>("nombreMunicipio")
                        .IsRequired();

                    b.HasKey("MunicipioID");

                    b.HasIndex("DepartamentoID");

                    b.ToTable("Municipio");
                });

            modelBuilder.Entity("tiendaOnline.Models.Paypal", b =>
                {
                    b.Property<int>("PaypalID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("correoPaypal");

                    b.Property<string>("psswrdPaypal");

                    b.HasKey("PaypalID");

                    b.ToTable("Paypal");
                });

            modelBuilder.Entity("tiendaOnline.Models.Producto", b =>
                {
                    b.Property<int>("ProductoID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Codigo");

                    b.Property<int>("DetalleProductoID");

                    b.Property<int>("Existencia");

                    b.Property<string>("Imagen");

                    b.Property<string>("NombreProducto");

                    b.Property<double>("Precio");

                    b.Property<int>("SubcategoriaID");

                    b.HasKey("ProductoID");

                    b.HasIndex("DetalleProductoID");

                    b.HasIndex("SubcategoriaID");

                    b.ToTable("Producto");
                });

            modelBuilder.Entity("tiendaOnline.Models.Subcategoria", b =>
                {
                    b.Property<int>("SubcategoriaID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoriaID");

                    b.Property<string>("nombreSubcategoria");

                    b.HasKey("SubcategoriaID");

                    b.HasIndex("CategoriaID");

                    b.ToTable("Subcategoria");
                });

            modelBuilder.Entity("tiendaOnline.Models.Tarjeta", b =>
                {
                    b.Property<int>("TarjetaID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("codigoTarjeta");

                    b.Property<DateTime>("fechaVencimiento");

                    b.Property<string>("tipoTarjeta");

                    b.HasKey("TarjetaID");

                    b.ToTable("Tarjeta");
                });

            modelBuilder.Entity("tiendaOnline.Models.TipoDePago", b =>
                {
                    b.Property<int>("TipoDePagoID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PaypalID");

                    b.Property<int>("TarjetaID");

                    b.Property<string>("tiendaOnlineUserID");

                    b.HasKey("TipoDePagoID");

                    b.HasIndex("PaypalID");

                    b.HasIndex("TarjetaID");

                    b.HasIndex("tiendaOnlineUserID");

                    b.ToTable("TipoDePago");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("tiendaOnline.Areas.Identity.Data.tiendaOnlineUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("tiendaOnline.Areas.Identity.Data.tiendaOnlineUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("tiendaOnline.Areas.Identity.Data.tiendaOnlineUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("tiendaOnline.Areas.Identity.Data.tiendaOnlineUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("tiendaOnline.Areas.Identity.Data.tiendaOnlineUser", b =>
                {
                    b.HasOne("tiendaOnline.Models.Carrito", "Carrito")
                        .WithMany()
                        .HasForeignKey("CarritoID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("tiendaOnline.Models.Direccion", b =>
                {
                    b.HasOne("tiendaOnline.Models.Municipio", "Municipio")
                        .WithMany()
                        .HasForeignKey("MunicipioID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("tiendaOnline.Areas.Identity.Data.tiendaOnlineUser", "tiendaOnlineUser")
                        .WithMany()
                        .HasForeignKey("tiendaOnlineUserID");
                });

            modelBuilder.Entity("tiendaOnline.Models.Municipio", b =>
                {
                    b.HasOne("tiendaOnline.Models.Departamento", "Departamento")
                        .WithMany()
                        .HasForeignKey("DepartamentoID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("tiendaOnline.Models.Producto", b =>
                {
                    b.HasOne("tiendaOnline.Models.DetalleProducto", "DetalleProducto")
                        .WithMany()
                        .HasForeignKey("DetalleProductoID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("tiendaOnline.Models.Subcategoria", "Subcategoria")
                        .WithMany()
                        .HasForeignKey("SubcategoriaID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("tiendaOnline.Models.Subcategoria", b =>
                {
                    b.HasOne("tiendaOnline.Models.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("tiendaOnline.Models.TipoDePago", b =>
                {
                    b.HasOne("tiendaOnline.Models.Paypal", "Paypal")
                        .WithMany()
                        .HasForeignKey("PaypalID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("tiendaOnline.Models.Tarjeta", "Tarjeta")
                        .WithMany()
                        .HasForeignKey("TarjetaID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("tiendaOnline.Areas.Identity.Data.tiendaOnlineUser", "tiendaOnlineUser")
                        .WithMany()
                        .HasForeignKey("tiendaOnlineUserID");
                });
#pragma warning restore 612, 618
        }
    }
}

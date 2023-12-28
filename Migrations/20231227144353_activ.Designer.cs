﻿// <auto-generated />
using System;
using DouVoitOn.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DouVoitOn.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231227144353_activ")]
    partial class activ
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("DouVoitOn.Models.Contribution", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Commentaire")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("LieuId")
                        .HasColumnType("int");

                    b.Property<int?>("PanneauId")
                        .HasColumnType("int");

                    b.Property<int?>("RouteId")
                        .HasColumnType("int");

                    b.Property<int>("TypeActionId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LieuId");

                    b.HasIndex("PanneauId");

                    b.HasIndex("RouteId");

                    b.HasIndex("TypeActionId");

                    b.HasIndex("UserId");

                    b.ToTable("Contributions");
                });

            modelBuilder.Entity("DouVoitOn.Models.Lieu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Activated")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Adresse")
                        .HasColumnType("longtext");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Latitude")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Longitude")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Pays")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Ville")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Lieux");
                });

            modelBuilder.Entity("DouVoitOn.Models.LieuPanneau", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<float>("Distance")
                        .HasColumnType("float");

                    b.Property<int>("LieuId")
                        .HasColumnType("int");

                    b.Property<string>("NomRoute")
                        .HasColumnType("longtext");

                    b.Property<int>("PanneauId")
                        .HasColumnType("int");

                    b.Property<int>("TypeDirection")
                        .HasColumnType("int");

                    b.Property<int>("typePanneauId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LieuId");

                    b.HasIndex("PanneauId");

                    b.HasIndex("typePanneauId");

                    b.ToTable("LieuPanneau");
                });

            modelBuilder.Entity("DouVoitOn.Models.Panneau", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Activated")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Adresse")
                        .HasColumnType("longtext");

                    b.Property<int>("Cap")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Latitude")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Longitude")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Pays")
                        .HasColumnType("longtext");

                    b.Property<string>("Ville")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Panneaux");
                });

            modelBuilder.Entity("DouVoitOn.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("DouVoitOn.Models.Route", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("lieuId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("lieuId");

                    b.ToTable("Routes");
                });

            modelBuilder.Entity("DouVoitOn.Models.RoutePanneau", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Ordre")
                        .HasColumnType("int");

                    b.Property<int>("PanneauId")
                        .HasColumnType("int");

                    b.Property<int>("RouteId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PanneauId");

                    b.HasIndex("RouteId");

                    b.ToTable("RoutePanneau");
                });

            modelBuilder.Entity("DouVoitOn.Models.TypeAction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("TypesAction");
                });

            modelBuilder.Entity("DouVoitOn.Models.TypePanneau", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("TypesPanneau");
                });

            modelBuilder.Entity("DouVoitOn.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Date_Inscription")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DouVoitOn.Models.Contribution", b =>
                {
                    b.HasOne("DouVoitOn.Models.Lieu", "Lieu")
                        .WithMany()
                        .HasForeignKey("LieuId");

                    b.HasOne("DouVoitOn.Models.Panneau", "Panneau")
                        .WithMany()
                        .HasForeignKey("PanneauId");

                    b.HasOne("DouVoitOn.Models.Route", "Route")
                        .WithMany()
                        .HasForeignKey("RouteId");

                    b.HasOne("DouVoitOn.Models.TypeAction", "TypeAction")
                        .WithMany()
                        .HasForeignKey("TypeActionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DouVoitOn.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lieu");

                    b.Navigation("Panneau");

                    b.Navigation("Route");

                    b.Navigation("TypeAction");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DouVoitOn.Models.LieuPanneau", b =>
                {
                    b.HasOne("DouVoitOn.Models.Lieu", "Lieu")
                        .WithMany()
                        .HasForeignKey("LieuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DouVoitOn.Models.Panneau", "Panneau")
                        .WithMany()
                        .HasForeignKey("PanneauId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DouVoitOn.Models.TypePanneau", "typePanneau")
                        .WithMany()
                        .HasForeignKey("typePanneauId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lieu");

                    b.Navigation("Panneau");

                    b.Navigation("typePanneau");
                });

            modelBuilder.Entity("DouVoitOn.Models.Route", b =>
                {
                    b.HasOne("DouVoitOn.Models.Lieu", "lieu")
                        .WithMany()
                        .HasForeignKey("lieuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("lieu");
                });

            modelBuilder.Entity("DouVoitOn.Models.RoutePanneau", b =>
                {
                    b.HasOne("DouVoitOn.Models.Panneau", "Panneau")
                        .WithMany()
                        .HasForeignKey("PanneauId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DouVoitOn.Models.Route", "Route")
                        .WithMany()
                        .HasForeignKey("RouteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Panneau");

                    b.Navigation("Route");
                });

            modelBuilder.Entity("DouVoitOn.Models.User", b =>
                {
                    b.HasOne("DouVoitOn.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });
#pragma warning restore 612, 618
        }
    }
}
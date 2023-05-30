﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RuTravel.Persistence;

#nullable disable

namespace RuTravel.WebApi.Migrations
{
    [DbContext(typeof(RuTravelDBContext))]
    [Migration("20230530152125_alpha")]
    partial class alpha
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RuTravel.Domain.Cafes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("ClosingTime")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("OpenTime")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("TownsRefID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TownsRefID");

                    b.ToTable("Cafes");
                });

            modelBuilder.Entity("RuTravel.Domain.Comments", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CafesRefId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("FlatsRefId")
                        .HasColumnType("int");

                    b.Property<int>("SightsRefId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("UsersRefId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CafesRefId");

                    b.HasIndex("FlatsRefId");

                    b.HasIndex("SightsRefId");

                    b.HasIndex("UsersRefId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("RuTravel.Domain.Flats", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("CountOfRooms")
                        .HasColumnType("int");

                    b.Property<int>("Floor")
                        .HasColumnType("int");

                    b.Property<string>("OwnersPhone")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<double>("PricePerMonth")
                        .HasColumnType("float");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.Property<int>("TownsRefID")
                        .HasColumnType("int");

                    b.Property<int?>("UsersId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TownsRefID");

                    b.HasIndex("UsersId");

                    b.ToTable("Flats");
                });

            modelBuilder.Entity("RuTravel.Domain.Photos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CafesRefId")
                        .HasColumnType("int");

                    b.Property<int>("FlatsRefId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Photo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PostsRefId")
                        .HasColumnType("int");

                    b.Property<int>("SightsRefId")
                        .HasColumnType("int");

                    b.Property<int>("TownsRefId")
                        .HasColumnType("int");

                    b.Property<int>("UsersRefId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CafesRefId");

                    b.HasIndex("FlatsRefId");

                    b.HasIndex("PostsRefId");

                    b.HasIndex("SightsRefId");

                    b.HasIndex("TownsRefId");

                    b.HasIndex("UsersRefId");

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("RuTravel.Domain.Posts", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("UsersId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsersId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("RuTravel.Domain.Sights", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("TownsRefID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TownsRefID");

                    b.ToTable("Sights");
                });

            modelBuilder.Entity("RuTravel.Domain.Towns", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Towns");
                });

            modelBuilder.Entity("RuTravel.Domain.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CountOfTravels")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("TownsRefID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TownsRefID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("RuTravel.Domain.Cafes", b =>
                {
                    b.HasOne("RuTravel.Domain.Towns", "Towns")
                        .WithMany("Cafes")
                        .HasForeignKey("TownsRefID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Towns");
                });

            modelBuilder.Entity("RuTravel.Domain.Comments", b =>
                {
                    b.HasOne("RuTravel.Domain.Cafes", "Cafes")
                        .WithMany("Comments")
                        .HasForeignKey("CafesRefId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RuTravel.Domain.Flats", "Flats")
                        .WithMany("Comments")
                        .HasForeignKey("FlatsRefId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RuTravel.Domain.Sights", "Sights")
                        .WithMany("Comments")
                        .HasForeignKey("SightsRefId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RuTravel.Domain.Users", "Users")
                        .WithMany("Comments")
                        .HasForeignKey("UsersRefId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cafes");

                    b.Navigation("Flats");

                    b.Navigation("Sights");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("RuTravel.Domain.Flats", b =>
                {
                    b.HasOne("RuTravel.Domain.Towns", "Towns")
                        .WithMany("Flats")
                        .HasForeignKey("TownsRefID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RuTravel.Domain.Users", null)
                        .WithMany("Flats")
                        .HasForeignKey("UsersId");

                    b.Navigation("Towns");
                });

            modelBuilder.Entity("RuTravel.Domain.Photos", b =>
                {
                    b.HasOne("RuTravel.Domain.Cafes", "Cafes")
                        .WithMany("Photos")
                        .HasForeignKey("CafesRefId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RuTravel.Domain.Flats", "Flats")
                        .WithMany("Photos")
                        .HasForeignKey("FlatsRefId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RuTravel.Domain.Posts", "Posts")
                        .WithMany("Photos")
                        .HasForeignKey("PostsRefId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RuTravel.Domain.Sights", "Sights")
                        .WithMany("Photos")
                        .HasForeignKey("SightsRefId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RuTravel.Domain.Towns", "Towns")
                        .WithMany("Photos")
                        .HasForeignKey("TownsRefId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RuTravel.Domain.Users", "Users")
                        .WithMany("Photos")
                        .HasForeignKey("UsersRefId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cafes");

                    b.Navigation("Flats");

                    b.Navigation("Posts");

                    b.Navigation("Sights");

                    b.Navigation("Towns");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("RuTravel.Domain.Posts", b =>
                {
                    b.HasOne("RuTravel.Domain.Users", "Users")
                        .WithMany("Posts")
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Users");
                });

            modelBuilder.Entity("RuTravel.Domain.Sights", b =>
                {
                    b.HasOne("RuTravel.Domain.Towns", "Towns")
                        .WithMany("Sights")
                        .HasForeignKey("TownsRefID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Towns");
                });

            modelBuilder.Entity("RuTravel.Domain.Users", b =>
                {
                    b.HasOne("RuTravel.Domain.Towns", "Towns")
                        .WithMany("Users")
                        .HasForeignKey("TownsRefID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Towns");
                });

            modelBuilder.Entity("RuTravel.Domain.Cafes", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Photos");
                });

            modelBuilder.Entity("RuTravel.Domain.Flats", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Photos");
                });

            modelBuilder.Entity("RuTravel.Domain.Posts", b =>
                {
                    b.Navigation("Photos");
                });

            modelBuilder.Entity("RuTravel.Domain.Sights", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Photos");
                });

            modelBuilder.Entity("RuTravel.Domain.Towns", b =>
                {
                    b.Navigation("Cafes");

                    b.Navigation("Flats");

                    b.Navigation("Photos");

                    b.Navigation("Sights");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("RuTravel.Domain.Users", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Flats");

                    b.Navigation("Photos");

                    b.Navigation("Posts");
                });
#pragma warning restore 612, 618
        }
    }
}

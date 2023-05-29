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
    [Migration("20230526190041_Initial")]
    partial class Initial
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

                    b.Property<int>("CommentsRefId")
                        .HasColumnType("int");

                    b.Property<string>("OpenTime")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("PhotosRefId")
                        .HasColumnType("int");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("TownsRefID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CommentsRefId");

                    b.HasIndex("PhotosRefId");

                    b.HasIndex("TownsRefID");

                    b.ToTable("Cafes");
                });

            modelBuilder.Entity("RuTravel.Domain.Comments", b =>
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

                    b.Property<int>("UsersRefId")
                        .HasColumnType("int");

                    b.HasKey("Id");

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

                    b.Property<int>("CommentsRefId")
                        .HasColumnType("int");

                    b.Property<int>("CountOfRooms")
                        .HasColumnType("int");

                    b.Property<int>("Floor")
                        .HasColumnType("int");

                    b.Property<string>("OwnersPhone")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("PhotosRefId")
                        .HasColumnType("int");

                    b.Property<double>("PricePerMonth")
                        .HasColumnType("float");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.Property<int>("TownsRefID")
                        .HasColumnType("int");

                    b.Property<int?>("UsersId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CommentsRefId");

                    b.HasIndex("PhotosRefId");

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

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Photo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

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

                    b.Property<int>("PhotosRefId")
                        .HasColumnType("int");

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

                    b.HasIndex("PhotosRefId");

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

                    b.Property<int>("CommentsRefId")
                        .HasColumnType("int");

                    b.Property<int>("PhotosRefId")
                        .HasColumnType("int");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("TownsRefID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CommentsRefId");

                    b.HasIndex("PhotosRefId");

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

                    b.Property<int>("PhotosRefId")
                        .HasColumnType("int");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("PhotosRefId");

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

                    b.Property<int>("PhotosRefId")
                        .HasColumnType("int");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("TownsRefID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PhotosRefId");

                    b.HasIndex("TownsRefID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("RuTravel.Domain.Cafes", b =>
                {
                    b.HasOne("RuTravel.Domain.Comments", "Comments")
                        .WithMany("Cafes")
                        .HasForeignKey("CommentsRefId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RuTravel.Domain.Photos", "Photos")
                        .WithMany("Cafes")
                        .HasForeignKey("PhotosRefId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RuTravel.Domain.Towns", "Towns")
                        .WithMany("Cafes")
                        .HasForeignKey("TownsRefID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Comments");

                    b.Navigation("Photos");

                    b.Navigation("Towns");
                });

            modelBuilder.Entity("RuTravel.Domain.Comments", b =>
                {
                    b.HasOne("RuTravel.Domain.Users", "Users")
                        .WithMany("Comments")
                        .HasForeignKey("UsersRefId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Users");
                });

            modelBuilder.Entity("RuTravel.Domain.Flats", b =>
                {
                    b.HasOne("RuTravel.Domain.Comments", "Comments")
                        .WithMany("Flats")
                        .HasForeignKey("CommentsRefId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RuTravel.Domain.Photos", "Photos")
                        .WithMany("Flats")
                        .HasForeignKey("PhotosRefId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RuTravel.Domain.Towns", "Towns")
                        .WithMany("Flats")
                        .HasForeignKey("TownsRefID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RuTravel.Domain.Users", null)
                        .WithMany("Flats")
                        .HasForeignKey("UsersId");

                    b.Navigation("Comments");

                    b.Navigation("Photos");

                    b.Navigation("Towns");
                });

            modelBuilder.Entity("RuTravel.Domain.Posts", b =>
                {
                    b.HasOne("RuTravel.Domain.Photos", "Photos")
                        .WithMany("Posts")
                        .HasForeignKey("PhotosRefId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RuTravel.Domain.Users", "Users")
                        .WithMany("Posts")
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Photos");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("RuTravel.Domain.Sights", b =>
                {
                    b.HasOne("RuTravel.Domain.Comments", "Comments")
                        .WithMany("Sights")
                        .HasForeignKey("CommentsRefId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RuTravel.Domain.Photos", "Photos")
                        .WithMany("Sights")
                        .HasForeignKey("PhotosRefId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RuTravel.Domain.Towns", "Towns")
                        .WithMany("Sights")
                        .HasForeignKey("TownsRefID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Comments");

                    b.Navigation("Photos");

                    b.Navigation("Towns");
                });

            modelBuilder.Entity("RuTravel.Domain.Towns", b =>
                {
                    b.HasOne("RuTravel.Domain.Photos", "Photos")
                        .WithMany("Towns")
                        .HasForeignKey("PhotosRefId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Photos");
                });

            modelBuilder.Entity("RuTravel.Domain.Users", b =>
                {
                    b.HasOne("RuTravel.Domain.Photos", "Photos")
                        .WithMany("Users")
                        .HasForeignKey("PhotosRefId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RuTravel.Domain.Towns", "Towns")
                        .WithMany("Users")
                        .HasForeignKey("TownsRefID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Photos");

                    b.Navigation("Towns");
                });

            modelBuilder.Entity("RuTravel.Domain.Comments", b =>
                {
                    b.Navigation("Cafes");

                    b.Navigation("Flats");

                    b.Navigation("Sights");
                });

            modelBuilder.Entity("RuTravel.Domain.Photos", b =>
                {
                    b.Navigation("Cafes");

                    b.Navigation("Flats");

                    b.Navigation("Posts");

                    b.Navigation("Sights");

                    b.Navigation("Towns");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("RuTravel.Domain.Towns", b =>
                {
                    b.Navigation("Cafes");

                    b.Navigation("Flats");

                    b.Navigation("Sights");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("RuTravel.Domain.Users", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Flats");

                    b.Navigation("Posts");
                });
#pragma warning restore 612, 618
        }
    }
}

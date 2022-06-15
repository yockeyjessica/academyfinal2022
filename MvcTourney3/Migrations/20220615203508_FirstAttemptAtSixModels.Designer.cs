﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MvcTourney3.Data;

#nullable disable

namespace MvcTourney3.Migrations
{
    [DbContext(typeof(MvcTourney3Context))]
    [Migration("20220615203508_FirstAttemptAtSixModels")]
    partial class FirstAttemptAtSixModels
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MvcTourney3.Models.GameTitles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("GameTitles");
                });

            modelBuilder.Entity("MvcTourney3.Models.Matches", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("GameTitlesId")
                        .HasColumnType("int");

                    b.Property<string>("Result")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Team1Id")
                        .HasColumnType("int");

                    b.Property<int>("Team1W")
                        .HasColumnType("int");

                    b.Property<int?>("Team2Id")
                        .HasColumnType("int");

                    b.Property<int>("Team2W")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GameTitlesId");

                    b.HasIndex("Team1Id");

                    b.HasIndex("Team2Id");

                    b.ToTable("Matches");
                });

            modelBuilder.Entity("MvcTourney3.Models.MatchGames", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Result")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Team1Id")
                        .HasColumnType("int");

                    b.Property<int>("Team1Score")
                        .HasColumnType("int");

                    b.Property<int?>("Team2Id")
                        .HasColumnType("int");

                    b.Property<int>("Team2Score")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Team1Id");

                    b.HasIndex("Team2Id");

                    b.ToTable("MatchGames");
                });

            modelBuilder.Entity("MvcTourney3.Models.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TeamId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.ToTable("Player");
                });

            modelBuilder.Entity("MvcTourney3.Models.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("GametitleId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("School")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GametitleId");

                    b.ToTable("Team");
                });

            modelBuilder.Entity("MvcTourney3.Models.Tournament", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("GametitleId")
                        .HasColumnType("int");

                    b.Property<string>("Season")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GametitleId");

                    b.ToTable("Tournament");
                });

            modelBuilder.Entity("MvcTourney3.Models.Matches", b =>
                {
                    b.HasOne("MvcTourney3.Models.GameTitles", null)
                        .WithMany("Matches")
                        .HasForeignKey("GameTitlesId");

                    b.HasOne("MvcTourney3.Models.Team", "Team1")
                        .WithMany()
                        .HasForeignKey("Team1Id");

                    b.HasOne("MvcTourney3.Models.Team", "Team2")
                        .WithMany()
                        .HasForeignKey("Team2Id");

                    b.Navigation("Team1");

                    b.Navigation("Team2");
                });

            modelBuilder.Entity("MvcTourney3.Models.MatchGames", b =>
                {
                    b.HasOne("MvcTourney3.Models.Team", "Team1")
                        .WithMany()
                        .HasForeignKey("Team1Id");

                    b.HasOne("MvcTourney3.Models.Team", "Team2")
                        .WithMany()
                        .HasForeignKey("Team2Id");

                    b.Navigation("Team1");

                    b.Navigation("Team2");
                });

            modelBuilder.Entity("MvcTourney3.Models.Player", b =>
                {
                    b.HasOne("MvcTourney3.Models.Team", "Team")
                        .WithMany("Players")
                        .HasForeignKey("TeamId");

                    b.Navigation("Team");
                });

            modelBuilder.Entity("MvcTourney3.Models.Team", b =>
                {
                    b.HasOne("MvcTourney3.Models.GameTitles", "Gametitle")
                        .WithMany()
                        .HasForeignKey("GametitleId");

                    b.Navigation("Gametitle");
                });

            modelBuilder.Entity("MvcTourney3.Models.Tournament", b =>
                {
                    b.HasOne("MvcTourney3.Models.GameTitles", "Gametitle")
                        .WithMany()
                        .HasForeignKey("GametitleId");

                    b.Navigation("Gametitle");
                });

            modelBuilder.Entity("MvcTourney3.Models.GameTitles", b =>
                {
                    b.Navigation("Matches");
                });

            modelBuilder.Entity("MvcTourney3.Models.Team", b =>
                {
                    b.Navigation("Players");
                });
#pragma warning restore 612, 618
        }
    }
}

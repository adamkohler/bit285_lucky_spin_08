﻿// <auto-generated />
using LuckySpin.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace LuckySpin.Migrations
{
    [DbContext(typeof(LuckySpinDataContext))]
    [Migration("20190214231605_SpinBalance")]
    partial class SpinBalance
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LuckySpin.Models.Player", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Balance");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<int>("Luck");

                    b.HasKey("Id");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("LuckySpin.Models.Spin", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Balance");

                    b.Property<bool>("IsWinning");

                    b.Property<long?>("PlayerId");

                    b.HasKey("Id");

                    b.HasIndex("PlayerId");

                    b.ToTable("Spin");
                });

            modelBuilder.Entity("LuckySpin.Models.Spin", b =>
                {
                    b.HasOne("LuckySpin.Models.Player")
                        .WithMany("Spins")
                        .HasForeignKey("PlayerId");
                });
#pragma warning restore 612, 618
        }
    }
}

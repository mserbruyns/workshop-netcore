﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Pencil42.PakjesDienst.Db;
using System;

namespace Pencil42.PakjesDienst.Db.Migrations
{
    [DbContext(typeof(PakjesContext))]
    partial class PakjesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Pencil42.PakjesDienst.Db.Pakje", b =>
                {
                    b.Property<int>("PakjeId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Bestemmeling");

                    b.Property<DateTime>("GeleverdOp");

                    b.Property<string>("Inhoud");

                    b.Property<string>("KoerierDienst");

                    b.Property<int>("LeveringsStatus");

                    b.Property<string>("Verzender");

                    b.Property<DateTime>("VoorzieneLeveringOp");

                    b.HasKey("PakjeId");

                    b.ToTable("Pakjes");
                });
#pragma warning restore 612, 618
        }
    }
}

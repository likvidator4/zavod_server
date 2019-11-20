﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Models;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using ZavodServer;

namespace ZavodServer.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20191119151541_first_migration")]
    partial class first_migration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.0-preview3.19554.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Models.ServerUnitDto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<float>("AttackDamage")
                        .HasColumnType("real");

                    b.Property<float>("AttackDelay")
                        .HasColumnType("real");

                    b.Property<float>("AttackRange")
                        .HasColumnType("real");

                    b.Property<float>("CurrentHp")
                        .HasColumnType("real");

                    b.Property<float>("Defense")
                        .HasColumnType("real");

                    b.Property<float>("LastAttackTime")
                        .HasColumnType("real");

                    b.Property<float>("MaxHp")
                        .HasColumnType("real");

                    b.Property<float>("MoveSpeed")
                        .HasColumnType("real");

                    b.Property<Vector3>("Position")
                        .HasColumnType("jsonb");

                    b.Property<Vector3>("Rotation")
                        .HasColumnType("jsonb");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Units");
                });
#pragma warning restore 612, 618
        }
    }
}
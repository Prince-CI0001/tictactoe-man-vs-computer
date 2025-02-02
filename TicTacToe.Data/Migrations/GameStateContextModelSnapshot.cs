﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using TicTacToe.Data;

#nullable disable

namespace TicTacToe.Data.Migrations
{
    [DbContext(typeof(GameStateContext))]
    partial class GameStateContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("TicTacToe.Contracts.Models.Game", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("Gamestate")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("oCount")
                        .HasColumnType("integer");

                    b.Property<string>("winner")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("xCount")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.ToTable("Games");
                });
#pragma warning restore 612, 618
        }
    }
}

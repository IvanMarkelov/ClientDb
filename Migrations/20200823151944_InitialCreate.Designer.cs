﻿// <auto-generated />
using System;
using ClientDbWebApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ClientDbWebApp.Migrations
{
    [DbContext(typeof(ClientDbWebAppContext))]
    [Migration("20200823151944_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ClientDbWebApp.Models.Client", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ClientCreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ClientInn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClientName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClientType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ClientUpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("ClientDbWebApp.Models.Founder", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClientID")
                        .HasColumnType("int");

                    b.Property<DateTime>("FounderCreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FounderFullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FounderInn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FounderUpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("ClientID");

                    b.ToTable("Founders");
                });

            modelBuilder.Entity("ClientDbWebApp.Models.Founder", b =>
                {
                    b.HasOne("ClientDbWebApp.Models.Client", "Client")
                        .WithMany("Founders")
                        .HasForeignKey("ClientID");
                });
#pragma warning restore 612, 618
        }
    }
}
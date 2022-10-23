﻿// <auto-generated />
using System;
using LeadsRSMserver.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace serverLeadsRSM.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20221023143746_modific-rsm-leads-db4")]
    partial class modificrsmleadsdb4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("rsmapp.Model.Lead", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("CompanyName");

                    b.Property<string>("CompanySize")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("CompanySize");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("CreateAt");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Name");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("PhoneNumber");

                    b.Property<string>("TypeRequest")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("TypeRequest");

                    b.HasKey("Id");

                    b.ToTable("Pessoa");
                });
#pragma warning restore 612, 618
        }
    }
}
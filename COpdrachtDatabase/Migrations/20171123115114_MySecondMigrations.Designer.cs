﻿// <auto-generated />
using COpdrachtDatabase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace COpdrachtDatabase.Migrations
{
    [DbContext(typeof(SchoolContext))]
    [Migration("20171123115114_MySecondMigrations")]
    partial class MySecondMigrations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("COpdrachtDatabase.Student", b =>
                {
                    b.Property<int>("StudentNumber")
                        .ValueGeneratedOnAdd();

                    b.Property<short>("StudentDivision");

                    b.Property<decimal?>("StudentHeight");

                    b.Property<string>("StudentName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<float?>("StudentWeight");

                    b.HasKey("StudentNumber");

                    b.ToTable("Students");
                });
#pragma warning restore 612, 618
        }
    }
}
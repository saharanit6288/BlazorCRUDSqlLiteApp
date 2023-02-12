﻿// <auto-generated />
using BlazorCRUDSqlLiteApp.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorCRUDSqlLiteApp.Server.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20230212140037_CreateIdentitySchema")]
    partial class CreateIdentitySchema
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.13");

            modelBuilder.Entity("BlazorCRUDSqlLiteApp.Shared.Models.User", b =>
                {
                    b.Property<int>("Userid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Cellnumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Emailid")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Userid");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
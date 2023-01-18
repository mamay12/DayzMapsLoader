﻿// <auto-generated />
using DayzMapsLoader.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DayzMapsLoader.Infrastructure.Migrations
{
    [DbContext(typeof(DayzMapLoaderContext))]
    [Migration("20230116210713_AddVirtualModifiers")]
    partial class AddVirtualModifiers
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DayzMapsLoader.Domain.Entities.Map", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastVersion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Link")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Maps");
                });

            modelBuilder.Entity("DayzMapsLoader.Domain.Entities.MapProvider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Link")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MapProviders");
                });

            modelBuilder.Entity("DayzMapsLoader.Domain.Entities.MapType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MapTypes");
                });

            modelBuilder.Entity("DayzMapsLoader.Domain.Entities.ProvidedMap", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ImageExtension")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsFirstQuadrant")
                        .HasColumnType("bit");

                    b.Property<int>("MapId")
                        .HasColumnType("int");

                    b.Property<int>("MapProviderId")
                        .HasColumnType("int");

                    b.Property<string>("MapTypeForProvider")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MapTypeId")
                        .HasColumnType("int");

                    b.Property<int>("MaxMapLevel")
                        .HasColumnType("int");

                    b.Property<string>("NameForProvider")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Version")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MapId");

                    b.HasIndex("MapProviderId");

                    b.HasIndex("MapTypeId");

                    b.ToTable("ProvidedMaps");
                });

            modelBuilder.Entity("DayzMapsLoader.Domain.Entities.ProvidedMap", b =>
                {
                    b.HasOne("DayzMapsLoader.Domain.Entities.Map", "Map")
                        .WithMany()
                        .HasForeignKey("MapId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DayzMapsLoader.Domain.Entities.MapProvider", "MapProvider")
                        .WithMany()
                        .HasForeignKey("MapProviderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DayzMapsLoader.Domain.Entities.MapType", "MapType")
                        .WithMany()
                        .HasForeignKey("MapTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Map");

                    b.Navigation("MapProvider");

                    b.Navigation("MapType");
                });
#pragma warning restore 612, 618
        }
    }
}

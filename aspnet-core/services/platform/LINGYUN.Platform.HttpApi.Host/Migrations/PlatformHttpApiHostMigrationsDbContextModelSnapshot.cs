﻿// <auto-generated />
using System;
using LINGYUN.Platform.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Volo.Abp.EntityFrameworkCore;

namespace LINGYUN.Platform.Migrations
{
    [DbContext(typeof(PlatformHttpApiHostMigrationsDbContext))]
    partial class PlatformHttpApiHostMigrationsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("_Abp_DatabaseProvider", EfCoreDatabaseProvider.MySql)
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("LINGYUN.Platform.Routes.RoleRoute", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("DeleterId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnType("char(36)");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnName("RoleName")
                        .HasColumnType("varchar(256) CHARACTER SET utf8mb4")
                        .HasMaxLength(256);

                    b.Property<Guid>("RouteId")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("TenantId")
                        .HasColumnName("TenantId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("RoleName", "RouteId");

                    b.ToTable("AppPlatformRoleRoute");
                });

            modelBuilder.Entity("LINGYUN.Platform.Routes.Route", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<bool>("AlwaysShow")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnName("Code")
                        .HasColumnType("varchar(95) CHARACTER SET utf8mb4")
                        .HasMaxLength(95);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnName("ConcurrencyStamp")
                        .HasColumnType("varchar(40) CHARACTER SET utf8mb4")
                        .HasMaxLength(40);

                    b.Property<DateTime>("CreationTime")
                        .HasColumnName("CreationTime")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnName("CreatorId")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("DeleterId")
                        .HasColumnName("DeleterId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnName("DeletionTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .HasColumnName("Description")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4")
                        .HasMaxLength(255);

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasColumnName("DisplayName")
                        .HasColumnType("varchar(128) CHARACTER SET utf8mb4")
                        .HasMaxLength(128);

                    b.Property<string>("ExtraProperties")
                        .HasColumnName("ExtraProperties")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("FullName")
                        .HasColumnName("FullName")
                        .HasColumnType("varchar(128) CHARACTER SET utf8mb4")
                        .HasMaxLength(128);

                    b.Property<string>("Icon")
                        .HasColumnName("Icon")
                        .HasColumnType("varchar(128) CHARACTER SET utf8mb4")
                        .HasMaxLength(128);

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("IsDeleted")
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(false);

                    b.Property<bool>("IsMenu")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsPublic")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsSideBar")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsStatic")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsToolBar")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnName("LastModificationTime")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnName("LastModifierId")
                        .HasColumnType("char(36)");

                    b.Property<string>("LinkUrl")
                        .IsRequired()
                        .HasColumnName("LinkUrl")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4")
                        .HasMaxLength(255);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("Name")
                        .HasColumnType("varchar(64) CHARACTER SET utf8mb4")
                        .HasMaxLength(64);

                    b.Property<Guid?>("ParentId")
                        .HasColumnType("char(36)");

                    b.Property<int>("PlatformType")
                        .HasColumnType("int");

                    b.Property<Guid?>("TenantId")
                        .HasColumnName("TenantId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("Code");

                    b.HasIndex("ParentId");

                    b.ToTable("AppPlatformRoute");
                });

            modelBuilder.Entity("LINGYUN.Platform.Routes.UserRoute", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("DeleterId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("RouteId")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("TenantId")
                        .HasColumnName("TenantId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("UserId", "RouteId");

                    b.ToTable("AppPlatformUserRoute");
                });

            modelBuilder.Entity("LINGYUN.Platform.Versions.AppVersion", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnName("ConcurrencyStamp")
                        .HasColumnType("varchar(40) CHARACTER SET utf8mb4")
                        .HasMaxLength(40);

                    b.Property<DateTime>("CreationTime")
                        .HasColumnName("CreationTime")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnName("CreatorId")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("DeleterId")
                        .HasColumnName("DeleterId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("DeletionTime")
                        .HasColumnName("DeletionTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .HasColumnName("Description")
                        .HasColumnType("longtext CHARACTER SET utf8mb4")
                        .HasMaxLength(2048);

                    b.Property<string>("ExtraProperties")
                        .HasColumnName("ExtraProperties")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("IsDeleted")
                        .HasColumnType("tinyint(1)")
                        .HasDefaultValue(false);

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnName("LastModificationTime")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnName("LastModifierId")
                        .HasColumnType("char(36)");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<Guid?>("TenantId")
                        .HasColumnName("TenantId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnName("Title")
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.Property<string>("Version")
                        .IsRequired()
                        .HasColumnName("Version")
                        .HasColumnType("varchar(20) CHARACTER SET utf8mb4")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.HasIndex("Version");

                    b.ToTable("AppPlatformVersion");
                });

            modelBuilder.Entity("LINGYUN.Platform.Versions.VersionFile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<Guid>("AppVersionId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnName("CreationTime")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnName("CreatorId")
                        .HasColumnType("char(36)");

                    b.Property<int>("DownloadCount")
                        .HasColumnType("int");

                    b.Property<int>("FileType")
                        .HasColumnType("int");

                    b.Property<DateTime?>("LastModificationTime")
                        .HasColumnName("LastModificationTime")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("LastModifierId")
                        .HasColumnName("LastModifierId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("Name")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4")
                        .HasMaxLength(255);

                    b.Property<string>("SHA256")
                        .IsRequired()
                        .HasColumnName("SHA256")
                        .HasColumnType("varchar(65) CHARACTER SET utf8mb4")
                        .HasMaxLength(65);

                    b.Property<long>("Size")
                        .HasColumnType("bigint");

                    b.Property<Guid?>("TenantId")
                        .HasColumnName("TenantId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Version")
                        .IsRequired()
                        .HasColumnName("Version")
                        .HasColumnType("varchar(20) CHARACTER SET utf8mb4")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.HasIndex("AppVersionId");

                    b.HasIndex("Name", "Version");

                    b.ToTable("AppPlatformVersionFile");
                });

            modelBuilder.Entity("LINGYUN.Platform.Routes.Route", b =>
                {
                    b.HasOne("LINGYUN.Platform.Routes.Route", null)
                        .WithMany()
                        .HasForeignKey("ParentId");
                });

            modelBuilder.Entity("LINGYUN.Platform.Versions.VersionFile", b =>
                {
                    b.HasOne("LINGYUN.Platform.Versions.AppVersion", "AppVersion")
                        .WithMany("Files")
                        .HasForeignKey("AppVersionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

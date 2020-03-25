﻿// <auto-generated />
using System;
using Lykke.Service.AdminManagement.MsSqlRepositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Lykke.Service.AdminManagement.MsSqlRepositories.Migrations
{
    [DbContext(typeof(AdminManagementContext))]
    [Migration("20191203090540_Permissions")]
    partial class Permissions
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("admin_users")
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Lykke.Service.AdminManagement.MsSqlRepositories.Entities.AdminUserEntity", b =>
                {
                    b.Property<string>("AdminUserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("admin_id");

                    b.Property<string>("EmailHash")
                        .IsRequired()
                        .HasColumnName("email_hash")
                        .HasColumnType("char(64)");

                    b.Property<bool>("IsDisabled")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("is_disabled")
                        .HasDefaultValue(false);

                    b.Property<DateTime>("RegisteredAt")
                        .HasColumnName("registered_at");

                    b.Property<bool>("UseCustomPermissions")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("use_custom_permissions")
                        .HasDefaultValue(false);

                    b.HasKey("AdminUserId");

                    b.HasIndex("EmailHash")
                        .IsUnique();

                    b.ToTable("AdminUser");
                });

            modelBuilder.Entity("Lykke.Service.AdminManagement.MsSqlRepositories.Entities.PermissionEntity", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("AdminUserId")
                        .IsRequired()
                        .HasColumnName("admin_id");

                    b.Property<string>("Level")
                        .IsRequired()
                        .HasColumnName("level");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnName("type");

                    b.HasKey("Id");

                    b.HasIndex("AdminUserId");

                    b.ToTable("permissions");
                });
#pragma warning restore 612, 618
        }
    }
}
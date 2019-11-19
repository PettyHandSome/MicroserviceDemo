﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using PermissionService.Domain;

namespace PermissionService.Domain.Migrations
{
    [DbContext(typeof(PermissionDBContext))]
    partial class PermissionDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("PermissionService.Domain.Principal", b =>
                {
                    b.Property<string>("TenantCode");

                    b.Property<Guid>("ID");

                    b.Property<DateTimeOffset>("CreateIn");

                    b.Property<string>("CreatedBy");

                    b.Property<string>("OwnerScopeCode");

                    b.Property<string>("PrincipalCode")
                        .IsRequired();

                    b.Property<string>("PrincipalDesc");

                    b.Property<string>("PrincipalName")
                        .IsRequired();

                    b.Property<DateTimeOffset?>("UpdateIn");

                    b.Property<string>("UpdatedBy");

                    b.HasKey("TenantCode", "ID");

                    b.HasIndex("TenantCode");

                    b.HasIndex("TenantCode", "PrincipalCode")
                        .IsUnique();

                    b.ToTable("Principal");

                    b.HasData(
                        new
                        {
                            TenantCode = "SYSTEM",
                            ID = new Guid("0f48ddee-66a0-42b9-ac3b-f8705badf4aa"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            OwnerScopeCode = "",
                            PrincipalCode = "admin",
                            PrincipalName = "admin"
                        });
                });

            modelBuilder.Entity("PermissionService.Domain.Role", b =>
                {
                    b.Property<string>("TenantCode");

                    b.Property<Guid>("ID");

                    b.Property<DateTimeOffset>("CreateIn");

                    b.Property<string>("CreatedBy");

                    b.Property<string>("OwnerScopeCode");

                    b.Property<string>("RoleCode")
                        .IsRequired();

                    b.Property<string>("RoleDesc");

                    b.Property<string>("RoleName")
                        .IsRequired();

                    b.Property<int>("RoleType");

                    b.Property<int>("SortNO");

                    b.Property<DateTimeOffset?>("UpdateIn");

                    b.Property<string>("UpdatedBy");

                    b.HasKey("TenantCode", "ID");

                    b.HasIndex("TenantCode");

                    b.HasIndex("TenantCode", "RoleCode")
                        .IsUnique();

                    b.ToTable("Role");

                    b.HasData(
                        new
                        {
                            TenantCode = "SYSTEM",
                            ID = new Guid("f5893dc8-84fd-49c0-9874-2e0f2474209c"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            OwnerScopeCode = "",
                            RoleCode = "administor",
                            RoleName = "administor",
                            RoleType = 1,
                            SortNO = 0
                        });
                });

            modelBuilder.Entity("PermissionService.Domain.RoleAssignment", b =>
                {
                    b.Property<string>("TenantCode");

                    b.Property<Guid>("ID");

                    b.Property<DateTimeOffset>("CreateIn");

                    b.Property<string>("CreatedBy");

                    b.Property<string>("OwnerScopeCode");

                    b.Property<Guid>("PrincipalID");

                    b.Property<Guid>("RoleID");

                    b.Property<Guid>("ScopeID");

                    b.Property<DateTimeOffset?>("UpdateIn");

                    b.Property<string>("UpdatedBy");

                    b.HasKey("TenantCode", "ID");

                    b.HasIndex("TenantCode");

                    b.HasIndex("TenantCode", "PrincipalID");

                    b.HasIndex("TenantCode", "RoleID");

                    b.HasIndex("TenantCode", "ScopeID");

                    b.ToTable("RoleAssignment");

                    b.HasData(
                        new
                        {
                            TenantCode = "SYSTEM",
                            ID = new Guid("71b619d1-3d3f-415b-b78d-1d307dce1d33"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            OwnerScopeCode = "",
                            PrincipalID = new Guid("0f48ddee-66a0-42b9-ac3b-f8705badf4aa"),
                            RoleID = new Guid("f5893dc8-84fd-49c0-9874-2e0f2474209c"),
                            ScopeID = new Guid("88888888-8888-8888-8888-888888888888")
                        });
                });

            modelBuilder.Entity("PermissionService.Domain.RolePermission", b =>
                {
                    b.Property<string>("TenantCode");

                    b.Property<Guid>("ID");

                    b.Property<DateTimeOffset>("CreateIn");

                    b.Property<string>("CreatedBy");

                    b.Property<string>("OwnerScopeCode");

                    b.Property<string>("ResourceCode")
                        .IsRequired();

                    b.Property<string>("ResourceName")
                        .IsRequired();

                    b.Property<Guid>("RoleID");

                    b.Property<DateTimeOffset?>("UpdateIn");

                    b.Property<string>("UpdatedBy");

                    b.HasKey("TenantCode", "ID");

                    b.HasIndex("TenantCode");

                    b.HasIndex("TenantCode", "RoleID");

                    b.ToTable("RolePermission");

                    b.HasData(
                        new
                        {
                            TenantCode = "SYSTEM",
                            ID = new Guid("5e202161-af2e-48ab-9040-a22ac7a1cac9"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            OwnerScopeCode = "",
                            ResourceCode = "Permission.GetUserMenus",
                            ResourceName = "获取用户菜单",
                            RoleID = new Guid("f5893dc8-84fd-49c0-9874-2e0f2474209c")
                        },
                        new
                        {
                            TenantCode = "SYSTEM",
                            ID = new Guid("32e711c9-844c-479d-addd-a2f62f122250"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            OwnerScopeCode = "",
                            ResourceCode = "values.getuserclaims",
                            ResourceName = "getuserclaims",
                            RoleID = new Guid("f5893dc8-84fd-49c0-9874-2e0f2474209c")
                        },
                        new
                        {
                            TenantCode = "SYSTEM",
                            ID = new Guid("81f20441-938e-4fa7-aae1-7b457e0dadff"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            OwnerScopeCode = "",
                            ResourceCode = "RootMenu",
                            ResourceName = "RootMenu",
                            RoleID = new Guid("f5893dc8-84fd-49c0-9874-2e0f2474209c")
                        },
                        new
                        {
                            TenantCode = "SYSTEM",
                            ID = new Guid("e801aae5-d346-497d-b227-1a5a69a54a13"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            OwnerScopeCode = "",
                            ResourceCode = "ProductMngmt",
                            ResourceName = "产品管理",
                            RoleID = new Guid("f5893dc8-84fd-49c0-9874-2e0f2474209c")
                        },
                        new
                        {
                            TenantCode = "SYSTEM",
                            ID = new Guid("2cb71513-c0a4-4910-8a4c-2e9c9828d449"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            OwnerScopeCode = "",
                            ResourceCode = "SystemMngmt",
                            ResourceName = "系统管理",
                            RoleID = new Guid("f5893dc8-84fd-49c0-9874-2e0f2474209c")
                        },
                        new
                        {
                            TenantCode = "SYSTEM",
                            ID = new Guid("19db8614-f955-4497-bcf6-9f3fb2dabe51"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            OwnerScopeCode = "",
                            ResourceCode = "SystemMngmt.PermissionMngmt",
                            ResourceName = "权限管理",
                            RoleID = new Guid("f5893dc8-84fd-49c0-9874-2e0f2474209c")
                        },
                        new
                        {
                            TenantCode = "SYSTEM",
                            ID = new Guid("a3b7904a-d00d-4fb6-86a1-12d4bbbc4208"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            OwnerScopeCode = "",
                            ResourceCode = "SystemMngmt.PermissionMngmt.RoleMngmt",
                            ResourceName = "角色管理",
                            RoleID = new Guid("f5893dc8-84fd-49c0-9874-2e0f2474209c")
                        },
                        new
                        {
                            TenantCode = "SYSTEM",
                            ID = new Guid("4a68dca2-0eac-437f-8c49-11d606f871d9"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            OwnerScopeCode = "",
                            ResourceCode = "SystemMngmt.PermissionMngmt.RoleMngmt.Read",
                            ResourceName = "查看",
                            RoleID = new Guid("f5893dc8-84fd-49c0-9874-2e0f2474209c")
                        },
                        new
                        {
                            TenantCode = "SYSTEM",
                            ID = new Guid("7f2087fa-0ce4-4dc7-9772-fbe006ad2b1f"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            OwnerScopeCode = "",
                            ResourceCode = "SystemMngmt.PermissionMngmt.RoleMngmt.Update",
                            ResourceName = "更改",
                            RoleID = new Guid("f5893dc8-84fd-49c0-9874-2e0f2474209c")
                        },
                        new
                        {
                            TenantCode = "SYSTEM",
                            ID = new Guid("77ae39ee-3384-40a3-8b95-4d6b6c7a8027"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            OwnerScopeCode = "",
                            ResourceCode = "SystemMngmt.PermissionMngmt.ScopeMngmt",
                            ResourceName = "范围管理",
                            RoleID = new Guid("f5893dc8-84fd-49c0-9874-2e0f2474209c")
                        },
                        new
                        {
                            TenantCode = "SYSTEM",
                            ID = new Guid("474ab566-f062-4314-8d54-f8e343ea2453"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            OwnerScopeCode = "",
                            ResourceCode = "SystemMngmt.PermissionMngmt.AssignmnentMngmt",
                            ResourceName = "授权管理",
                            RoleID = new Guid("f5893dc8-84fd-49c0-9874-2e0f2474209c")
                        });
                });

            modelBuilder.Entity("PermissionService.Domain.Scope", b =>
                {
                    b.Property<string>("TenantCode");

                    b.Property<Guid>("ID");

                    b.Property<DateTimeOffset>("CreateIn");

                    b.Property<string>("CreatedBy");

                    b.Property<string>("OwnerScopeCode");

                    b.Property<Guid>("ParentScopeID");

                    b.Property<string>("ScopeCode")
                        .IsRequired();

                    b.Property<string>("ScopeDesc");

                    b.Property<string>("ScopeName")
                        .IsRequired();

                    b.Property<int>("SortNO");

                    b.Property<DateTimeOffset?>("UpdateIn");

                    b.Property<string>("UpdatedBy");

                    b.HasKey("TenantCode", "ID");

                    b.HasIndex("TenantCode");

                    b.HasIndex("TenantCode", "ParentScopeID");

                    b.HasIndex("TenantCode", "ScopeCode")
                        .IsUnique();

                    b.ToTable("Scope");

                    b.HasData(
                        new
                        {
                            TenantCode = "SYSTEM",
                            ID = new Guid("88888888-8888-8888-8888-888888888888"),
                            CreateIn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            OwnerScopeCode = "",
                            ParentScopeID = new Guid("88888888-8888-8888-8888-888888888888"),
                            ScopeCode = "RootScope",
                            ScopeName = "RootScope",
                            SortNO = 0
                        });
                });

            modelBuilder.Entity("ServiceCommon.Recycle", b =>
                {
                    b.Property<string>("TenantCode");

                    b.Property<Guid>("ID");

                    b.Property<DateTimeOffset>("CreateIn");

                    b.Property<string>("CreatedBy");

                    b.Property<Guid>("DeleteBatchID");

                    b.Property<string>("OwnerScopeCode");

                    b.Property<string>("RowData")
                        .IsRequired();

                    b.Property<Guid>("RowKey");

                    b.Property<string>("TableName")
                        .IsRequired();

                    b.Property<DateTimeOffset?>("UpdateIn");

                    b.Property<string>("UpdatedBy");

                    b.HasKey("TenantCode", "ID");

                    b.HasIndex("TenantCode");

                    b.ToTable("Recycle");
                });

            modelBuilder.Entity("PermissionService.Domain.RoleAssignment", b =>
                {
                    b.HasOne("PermissionService.Domain.Principal", "Principal")
                        .WithMany("RoleAssignments")
                        .HasForeignKey("TenantCode", "PrincipalID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PermissionService.Domain.Role", "Role")
                        .WithMany("RoleAssignments")
                        .HasForeignKey("TenantCode", "RoleID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PermissionService.Domain.Scope", "Scope")
                        .WithMany("RoleAssignments")
                        .HasForeignKey("TenantCode", "ScopeID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PermissionService.Domain.RolePermission", b =>
                {
                    b.HasOne("PermissionService.Domain.Role", "Role")
                        .WithMany("RolePermissions")
                        .HasForeignKey("TenantCode", "RoleID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PermissionService.Domain.Scope", b =>
                {
                    b.HasOne("PermissionService.Domain.Scope", "ParentScope")
                        .WithMany("ChildrenScopes")
                        .HasForeignKey("TenantCode", "ParentScopeID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

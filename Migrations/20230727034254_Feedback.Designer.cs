﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TimeMate.Areas.Identity.Data;

#nullable disable

namespace TimeMate.Migrations
{
    [DbContext(typeof(TimeMateContext))]
    [Migration("20230727034254_Feedback")]
    partial class Feedback
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("TimeMate.Areas.Identity.Data.TimeMateUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("TimeMate.Models.ChangeProjectRequests", b =>
                {
                    b.Property<int>("changeProjectRequestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("changeProjectRequestId"));

                    b.Property<string>("individualId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("projectId")
                        .HasColumnType("int");

                    b.Property<string>("status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("changeProjectRequestId");

                    b.HasIndex("individualId");

                    b.HasIndex("projectId");

                    b.ToTable("ChangeProjectRequests");
                });

            modelBuilder.Entity("TimeMate.Models.Feedback", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("feeds");
                });

            modelBuilder.Entity("TimeMate.Models.GoalSetting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AssignedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AssignedTo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime?>("dueDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("isComplete")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("GoalSetting");
                });

            modelBuilder.Entity("TimeMate.Models.LeaveRequest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CancellationReason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CompensatoryDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("employeeId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("endDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ManagerApproval")
                        .HasColumnType("int");

                    b.Property<string>("Reason")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("startDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("employeeId");

                    b.ToTable("leaveRequests");
                });

            modelBuilder.Entity("TimeMate.Models.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasMaxLength(5000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsArchived")
                        .HasColumnType("bit");

                    b.Property<bool>("IsRead")
                        .HasColumnType("bit");

                    b.Property<string>("RecipientEmail")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("SenderEmail")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("SentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("messages");
                });

            modelBuilder.Entity("TimeMate.Models.Permission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ApprovedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ApprovedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("description")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<bool>("IsApproved")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("RequestedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RequestedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Permission");
                });

            modelBuilder.Entity("TimeMate.Models.Project", b =>
                {
                    b.Property<int>("projectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("projectId"));

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WorkspaceId")
                        .HasColumnType("int");

                    b.HasKey("projectId");

                    b.HasIndex("WorkspaceId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("TimeMate.Models.ProjectAssignment", b =>
                {
                    b.Property<int>("ProjectAssignmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProjectAssignmentId"));

                    b.Property<string>("employeeId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("projectId")
                        .HasColumnType("int");

                    b.Property<string>("status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProjectAssignmentId");

                    b.HasIndex("employeeId");

                    b.HasIndex("projectId");

                    b.ToTable("ProjectAssignment");
                });

            modelBuilder.Entity("TimeMate.Models.Tasks", b =>
                {
                    b.Property<int>("TaskId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TaskId"));

                    b.Property<string>("TaskName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WorkspaceId")
                        .HasColumnType("int");

                    b.HasKey("TaskId");

                    b.HasIndex("WorkspaceId");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("TimeMate.Models.TimeSheet", b =>
                {
                    b.Property<int>("TimeSheetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TimeSheetId"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("employeeId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("HoursSpent")
                        .HasColumnType("int");

                    b.Property<int>("projectId")
                        .HasColumnType("int");

                    b.Property<string>("status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Task")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TaskType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TimeSheetId");

                    b.HasIndex("employeeId");

                    b.HasIndex("projectId");

                    b.ToTable("TimeSheets");
                });

            modelBuilder.Entity("TimeMate.Models.WeekSetting", b =>
                {
                    b.Property<int>("WeekSettingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WeekSettingId"));

                    b.Property<string>("EndDay")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("startDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("StartDay")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WorkspaceId")
                        .HasColumnType("int");

                    b.HasKey("WeekSettingId");

                    b.HasIndex("WorkspaceId");

                    b.ToTable("WeekSettings");
                });

            modelBuilder.Entity("TimeMate.Models.WorkSpace", b =>
                {
                    b.Property<int>("WorkspaceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WorkspaceId"));

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PmId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("WorkspaceId");

                    b.HasIndex("PmId");

                    b.ToTable("Workspaces");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("TimeMate.Areas.Identity.Data.TimeMateUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("TimeMate.Areas.Identity.Data.TimeMateUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TimeMate.Areas.Identity.Data.TimeMateUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("TimeMate.Areas.Identity.Data.TimeMateUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TimeMate.Models.ChangeProjectRequests", b =>
                {
                    b.HasOne("TimeMate.Areas.Identity.Data.TimeMateUser", "TimeMateUser")
                        .WithMany()
                        .HasForeignKey("individualId");

                    b.HasOne("TimeMate.Models.Project", "Project")
                        .WithMany()
                        .HasForeignKey("projectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");

                    b.Navigation("TimeMateUser");
                });

            modelBuilder.Entity("TimeMate.Models.LeaveRequest", b =>
                {
                    b.HasOne("TimeMate.Areas.Identity.Data.TimeMateUser", "employee")
                        .WithMany()
                        .HasForeignKey("employeeId");

                    b.Navigation("employee");
                });

            modelBuilder.Entity("TimeMate.Models.Project", b =>
                {
                    b.HasOne("TimeMate.Models.WorkSpace", "WorkSpace")
                        .WithMany()
                        .HasForeignKey("WorkspaceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("WorkSpace");
                });

            modelBuilder.Entity("TimeMate.Models.ProjectAssignment", b =>
                {
                    b.HasOne("TimeMate.Areas.Identity.Data.TimeMateUser", "TimeMateUser")
                        .WithMany()
                        .HasForeignKey("employeeId");

                    b.HasOne("TimeMate.Models.Project", "Project")
                        .WithMany()
                        .HasForeignKey("projectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");

                    b.Navigation("TimeMateUser");
                });

            modelBuilder.Entity("TimeMate.Models.Tasks", b =>
                {
                    b.HasOne("TimeMate.Models.WorkSpace", "Workspace")
                        .WithMany()
                        .HasForeignKey("WorkspaceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Workspace");
                });

            modelBuilder.Entity("TimeMate.Models.TimeSheet", b =>
                {
                    b.HasOne("TimeMate.Areas.Identity.Data.TimeMateUser", "TimeMateUser")
                        .WithMany()
                        .HasForeignKey("employeeId");

                    b.HasOne("TimeMate.Models.Project", "Project")
                        .WithMany()
                        .HasForeignKey("projectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");

                    b.Navigation("TimeMateUser");
                });

            modelBuilder.Entity("TimeMate.Models.WeekSetting", b =>
                {
                    b.HasOne("TimeMate.Models.WorkSpace", "WorkSpace")
                        .WithMany()
                        .HasForeignKey("WorkspaceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("WorkSpace");
                });

            modelBuilder.Entity("TimeMate.Models.WorkSpace", b =>
                {
                    b.HasOne("TimeMate.Areas.Identity.Data.TimeMateUser", "TimeMateUser")
                        .WithMany()
                        .HasForeignKey("PmId");

                    b.Navigation("TimeMateUser");
                });
#pragma warning restore 612, 618
        }
    }
}
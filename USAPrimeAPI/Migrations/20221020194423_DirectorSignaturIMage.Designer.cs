// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using USAPrimeAPI.Context;

#nullable disable

namespace USAPrimeAPI.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20221020194423_DirectorSignaturIMage")]
    partial class DirectorSignaturIMage
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

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

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

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

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

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
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

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
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("USAPrimeAPI.BusinessModels.Agreement", b =>
                {
                    b.Property<int>("Form_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Form_ID"), 1L, 1);

                    b.Property<string>("Additional_Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Coach_Pay_Per_team")
                        .HasColumnType("float");

                    b.Property<double?>("Indoor_Rental")
                        .HasColumnType("float");

                    b.Property<int?>("MasterID")
                        .HasColumnType("int");

                    b.Property<int?>("No_Of_Full_Paid_Players_Per_Team")
                        .HasColumnType("int");

                    b.Property<double?>("Outdoor_Rental")
                        .HasColumnType("float");

                    b.Property<double?>("Player_Fee")
                        .HasColumnType("float");

                    b.Property<int>("Season_ID")
                        .HasColumnType("int");

                    b.Property<int?>("Tournament_Budget_Per_Team")
                        .HasColumnType("int");

                    b.Property<DateTime?>("TrxDate")
                        .HasColumnType("datetime2");

                    b.Property<double?>("Uniform_Fee")
                        .HasColumnType("float");

                    b.Property<string>("User_ID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("agreement")
                        .HasColumnType("bit");

                    b.Property<bool?>("approvedByAdmin")
                        .HasColumnType("bit");

                    b.Property<bool>("forwardedToAdmin")
                        .HasColumnType("bit");

                    b.HasKey("Form_ID");

                    b.ToTable("T_Agreements");
                });

            modelBuilder.Entity("USAPrimeAPI.BusinessModels.ApplicationUser", b =>
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

                    b.Property<string>("Fname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<int?>("No_Of_HS_Teams")
                        .HasColumnType("int");

                    b.Property<int?>("No_Of_YT_Teams")
                        .HasColumnType("int");

                    b.Property<int?>("No_of_Softball_Teams")
                        .HasColumnType("int");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Organization")
                        .HasColumnType("nvarchar(max)");

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

                    b.Property<string>("city")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("securityCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("state")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("USAPrimeAPI.BusinessModels.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeId"), 1L, 1);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmployeeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("USAPrimeAPI.BusinessModels.OnePager", b =>
                {
                    b.Property<int>("Form_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Form_ID"), 1L, 1);

                    b.Property<string>("Additional_Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Coach_Pay_Per_team")
                        .HasColumnType("float");

                    b.Property<int?>("MasterID")
                        .HasColumnType("int");

                    b.Property<int?>("No_Of_Full_Paid_Players_Per_Team")
                        .HasColumnType("int");

                    b.Property<double?>("Player_Fee")
                        .HasColumnType("float");

                    b.Property<int>("Season_ID")
                        .HasColumnType("int");

                    b.Property<int?>("Tournament_Budget_Per_Team")
                        .HasColumnType("int");

                    b.Property<DateTime?>("TrxDate")
                        .HasColumnType("datetime2");

                    b.Property<double?>("Uniform_Fee")
                        .HasColumnType("float");

                    b.Property<string>("User_ID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("agreement")
                        .HasColumnType("bit");

                    b.Property<bool?>("approvedByAdmin")
                        .HasColumnType("bit");

                    b.Property<bool>("forwardedToAdmin")
                        .HasColumnType("bit");

                    b.HasKey("Form_ID");

                    b.ToTable("T_One_Pager");
                });

            modelBuilder.Entity("USAPrimeAPI.BusinessModels.OnePagerAdmin", b =>
                {
                    b.Property<int>("Form_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Form_ID"), 1L, 1);

                    b.Property<string>("Additional_Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Coach_Pay_Per_team")
                        .HasColumnType("float");

                    b.Property<int?>("MasterID")
                        .HasColumnType("int");

                    b.Property<int?>("No_Of_Full_Paid_Players_Per_Team")
                        .HasColumnType("int");

                    b.Property<double?>("Player_Fee")
                        .HasColumnType("float");

                    b.Property<int>("Season_ID")
                        .HasColumnType("int");

                    b.Property<int?>("Tournament_Budget_Per_Team")
                        .HasColumnType("int");

                    b.Property<DateTime?>("TrxDate")
                        .HasColumnType("datetime2");

                    b.Property<double?>("Uniform_Fee")
                        .HasColumnType("float");

                    b.Property<string>("User_ID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("agreement")
                        .HasColumnType("bit");

                    b.Property<bool?>("approvedByAdmin")
                        .HasColumnType("bit");

                    b.Property<bool>("forwardedToAdmin")
                        .HasColumnType("bit");

                    b.HasKey("Form_ID");

                    b.ToTable("onePagerAdmin");
                });

            modelBuilder.Entity("USAPrimeAPI.BusinessModels.OnePagerMaster", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("AdminsignatureImg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Agreement")
                        .HasColumnType("bit");

                    b.Property<bool?>("Approve")
                        .HasColumnType("bit");

                    b.Property<string>("DirectorID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DirectorsignatureImg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Season")
                        .HasColumnType("int");

                    b.Property<DateTime>("TrxDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("onePagerMaster");
                });

            modelBuilder.Entity("USAPrimeAPI.BusinessModels.Seasons", b =>
                {
                    b.Property<int>("Season_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Season_ID"), 1L, 1);

                    b.Property<string>("Season_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Season_ID");

                    b.ToTable("T_Seasons");
                });

            modelBuilder.Entity("USAPrimeAPI.BusinessModels.Years", b =>
                {
                    b.Property<int>("Year_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Year_ID"), 1L, 1);

                    b.Property<string>("Year_Decode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Year_ID");

                    b.ToTable("T_Years");
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
                    b.HasOne("USAPrimeAPI.BusinessModels.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("USAPrimeAPI.BusinessModels.ApplicationUser", null)
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

                    b.HasOne("USAPrimeAPI.BusinessModels.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("USAPrimeAPI.BusinessModels.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

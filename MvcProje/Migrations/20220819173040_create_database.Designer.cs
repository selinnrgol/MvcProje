// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MvcProje.Data;

#nullable disable

namespace MvcProje.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220819173040_create_database")]
    partial class create_database
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MvcProje.Models.Entity.About", b =>
                {
                    b.Property<int>("AboutId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AboutId"), 1L, 1);

                    b.Property<string>("AboutDetail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("AboutStatus")
                        .HasColumnType("bit");

                    b.HasKey("AboutId");

                    b.ToTable("Abouts");
                });

            modelBuilder.Entity("MvcProje.Models.Entity.Animal", b =>
                {
                    b.Property<int>("AnimalID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AnimalID"), 1L, 1);

                    b.Property<int?>("AboutId")
                        .HasColumnType("int");

                    b.Property<int>("AnimalAge")
                        .HasColumnType("int");

                    b.Property<string>("AnimalDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AnimalImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AnimalName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("AnimalStatus")
                        .HasColumnType("bit");

                    b.Property<int>("CategoryID1")
                        .HasColumnType("int");

                    b.Property<int>("UserID1")
                        .HasColumnType("int");

                    b.HasKey("AnimalID");

                    b.HasIndex("AboutId");

                    b.HasIndex("CategoryID1");

                    b.HasIndex("UserID1");

                    b.ToTable("Animals");
                });

            modelBuilder.Entity("MvcProje.Models.Entity.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryID"), 1L, 1);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("CategoryStatus")
                        .HasColumnType("bit");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("MvcProje.Models.Entity.Comment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CommentId"), 1L, 1);

                    b.Property<int>("AnimalID1")
                        .HasColumnType("int");

                    b.Property<string>("CommentContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CommentDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("CommentStatus")
                        .HasColumnType("bit");

                    b.Property<string>("CommentUserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CommentId");

                    b.HasIndex("AnimalID1");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("MvcProje.Models.Entity.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserID"), 1L, 1);

                    b.Property<string>("UserAbout")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("UserStatus")
                        .HasColumnType("bit");

                    b.Property<string>("UserSurname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MvcProje.Models.Entity.Animal", b =>
                {
                    b.HasOne("MvcProje.Models.Entity.About", null)
                        .WithMany("Animals")
                        .HasForeignKey("AboutId");

                    b.HasOne("MvcProje.Models.Entity.Category", "Category")
                        .WithMany("Animals")
                        .HasForeignKey("CategoryID1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MvcProje.Models.Entity.User", "User")
                        .WithMany("Animals")
                        .HasForeignKey("UserID1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MvcProje.Models.Entity.Comment", b =>
                {
                    b.HasOne("MvcProje.Models.Entity.Animal", "Animal")
                        .WithMany("Comments")
                        .HasForeignKey("AnimalID1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Animal");
                });

            modelBuilder.Entity("MvcProje.Models.Entity.About", b =>
                {
                    b.Navigation("Animals");
                });

            modelBuilder.Entity("MvcProje.Models.Entity.Animal", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("MvcProje.Models.Entity.Category", b =>
                {
                    b.Navigation("Animals");
                });

            modelBuilder.Entity("MvcProje.Models.Entity.User", b =>
                {
                    b.Navigation("Animals");
                });
#pragma warning restore 612, 618
        }
    }
}

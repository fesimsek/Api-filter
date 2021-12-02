﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using WebApplication5.DbOperations;

namespace WebApplication5.Migrations
{
    [DbContext(typeof(ApiDbContext))]
    [Migration("20211125101944_new6")]
    partial class new6
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("public")
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("WebApplication5.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Customer_Name")
                        .HasColumnType("text")
                        .HasColumnName("Customer name");

                    b.Property<int?>("User_ID")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("User_ID");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("WebApplication5.Filter", b =>
                {
                    b.Property<string>("Field")
                        .HasColumnType("text");

                    b.Property<string>("Operator")
                        .HasColumnType("text");

                    b.HasKey("Field");

                    b.ToTable("Filters");
                });

            modelBuilder.Entity("WebApplication5.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("User_ID")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("User_ID");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("WebApplication5.Group_Permission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("Group_ID")
                        .HasColumnType("integer");

                    b.Property<int>("Permission_ID")
                        .HasColumnType("integer");

                    b.Property<int>("Program_ID")
                        .HasColumnType("integer");

                    b.Property<int?>("User_ID")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("Group_ID");

                    b.HasIndex("Permission_ID");

                    b.HasIndex("Program_ID");

                    b.HasIndex("User_ID");

                    b.ToTable("Group_Permissions");
                });

            modelBuilder.Entity("WebApplication5.Group_User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("Group_ID")
                        .HasColumnType("integer");

                    b.Property<int?>("User_ID")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("Group_ID");

                    b.HasIndex("User_ID");

                    b.ToTable("Group_Users");
                });

            modelBuilder.Entity("WebApplication5.Il", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Ad")
                        .HasColumnType("text");

                    b.Property<string>("Bolge")
                        .HasColumnType("text");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("No")
                        .HasColumnType("integer");

                    b.Property<int?>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Ils");
                });

            modelBuilder.Entity("WebApplication5.Ilce", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("Il_ID")
                        .HasColumnType("integer");

                    b.Property<int?>("User_ID")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("Il_ID");

                    b.HasIndex("User_ID");

                    b.ToTable("Ilces");
                });

            modelBuilder.Entity("WebApplication5.Imalatci", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("User_ID")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("User_ID");

                    b.ToTable("Imalatcis");
                });

            modelBuilder.Entity("WebApplication5.Kal_Olcum_Sebep", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("User_ID")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("User_ID");

                    b.ToTable("Kal_Olcum_Sebeps");
                });

            modelBuilder.Entity("WebApplication5.Log_Olc_Cihazlar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("Cihaz_Grup_ID")
                        .HasColumnType("integer");

                    b.Property<int>("Imalatci_ID")
                        .HasColumnType("integer");

                    b.Property<int>("Kalip_Yem")
                        .HasColumnType("integer")
                        .HasColumnName("Id");

                    b.Property<int>("Kont_Kap")
                        .HasColumnType("integer")
                        .HasColumnName("Id");

                    b.Property<int>("Kont_Tip_ID")
                        .HasColumnType("integer");

                    b.Property<int?>("User_ID")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("Cihaz_Grup_ID");

                    b.HasIndex("Imalatci_ID");

                    b.HasIndex("Kont_Tip_ID");

                    b.HasIndex("User_ID");

                    b.ToTable("Log_Olc_Cihazlars");
                });

            modelBuilder.Entity("WebApplication5.Logger", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("User_ID")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("User_ID");

                    b.ToTable("Loggers");
                });

            modelBuilder.Entity("WebApplication5.Mail_Ayar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("User_ID")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("User_ID");

                    b.ToTable("Mail_Ayars");
                });

            modelBuilder.Entity("WebApplication5.Mail_Havuzu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("User_ID")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("User_ID");

                    b.ToTable("Mail_Havuzus");
                });

            modelBuilder.Entity("WebApplication5.Olc_Cihaz_Grup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("User_ID")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("User_ID");

                    b.ToTable("Olc_Cihaz_Grups");
                });

            modelBuilder.Entity("WebApplication5.Olc_Cihaz_User_Per", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("Cihaz_ID")
                        .HasColumnType("integer");

                    b.Property<int>("Cihaz_User_ID")
                        .HasColumnType("integer")
                        .HasColumnName("Cihaz User ID");

                    b.Property<int?>("User_ID")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("Cihaz_ID");

                    b.HasIndex("User_ID");

                    b.ToTable("Olc_Cihaz_User_Pers");
                });

            modelBuilder.Entity("WebApplication5.Olc_Cihazlar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("Cihaz_Grup_ID")
                        .HasColumnType("integer");

                    b.Property<int>("Imalatci_ID")
                        .HasColumnType("integer");

                    b.Property<int>("Kalip_Yem")
                        .HasColumnType("integer")
                        .HasColumnName("Id");

                    b.Property<int>("Kont_Kap")
                        .HasColumnType("integer")
                        .HasColumnName("Id");

                    b.Property<int>("Kont_Tip_ID")
                        .HasColumnType("integer");

                    b.Property<int?>("User_ID")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("Cihaz_Grup_ID");

                    b.HasIndex("Imalatci_ID");

                    b.HasIndex("Kont_Tip_ID");

                    b.HasIndex("User_ID");

                    b.ToTable("Olc_Cihazlars");
                });

            modelBuilder.Entity("WebApplication5.Olc_Cihazlar_Aud", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("Rev")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("Rev");

                    b.ToTable("Olc_Cihazlar_Auds");
                });

            modelBuilder.Entity("WebApplication5.Olc_Dogrulama", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("ID")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("Cihaz_ID")
                        .HasColumnType("integer");

                    b.Property<int?>("User_ID")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("Cihaz_ID");

                    b.HasIndex("User_ID");

                    b.ToTable("Olc_Dogrulamas");
                });

            modelBuilder.Entity("WebApplication5.Olc_Iskarta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("Cihaz_Id")
                        .HasColumnType("integer");

                    b.Property<int>("Onay_Red_Eden")
                        .HasColumnType("integer")
                        .HasColumnName("Onay Red Eden");

                    b.Property<int>("Talep_Eden")
                        .HasColumnType("integer")
                        .HasColumnName("Talep Eden");

                    b.Property<int?>("User_ID")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("Cihaz_Id");

                    b.HasIndex("User_ID");

                    b.ToTable("Olc_Iskartas");
                });

            modelBuilder.Entity("WebApplication5.Paramater", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("User_ID")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("User_ID");

                    b.ToTable("Paramaters");
                });

            modelBuilder.Entity("WebApplication5.Permission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("User_ID")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("User_ID");

                    b.ToTable("Permissions");
                });

            modelBuilder.Entity("WebApplication5.Prog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("User_ID")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("User_ID");

                    b.ToTable("Progs");
                });

            modelBuilder.Entity("WebApplication5.Rapor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("User_ID")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("User_ID");

                    b.ToTable("Rapors");
                });

            modelBuilder.Entity("WebApplication5.Revin", b =>
                {
                    b.Property<int>("Rev")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("Id")
                        .HasColumnType("integer");

                    b.HasKey("Rev");

                    b.ToTable("Revins");
                });

            modelBuilder.Entity("WebApplication5.Talep", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("ID")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("Cihaz_ID")
                        .HasColumnType("integer");

                    b.Property<int>("Kalibrasyon_Sebep")
                        .HasColumnType("integer");

                    b.Property<int>("Talep_Eden")
                        .HasColumnType("integer")
                        .HasColumnName("Talep Eden");

                    b.Property<int?>("User_ID")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("Cihaz_ID");

                    b.HasIndex("Kalibrasyon_Sebep");

                    b.HasIndex("User_ID");

                    b.ToTable("Taleps");
                });

            modelBuilder.Entity("WebApplication5.Tanimlar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("User_ID")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("User_ID");

                    b.ToTable("Tanimlars");
                });

            modelBuilder.Entity("WebApplication5.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("Birim")
                        .HasColumnType("integer");

                    b.Property<int>("Customer_ID")
                        .HasColumnType("integer");

                    b.Property<int>("ParentUserId")
                        .HasColumnType("integer");

                    b.Property<int?>("User_ID")
                        .HasColumnType("integer")
                        .HasColumnName("Userid");

                    b.Property<int>("User_Name")
                        .HasColumnType("integer")
                        .HasColumnName("UserName");

                    b.HasKey("Id");

                    b.HasIndex("Birim");

                    b.HasIndex("Customer_ID");

                    b.HasIndex("User_ID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("WebApplication5.Customer", b =>
                {
                    b.HasOne("WebApplication5.User", "User")
                        .WithMany("Customers")
                        .HasForeignKey("User_ID");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebApplication5.Group", b =>
                {
                    b.HasOne("WebApplication5.User", "User")
                        .WithMany("Groups")
                        .HasForeignKey("User_ID");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebApplication5.Group_Permission", b =>
                {
                    b.HasOne("WebApplication5.Group", "Group")
                        .WithMany("Group_Permissions")
                        .HasForeignKey("Group_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication5.Permission", "Permission")
                        .WithMany("Group_Permissions")
                        .HasForeignKey("Permission_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication5.Prog", "Prog")
                        .WithMany("Group_Permissions")
                        .HasForeignKey("Program_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication5.User", "User")
                        .WithMany("Group_Permissions")
                        .HasForeignKey("User_ID");

                    b.Navigation("Group");

                    b.Navigation("Permission");

                    b.Navigation("Prog");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebApplication5.Group_User", b =>
                {
                    b.HasOne("WebApplication5.Group", "Group")
                        .WithMany("Group_Users")
                        .HasForeignKey("Group_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication5.User", "User")
                        .WithMany("Group_Users")
                        .HasForeignKey("User_ID");

                    b.Navigation("Group");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebApplication5.Il", b =>
                {
                    b.HasOne("WebApplication5.User", null)
                        .WithMany("Ils")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("WebApplication5.Ilce", b =>
                {
                    b.HasOne("WebApplication5.Il", "Il")
                        .WithMany("Ilces")
                        .HasForeignKey("Il_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication5.User", "User")
                        .WithMany("Ilces")
                        .HasForeignKey("User_ID");

                    b.Navigation("Il");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebApplication5.Imalatci", b =>
                {
                    b.HasOne("WebApplication5.User", "User")
                        .WithMany("Imalatcis")
                        .HasForeignKey("User_ID");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebApplication5.Kal_Olcum_Sebep", b =>
                {
                    b.HasOne("WebApplication5.User", "User")
                        .WithMany("Kal_Olcum_Sebeps")
                        .HasForeignKey("User_ID");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebApplication5.Log_Olc_Cihazlar", b =>
                {
                    b.HasOne("WebApplication5.Olc_Cihaz_Grup", "Olc_Cihaz_Grup")
                        .WithMany("Log_Olc_Cihazlars")
                        .HasForeignKey("Cihaz_Grup_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication5.Imalatci", "Imalatci")
                        .WithMany("Log_Olc_Cihazlars")
                        .HasForeignKey("Imalatci_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication5.Tanimlar", "Tanimlar")
                        .WithMany("Log_Olc_Cihazlars")
                        .HasForeignKey("Kont_Tip_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication5.User", "User")
                        .WithMany("Log_Olc_Cihazlars")
                        .HasForeignKey("User_ID");

                    b.Navigation("Imalatci");

                    b.Navigation("Olc_Cihaz_Grup");

                    b.Navigation("Tanimlar");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebApplication5.Logger", b =>
                {
                    b.HasOne("WebApplication5.User", "User")
                        .WithMany("Loggers")
                        .HasForeignKey("User_ID");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebApplication5.Mail_Ayar", b =>
                {
                    b.HasOne("WebApplication5.User", "User")
                        .WithMany("Mail_Ayars")
                        .HasForeignKey("User_ID");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebApplication5.Mail_Havuzu", b =>
                {
                    b.HasOne("WebApplication5.User", "User")
                        .WithMany("Mail_Havuzus")
                        .HasForeignKey("User_ID");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebApplication5.Olc_Cihaz_Grup", b =>
                {
                    b.HasOne("WebApplication5.User", "User")
                        .WithMany("Olc_Cihaz_Grups")
                        .HasForeignKey("User_ID");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebApplication5.Olc_Cihaz_User_Per", b =>
                {
                    b.HasOne("WebApplication5.Olc_Cihazlar", "Olc_Cihazlar")
                        .WithMany("Olc_Cihaz_User_Pers")
                        .HasForeignKey("Cihaz_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication5.User", "User")
                        .WithMany("Olc_Cihaz_User_Pers")
                        .HasForeignKey("User_ID");

                    b.Navigation("Olc_Cihazlar");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebApplication5.Olc_Cihazlar", b =>
                {
                    b.HasOne("WebApplication5.Olc_Cihaz_Grup", "Olc_Cihaz_Grup")
                        .WithMany("Olc_Cihazlars")
                        .HasForeignKey("Cihaz_Grup_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication5.Imalatci", "Imalatci")
                        .WithMany("Olc_Cihazlars")
                        .HasForeignKey("Imalatci_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication5.Tanimlar", "Kont_Tip")
                        .WithMany("Olc_Cihazlars")
                        .HasForeignKey("Kont_Tip_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication5.User", "User")
                        .WithMany("Olc_Cihazlars")
                        .HasForeignKey("User_ID");

                    b.Navigation("Imalatci");

                    b.Navigation("Kont_Tip");

                    b.Navigation("Olc_Cihaz_Grup");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebApplication5.Olc_Cihazlar_Aud", b =>
                {
                    b.HasOne("WebApplication5.Revin", "Revin")
                        .WithMany("Olc_Cihazlar_Auds")
                        .HasForeignKey("Rev")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Revin");
                });

            modelBuilder.Entity("WebApplication5.Olc_Dogrulama", b =>
                {
                    b.HasOne("WebApplication5.Olc_Cihazlar", "Olc_Cihazlar")
                        .WithMany("Olc_Dogrulamas")
                        .HasForeignKey("Cihaz_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication5.User", "User")
                        .WithMany("Olc_Dogrulamas")
                        .HasForeignKey("User_ID");

                    b.Navigation("Olc_Cihazlar");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebApplication5.Olc_Iskarta", b =>
                {
                    b.HasOne("WebApplication5.Olc_Cihazlar", "Olc_Cihazlar")
                        .WithMany("Olc_Iskartas")
                        .HasForeignKey("Cihaz_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication5.User", "User")
                        .WithMany("Olc_Iskartas")
                        .HasForeignKey("User_ID");

                    b.Navigation("Olc_Cihazlar");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebApplication5.Paramater", b =>
                {
                    b.HasOne("WebApplication5.User", "User")
                        .WithMany("Paramaters")
                        .HasForeignKey("User_ID");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebApplication5.Permission", b =>
                {
                    b.HasOne("WebApplication5.User", "User")
                        .WithMany("Permissions")
                        .HasForeignKey("User_ID");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebApplication5.Prog", b =>
                {
                    b.HasOne("WebApplication5.User", "User")
                        .WithMany("Progs")
                        .HasForeignKey("User_ID");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebApplication5.Rapor", b =>
                {
                    b.HasOne("WebApplication5.User", "User")
                        .WithMany("Rapors")
                        .HasForeignKey("User_ID");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebApplication5.Talep", b =>
                {
                    b.HasOne("WebApplication5.Olc_Cihazlar", "Olc_Cihazlar")
                        .WithMany("Taleps")
                        .HasForeignKey("Cihaz_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication5.Kal_Olcum_Sebep", "Kal_Olcum_Sebep")
                        .WithMany("Taleps")
                        .HasForeignKey("Kalibrasyon_Sebep")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication5.User", "User")
                        .WithMany("Taleps")
                        .HasForeignKey("User_ID");

                    b.Navigation("Kal_Olcum_Sebep");

                    b.Navigation("Olc_Cihazlar");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebApplication5.Tanimlar", b =>
                {
                    b.HasOne("WebApplication5.User", "User")
                        .WithMany("Tanimlars")
                        .HasForeignKey("User_ID");

                    b.Navigation("User");
                });

            modelBuilder.Entity("WebApplication5.User", b =>
                {
                    b.HasOne("WebApplication5.Tanimlar", "Tanimlar")
                        .WithMany("Users")
                        .HasForeignKey("Birim")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication5.Customer", "Customer")
                        .WithMany("Users")
                        .HasForeignKey("Customer_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication5.User", "Parent")
                        .WithMany("Children")
                        .HasForeignKey("User_ID");

                    b.Navigation("Customer");

                    b.Navigation("Parent");

                    b.Navigation("Tanimlar");
                });

            modelBuilder.Entity("WebApplication5.Customer", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("WebApplication5.Group", b =>
                {
                    b.Navigation("Group_Permissions");

                    b.Navigation("Group_Users");
                });

            modelBuilder.Entity("WebApplication5.Il", b =>
                {
                    b.Navigation("Ilces");
                });

            modelBuilder.Entity("WebApplication5.Imalatci", b =>
                {
                    b.Navigation("Log_Olc_Cihazlars");

                    b.Navigation("Olc_Cihazlars");
                });

            modelBuilder.Entity("WebApplication5.Kal_Olcum_Sebep", b =>
                {
                    b.Navigation("Taleps");
                });

            modelBuilder.Entity("WebApplication5.Olc_Cihaz_Grup", b =>
                {
                    b.Navigation("Log_Olc_Cihazlars");

                    b.Navigation("Olc_Cihazlars");
                });

            modelBuilder.Entity("WebApplication5.Olc_Cihazlar", b =>
                {
                    b.Navigation("Olc_Cihaz_User_Pers");

                    b.Navigation("Olc_Dogrulamas");

                    b.Navigation("Olc_Iskartas");

                    b.Navigation("Taleps");
                });

            modelBuilder.Entity("WebApplication5.Permission", b =>
                {
                    b.Navigation("Group_Permissions");
                });

            modelBuilder.Entity("WebApplication5.Prog", b =>
                {
                    b.Navigation("Group_Permissions");
                });

            modelBuilder.Entity("WebApplication5.Revin", b =>
                {
                    b.Navigation("Olc_Cihazlar_Auds");
                });

            modelBuilder.Entity("WebApplication5.Tanimlar", b =>
                {
                    b.Navigation("Log_Olc_Cihazlars");

                    b.Navigation("Olc_Cihazlars");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("WebApplication5.User", b =>
                {
                    b.Navigation("Children");

                    b.Navigation("Customers");

                    b.Navigation("Group_Permissions");

                    b.Navigation("Group_Users");

                    b.Navigation("Groups");

                    b.Navigation("Ilces");

                    b.Navigation("Ils");

                    b.Navigation("Imalatcis");

                    b.Navigation("Kal_Olcum_Sebeps");

                    b.Navigation("Log_Olc_Cihazlars");

                    b.Navigation("Loggers");

                    b.Navigation("Mail_Ayars");

                    b.Navigation("Mail_Havuzus");

                    b.Navigation("Olc_Cihaz_Grups");

                    b.Navigation("Olc_Cihaz_User_Pers");

                    b.Navigation("Olc_Cihazlars");

                    b.Navigation("Olc_Dogrulamas");

                    b.Navigation("Olc_Iskartas");

                    b.Navigation("Paramaters");

                    b.Navigation("Permissions");

                    b.Navigation("Progs");

                    b.Navigation("Rapors");

                    b.Navigation("Taleps");

                    b.Navigation("Tanimlars");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Online2.DAL.Concrete.Context;

#nullable disable

namespace Online2.DAL.Migrations
{
    [DbContext(typeof(DiyetDbContext))]
    partial class DiyetDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Online2.Entity.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<DateTime>("CreateOn")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("UpdateOn")
                        .HasColumnType("datetime");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CategoryName")
                        .IsUnique();

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryName = "Süt Grubu",
                            CreateOn = new DateTime(2022, 12, 20, 23, 27, 6, 958, DateTimeKind.Local).AddTicks(4004),
                            isActive = true
                        },
                        new
                        {
                            Id = 2,
                            CategoryName = "Et Grubu",
                            CreateOn = new DateTime(2022, 12, 20, 23, 27, 6, 958, DateTimeKind.Local).AddTicks(4011),
                            isActive = true
                        },
                        new
                        {
                            Id = 3,
                            CategoryName = "KuruBaklagil Grubu",
                            CreateOn = new DateTime(2022, 12, 20, 23, 27, 6, 958, DateTimeKind.Local).AddTicks(4013),
                            isActive = true
                        },
                        new
                        {
                            Id = 4,
                            CategoryName = "Ekmek Grubu",
                            CreateOn = new DateTime(2022, 12, 20, 23, 27, 6, 958, DateTimeKind.Local).AddTicks(4015),
                            isActive = true
                        },
                        new
                        {
                            Id = 5,
                            CategoryName = "Sebze Grubu",
                            CreateOn = new DateTime(2022, 12, 20, 23, 27, 6, 958, DateTimeKind.Local).AddTicks(4017),
                            isActive = true
                        },
                        new
                        {
                            Id = 6,
                            CategoryName = "Meyve Grubu",
                            CreateOn = new DateTime(2022, 12, 20, 23, 27, 6, 958, DateTimeKind.Local).AddTicks(4019),
                            isActive = true
                        },
                        new
                        {
                            Id = 7,
                            CategoryName = "Yağ Grubu",
                            CreateOn = new DateTime(2022, 12, 20, 23, 27, 6, 958, DateTimeKind.Local).AddTicks(4021),
                            isActive = true
                        },
                        new
                        {
                            Id = 8,
                            CategoryName = "Tatlı Grubu",
                            CreateOn = new DateTime(2022, 12, 20, 23, 27, 6, 958, DateTimeKind.Local).AddTicks(4024),
                            isActive = true
                        },
                        new
                        {
                            Id = 9,
                            CategoryName = "Kuruyemiş Grubu",
                            CreateOn = new DateTime(2022, 12, 20, 23, 27, 6, 958, DateTimeKind.Local).AddTicks(4026),
                            isActive = true
                        });
                });

            modelBuilder.Entity("Online2.Entity.Food", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<double>("Calorie")
                        .HasPrecision(4)
                        .HasColumnType("float(4)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateOn")
                        .HasColumnType("datetime");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("FoodName")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<DateTime?>("UpdateOn")
                        .HasColumnType("datetime");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("FoodName")
                        .IsUnique();

                    b.ToTable("Foods");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Calorie = 11400.0,
                            CategoryId = 1,
                            CreateOn = new DateTime(2022, 12, 20, 23, 27, 6, 958, DateTimeKind.Local).AddTicks(9127),
                            Description = "1 su bardağı,200 ml",
                            FoodName = "Süt",
                            isActive = true
                        },
                        new
                        {
                            Id = 2,
                            Calorie = 69000.0,
                            CategoryId = 2,
                            CreateOn = new DateTime(2022, 12, 20, 23, 27, 6, 958, DateTimeKind.Local).AddTicks(9136),
                            Description = "1 köfte, 30gr",
                            FoodName = "Kıyma",
                            isActive = true
                        },
                        new
                        {
                            Id = 3,
                            Calorie = 80000.0,
                            CategoryId = 3,
                            CreateOn = new DateTime(2022, 12, 20, 23, 27, 6, 958, DateTimeKind.Local).AddTicks(9138),
                            Description = "4 yemek kaşığı, 25gr",
                            FoodName = "Mercimek",
                            isActive = true
                        },
                        new
                        {
                            Id = 4,
                            Calorie = 68000.0,
                            CategoryId = 4,
                            CreateOn = new DateTime(2022, 12, 20, 23, 27, 6, 958, DateTimeKind.Local).AddTicks(9141),
                            Description = "3 yemek kaşığı, 50gr",
                            FoodName = "Makarna",
                            isActive = true
                        },
                        new
                        {
                            Id = 5,
                            Calorie = 25000.0,
                            CategoryId = 5,
                            CreateOn = new DateTime(2022, 12, 20, 23, 27, 6, 958, DateTimeKind.Local).AddTicks(9143),
                            Description = "4 yemek kaşığı, 200gr",
                            FoodName = "Brokoli(Pişmiş)",
                            isActive = true
                        },
                        new
                        {
                            Id = 6,
                            Calorie = 60000.0,
                            CategoryId = 6,
                            CreateOn = new DateTime(2022, 12, 20, 23, 27, 6, 958, DateTimeKind.Local).AddTicks(9145),
                            Description = "1 küçük boy, 120gr",
                            FoodName = "Elma",
                            isActive = true
                        },
                        new
                        {
                            Id = 7,
                            Calorie = 45000.0,
                            CategoryId = 7,
                            CreateOn = new DateTime(2022, 12, 20, 23, 27, 6, 958, DateTimeKind.Local).AddTicks(9148),
                            Description = "1 tatlı kaşığı, 5gr",
                            FoodName = "Tereyağ",
                            isActive = true
                        },
                        new
                        {
                            Id = 8,
                            Calorie = 68000.0,
                            CategoryId = 8,
                            CreateOn = new DateTime(2022, 12, 20, 23, 27, 6, 958, DateTimeKind.Local).AddTicks(9150),
                            Description = "1 yemek kaşığı, 30gr",
                            FoodName = "Bal",
                            isActive = true
                        },
                        new
                        {
                            Id = 9,
                            Calorie = 45000.0,
                            CategoryId = 9,
                            CreateOn = new DateTime(2022, 12, 20, 23, 27, 6, 958, DateTimeKind.Local).AddTicks(9152),
                            Description = "2 adet, 8gr",
                            FoodName = "Ceviz içi",
                            isActive = true
                        });
                });

            modelBuilder.Entity("Online2.Entity.Meal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreateOn")
                        .HasColumnType("datetime");

                    b.Property<string>("MealName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("UpdateOn")
                        .HasColumnType("datetime");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("MealName")
                        .IsUnique();

                    b.ToTable("Meals");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateOn = new DateTime(2022, 12, 20, 23, 27, 6, 958, DateTimeKind.Local).AddTicks(145),
                            MealName = "Kahvaltı",
                            isActive = true
                        },
                        new
                        {
                            Id = 2,
                            CreateOn = new DateTime(2022, 12, 20, 23, 27, 6, 958, DateTimeKind.Local).AddTicks(152),
                            MealName = "Öğle Yemeği",
                            isActive = true
                        },
                        new
                        {
                            Id = 3,
                            CreateOn = new DateTime(2022, 12, 20, 23, 27, 6, 958, DateTimeKind.Local).AddTicks(154),
                            MealName = "Akşam Yemeği",
                            isActive = true
                        });
                });

            modelBuilder.Entity("Online2.Entity.MealFood", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreateOn")
                        .HasColumnType("datetime");

                    b.Property<int>("FoodId")
                        .HasColumnType("int");

                    b.Property<int>("MealId")
                        .HasColumnType("int");

                    b.Property<double>("Portion")
                        .HasColumnType("float");

                    b.Property<DateTime?>("UpdateOn")
                        .HasColumnType("datetime");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("FoodId");

                    b.HasIndex("MealId");

                    b.HasIndex("UserId");

                    b.ToTable("MealFoods");
                });

            modelBuilder.Entity("Online2.Entity.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreateOn")
                        .HasColumnType("datetime");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateOn")
                        .HasColumnType("datetime");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(130)
                        .HasColumnType("nvarchar(130)");

                    b.Property<string>("UserTypes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateOn = new DateTime(2022, 12, 20, 23, 27, 6, 957, DateTimeKind.Local).AddTicks(5496),
                            Email = "admin@gmail.com",
                            Password = "123456",
                            UserName = "Admin",
                            UserTypes = "Admin",
                            isActive = true
                        });
                });

            modelBuilder.Entity("Online2.Entity.Food", b =>
                {
                    b.HasOne("Online2.Entity.Category", "Category")
                        .WithMany("Foods")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Online2.Entity.MealFood", b =>
                {
                    b.HasOne("Online2.Entity.Food", "Food")
                        .WithMany("MealFoods")
                        .HasForeignKey("FoodId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Online2.Entity.Meal", "Meal")
                        .WithMany("MealFoods")
                        .HasForeignKey("MealId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Online2.Entity.User", "User")
                        .WithMany("MealFoods")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Food");

                    b.Navigation("Meal");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Online2.Entity.Category", b =>
                {
                    b.Navigation("Foods");
                });

            modelBuilder.Entity("Online2.Entity.Food", b =>
                {
                    b.Navigation("MealFoods");
                });

            modelBuilder.Entity("Online2.Entity.Meal", b =>
                {
                    b.Navigation("MealFoods");
                });

            modelBuilder.Entity("Online2.Entity.User", b =>
                {
                    b.Navigation("MealFoods");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using System;
using DistEquipment.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DistEquipment.Server.Migrations
{
    [DbContext(typeof(AppDBcontext))]
    partial class AppDBcontextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DistEquipment.Shared.Calculator", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Hours")
                        .HasColumnType("int");

                    b.Property<double>("PriceDistillar")
                        .HasColumnType("float");

                    b.Property<double>("PriceSolvent")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Calculators");
                });

            modelBuilder.Entity("DistEquipment.Shared.Category", b =>
                {
                    b.Property<int>("IdCategory")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCategory"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdCategory");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            IdCategory = 1,
                            Description = "Оборудование для регенерации растворителей",
                            Img = "oi oi-cog",
                            Name = "Дистилляторы",
                            Url = "distillars"
                        },
                        new
                        {
                            IdCategory = 2,
                            Description = "Термопакеты для сбора отработанного остатка дистилляции",
                            Img = "oi oi-droplet",
                            Name = "Пакеты Rec-Bag",
                            Url = "Rec-Bag"
                        });
                });

            modelBuilder.Entity("DistEquipment.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("BigDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfSaller")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateOfUpdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Images")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsClose")
                        .HasColumnType("bit");

                    b.Property<bool>("IsOpen")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SmallDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("SpesialPrice")
                        .HasColumnType("Decimal(10,2)");

                    b.Property<string>("URL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Views")
                        .HasColumnType("int");

                    b.Property<int?>("Volume")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BigDescription = "Дистиллятор растворителей ULtraCliean 20EX на 20 литров обладает компактным размером и эргономичным дизайном.На панели приборов удобно расположены тумблер для выбора температурного режима и таймер дистилляции. LED дисплей позволяет отображать оставшееся врем перегонки,общее врем работы дистиллятора. Специальный индикатор показывает в какой промежуток времени идет нагрев масла.",
                            CategoryId = 1,
                            DateOfSaller = new DateTime(2022, 10, 24, 15, 2, 59, 772, DateTimeKind.Local).AddTicks(3715),
                            Images = "https://www.solventrecyclingmachine.com/wp-content/uploads/2021/11/standard-solvent-recycling-unit.png",
                            IsClose = false,
                            IsOpen = false,
                            Name = "Дистиллятор ULtraCliean 20EX",
                            SmallDescription = "Установка для дистилляции загрязненных растворителей ULtraCliean 20EX с объемом загрузки 20 литров",
                            URL = "UltraClean20Ex",
                            Views = 0,
                            Volume = 20
                        },
                        new
                        {
                            Id = 2,
                            BigDescription = "Пакеты Rec-Bag для дистиллятора ULtraCliean 20EX имеют плотную структуру, что позволяет их использовать при аккуратной работе более одного раза. Данные термопакеты обладают высокой термостойкостью, до 200 градусов Цельсия. Пакеты рек бэг изготовлены из специальных термостойких пластиков с гомогенной структурой.Термопакеты \"Rec Bag\" поставляются упаковкой по 50 штук. Использование термопакетов rec-bag актуально при дистилляции растворителей загрязненных красками, лаками, любыми твердыми частицами.",
                            CategoryId = 2,
                            DateOfSaller = new DateTime(2022, 10, 24, 15, 2, 59, 772, DateTimeKind.Local).AddTicks(3797),
                            Images = "Img/rec-bag30.png",
                            IsClose = false,
                            IsOpen = false,
                            Name = "Пакеты Rec-Bag 20 литров",
                            SmallDescription = "Пакеты Rec-Bag для дистиллятора ULtraCliean 20EX",
                            URL = "RecBag20Ex",
                            Views = 0
                        });
                });

            modelBuilder.Entity("DistEquipment.Shared.ProductModel", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("ProductOptionId")
                        .HasColumnType("int");

                    b.Property<decimal?>("OldPrice")
                        .HasColumnType("Decimal(10,2)");

                    b.Property<decimal?>("Price")
                        .HasColumnType("Decimal(10,2)");

                    b.HasKey("ProductId", "ProductOptionId");

                    b.HasIndex("ProductOptionId");

                    b.ToTable("ProductModel");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            ProductOptionId = 1,
                            OldPrice = 490000.00m,
                            Price = 400000.00m
                        },
                        new
                        {
                            ProductId = 1,
                            ProductOptionId = 2,
                            OldPrice = 690000.00m,
                            Price = 560000.00m
                        },
                        new
                        {
                            ProductId = 1,
                            ProductOptionId = 3,
                            OldPrice = 570000.00m,
                            Price = 490000.00m
                        },
                        new
                        {
                            ProductId = 2,
                            ProductOptionId = 4,
                            OldPrice = 19000.00m,
                            Price = 15000.00m
                        });
                });

            modelBuilder.Entity("DistEquipment.Shared.ProductOption", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProductOptions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Без опций"
                        },
                        new
                        {
                            Id = 2,
                            Name = "С генератором вакуума"
                        },
                        new
                        {
                            Id = 3,
                            Name = "С автоматической загрузкой"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Упаковка 50 шт."
                        });
                });

            modelBuilder.Entity("DistEquipment.Shared.Solvent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Price")
                        .HasColumnType("Decimal(10,2)");

                    b.HasKey("Id");

                    b.ToTable("Solvents");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Ацетон",
                            Price = 240.00m
                        },
                        new
                        {
                            Id = 2,
                            Name = "646",
                            Price = 220.00m
                        },
                        new
                        {
                            Id = 3,
                            Name = "650",
                            Price = 340.00m
                        },
                        new
                        {
                            Id = 4,
                            Name = "647",
                            Price = 210.00m
                        },
                        new
                        {
                            Id = 5,
                            Name = "Универсальный",
                            Price = 290.00m
                        },
                        new
                        {
                            Id = 6,
                            Name = "Уайт-Спирит",
                            Price = 210.00m
                        },
                        new
                        {
                            Id = 7,
                            Name = "Нефрас 80/120",
                            Price = 220.00m
                        },
                        new
                        {
                            Id = 8,
                            Name = "Нефрас 130/150",
                            Price = 230.00m
                        },
                        new
                        {
                            Id = 9,
                            Name = "Обезжириватель",
                            Price = 250.00m
                        },
                        new
                        {
                            Id = 10,
                            Name = "Сольвент",
                            Price = 190.00m
                        },
                        new
                        {
                            Id = 11,
                            Name = "Ксилол",
                            Price = 240.00m
                        },
                        new
                        {
                            Id = 12,
                            Name = "Толуол",
                            Price = 240.00m
                        },
                        new
                        {
                            Id = 13,
                            Name = "Бутилацетат",
                            Price = 200.00m
                        },
                        new
                        {
                            Id = 14,
                            Name = "Этилацетат",
                            Price = 210.00m
                        },
                        new
                        {
                            Id = 15,
                            Name = "Смывка флексографии",
                            Price = 200.00m
                        },
                        new
                        {
                            Id = 16,
                            Name = "Спирты",
                            Price = 250.00m
                        },
                        new
                        {
                            Id = 17,
                            Name = "Р4(Р5)",
                            Price = 220.00m
                        },
                        new
                        {
                            Id = 18,
                            Name = "Дихлорметан",
                            Price = 600.00m
                        });
                });

            modelBuilder.Entity("DistEquipment.Shared.State", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateOfView")
                        .HasColumnType("datetime2");

                    b.Property<int>("Views")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("States");
                });

            modelBuilder.Entity("DistEquipment.Shared.Product", b =>
                {
                    b.HasOne("DistEquipment.Shared.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("DistEquipment.Shared.ProductModel", b =>
                {
                    b.HasOne("DistEquipment.Shared.Product", "Product")
                        .WithMany("ProductModels")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DistEquipment.Shared.ProductOption", "ProductOption")
                        .WithMany()
                        .HasForeignKey("ProductOptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("ProductOption");
                });

            modelBuilder.Entity("DistEquipment.Shared.Product", b =>
                {
                    b.Navigation("ProductModels");
                });
#pragma warning restore 612, 618
        }
    }
}

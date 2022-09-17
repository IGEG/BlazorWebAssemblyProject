﻿// <auto-generated />
using System;
using DistEquipment.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DistEquipment.Server.Migrations
{
    [DbContext(typeof(AppDBcontext))]
    [Migration("20220915174915_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

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

                    b.Property<decimal?>("OldPrice")
                        .HasColumnType("Decimal(10,2)");

                    b.Property<decimal?>("Price")
                        .HasColumnType("Decimal(10,2)");

                    b.Property<string>("SmallDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("SpesialPrice")
                        .HasColumnType("Decimal(10,2)");

                    b.Property<string>("URL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BigDescription = "Дистиллятор растворителей ULtraCliean 20EX на 20 литров обладает компактным размером и эргономичным дизайном.На панели приборов удобно расположены тумблер для выбора температурного режима и таймер дистилляции. LED дисплей позволяет отображать оставшееся врем перегонки,общее врем работы дистиллятора. Специальный индикатор показывает в какой промежуток времени идет нагрев масла.",
                            CategoryId = 1,
                            DateOfSaller = new DateTime(2022, 9, 15, 20, 49, 12, 762, DateTimeKind.Local).AddTicks(8140),
                            Images = "https://www.solventrecyclingmachine.com/wp-content/uploads/2021/11/standard-solvent-recycling-unit.png",
                            IsClose = false,
                            IsOpen = false,
                            Name = "Дистиллятор ULtraCliean 20EX",
                            OldPrice = 490000.00m,
                            Price = 400000.00m,
                            SmallDescription = "Установка для дистилляции загрязненных растворителей ULtraCliean 20EX с объемом загрузки 20 литров",
                            URL = "UltraClean20Ex"
                        },
                        new
                        {
                            Id = 2,
                            BigDescription = "Пакеты Rec-Bag для дистиллятора ULtraCliean 20EX имеют плотную структуру, что позволяет их использовать при аккуратной работе более одного раза. Данные термопакеты обладают высокой термостойкостью, до 200 градусов Цельсия. Пакеты рек бэг изготовлены из специальных термостойких пластиков с гомогенной структурой.Термопакеты \"Rec Bag\" поставляются упаковкой по 50 штук. Использование термопакетов rec-bag актуально при дистилляции растворителей загрязненных красками, лаками, любыми твердыми частицами.",
                            CategoryId = 2,
                            DateOfSaller = new DateTime(2022, 9, 15, 20, 49, 12, 762, DateTimeKind.Local).AddTicks(8314),
                            Images = "https://developmentbeccaince896.zapwp.com/q:intelligent/retina:false/webp:false/w:1/url:https://www.beccainc.com/wp-content/uploads/2015/07/Recycling-Bag.jpg",
                            IsClose = false,
                            IsOpen = false,
                            Name = "Пакеты Rec-Bag 20 литров",
                            OldPrice = 19000.00m,
                            Price = 15000.00m,
                            SmallDescription = "Пакеты Rec-Bag для дистиллятора ULtraCliean 20EX",
                            URL = "RecBag20Ex"
                        });
                });

            modelBuilder.Entity("DistEquipment.Shared.Product", b =>
                {
                    b.HasOne("DistEquipment.Shared.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("DistEquipment.Shared.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
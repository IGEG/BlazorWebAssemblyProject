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
                .HasAnnotation("ProductVersion", "6.0.10")
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

            modelBuilder.Entity("DistEquipment.Shared.News", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("BigDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SmallDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UrlName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("News");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BigDescription = "В первую очередь на производительность установки дистилляции растворителя влияет продолжающееся накопление шлама в дистилляционной емкости, длительное отсутствие внимания и устаревание электрических компонентов.\r\nПодобно автомобилю и наиболее важному оборудованию, система регенерации растворителей на месте требует регулярного технического обслуживания, ежедневного, еженедельного, ежемесячного, ежеквартального и ежегодного. Также как и в случае с автомобилем, производительность машины будет снижена, если некоторые элементы технического обслуживания не будут устранены, когда это необходимо. Без надлежащего технического обслуживания проблемы с производительностью могут привести к дополнительным расходам, которые можно было бы предотвратить.\r\nПроблемы нагрева термального масла\r\nДистилляционная установка требует источника нагрева, достаточно сильного, чтобы преодолеть физические свойства перегоняемого растворителя. Наиболее распространенными источниками нагрева являются диатермическое  масло с электрическим нагревом или паровая рубашка.\r\nДиатермическое масло необходимо заменять ежегодно. Несвоевременная замена теплового масла приведет к нагарообразованию масляной рубашки.\r\nНагар накапливается как на боковых стенках бака, так и на нагревательных элементах. Отложения на боковых стенках действуют как изолятор, препятствующий эффективной передаче тепла. Наросты на нагревательных элементах приводят к выходу из строя нагревателя.\r\nНакопление шлама на нагревательных поверхностях\r\nДистилляционная установка будет накапливать осадок на нагревательных поверхностях при постоянном использовании. Скопление шлама на нагревательных поверхностях снижает эффективность нагрева, требуя больше времени для обработки растворителя и больше энергии для работы системы.\r\n\r\nДистиллятор растворителя требует ежедневной очистки поверхности нагрева, по крайней мере, после каждой разгрузки.\r\nНакопление шлама на ненагреваемых поверхностях\r\nСкопление шлама на ненагреваемых поверхностях может привести к загрязнению дистиллята, так как частицы ила улетучиваются с парами растворителя.\r\nПроблемы с электрическими компонентами\r\nУстаревание электрических компонентов также является фактором, негативно влияющим на эффективность дистилляции.\r\nПЛК, усилители, датчики и другие устройства со временем выводятся из употребления производителями. \r\nИногда возможна индивидуальная замена. Тем не менее, часто требуются модификации для размещения компонентов для прямой замены.\r\nУстаревание ПЛК  может потребовать всего нового программного обеспечения или программ для поддержки сменного устройства. Если вы решите использовать неподдерживаемые устройства, они могут ухудшить производительность дистилляции, когда начнутся сбои с более длительным временем выполнения заказа, при поиске метода замены или требуя от операторов обходных путей процесса.\r\nНезапланированные расходы могут увеличиться\r\nПродолжительное использование неэффективной дистилляционной установки влияет на весть процесс перегонки.\r\nВместо того чтобы эффективно очищать ваш растворитель, большое количество растворителя отправляется в отходы и требует покупки увеличенного объема чистого растворителя. Ценное время оператора требуется, чтобы сосредоточиться на дистилляционной установке, а не на других рабочих обязанностях.\r\nДля продолжения работы системы требуется больше времени на техническое обслуживание и трудозатраты. Снижение производительности дистилляционной установки напрямую влияет на общую стоимость работы.\r\nНаши рекомендации.\r\nКак и в случае с автомобилем, невыполнение профилактического и планового технического обслуживания приведет к долгосрочным и потенциально дорогостоящим проблемам с производительностью. \r\nОчистка бака\r\nЕжедневно очищать бак от образований накипи. Таким образом улучшается тепловой обмен между стенками испарительного бака дистиллятора и обрабатываемым растворителем.\r\nКонтроль диатермического масла\r\nКонтролировать в холодном состоянии уровень диатермического масла.\r\nОчистка контура конденсации паров.\r\nПериодически продувать сжатым воздухом с давлением коллектора паров в баке дистиллятора в сторону выхода дистиллята и в обратном направлении для вычистки возможных образований, сформировавшихся в трубопроводе и конденсоре. Периодически производить очистку сжатым воздухом внешней поверхности конденсора\r\nРекомендуется замена диатермического масла после 1000 часов работы. Тип масла: АМТ-300, МТ-300.  При каждой замене диатермического масла необходимо проверить стравливающий воздушный  клапан на крышке.\r\nОчистка нагревательного элемента.\r\nПри эксплуатации дистиллятора на электрическом резисторе происходит налипание \r\nнакипи. Для нормального теплообмена необходимо ежегодно производить его очистку.\r\n",
                            Image = "Img/news/hand-tool.png",
                            SmallDescription = "Почему производительность установки дистилляции растворителя со временем ухудшается?\r\nСуществует несколько распространенных причин снижения производительности установок для дистилляции растворителя. Изучите несколько наиболее распространенных проблем и узнайте, как их можно решить.\r\nИмеется ли на вашем предприятии дистилляционная установка для переработки загрязненных растворителей? Если она есть, то это очень здорово!  Это означает, что вы экономите на расходах при покупке нового растворителя, снижаете плату за утилизацию опасных отходов и заботитесь об окружающей среде!\r\nОднако знаете ли вы, что производительность установки для дистилляции растворителя со временем будет ухудшаться, что в конечном итоге будет стоить вам части сэкономленных средств?\r\nОсновные проблемы с которыми Вы сможете столкнуться при уменьшении  производительности установки дистилляции растворителя.\r\n",
                            Title = "Техниечское обслуживание и проблемы эксплуатации дистилляторов растворителей UltraClean",
                            UrlName = "technichescoe-obsluzhivanie-distillatorov-rastrvoriteley"
                        },
                        new
                        {
                            Id = 2,
                            BigDescription = "Как определить емкость блока регенерации растворителя\r\nПрежде всего, если вы собираетесь начать химическую переработку, вы должны понимать, какие мощности необходимы для переработки. Это, в свою очередь, покажет размер бака, который требуется вашему заводу. Существует 4 параметра, которые необходимо знать  для определения производительности установки регенерации растворителя.\r\nДля начала спросите себя: какой суточный объем  растворителя образуется? Это можно проверить по отходам растворителей, которые в настоящее время перерабатываются и/или вывозятся за пределы предприятия для переработки или утилизации растворителей. Для этого определите, сколько отходов растворителя образуется ежедневно, еженедельно, ежемесячно и/или ежеквартально. Затем проверьте свои цифры, просмотрев актуальную документы об отходах, чтобы убедиться, что ваши данные верны. Еще одна проверка заключается в проверке количества растворителя, приобретенного для очистки.\r\nНапример, допустим, вы считаете, что среднесуточный объем образующихся отходов растворителя составляет 10 литров. Следующим шагом будет просмотр документов, чтобы определить общее количество отработанного растворителя, отгружаемого ежемесячно или ежеквартально. Допустим, ответ — 6 бочек в месяц. Чтобы проверить математику, мы умножим 6 бочек на 200 литров, чтобы получить 1 200 литров в месяц. Затем, чтобы преобразовать это значение в дневной расход, просто разделите 1 200 литров на 22 рабочих дня. Ответ: 54,5 литров отходов, образующихся каждый день. Это тревожный сигнал, так как 54,5 литра в день — это совсем другое число, чем первоначальные 10 литров. Мы рекомендуем вам ознакомиться с документами об отходах, чтобы убедиться в фактической отгрузке отходов.  \r\nПосле определения ваших текущих потребностей в чистящем растворителе вы также должны определить свои будущие потребности. Вам следует обсудить будущие потребности в переработке растворителей с производственным отделом, чтобы спрогнозировать будущие объемы. Установка дистилляции растворителя должна прослужить не менее 5 лет, но обычно служит в пределах 15-20 лет. Это означает, что вы должны смотреть на свои потребности в использовании в течение следующего десятилетия.\r\nСледующим шагом будет определение времени, необходимого для работы установки дистилляции растворителя. Некоторые предприятия предпочитают не включать свои установки по переработке растворителей на ночь или в выходные дни. Тем не менее, с современными технологиями, предоставляемыми нашими установками, вполне возможно эксплуатировать регенератор  24 часа в сутки, 7 дней в неделю. Важно осознавать, что машины нуждаются в техническом обслуживании и ремонте. Просто нереально предполагать, что машина будет работать постоянно. Механические проблемы будут возникать время от времени. Хорошее эмпирическое правило для предприятий, приобретающих дистилляционное оборудование, заключается в том, что время безотказной работы должно составлять 85 %.. Тем не менее, некоторые предприятия будут иметь более высокое время безотказной работы, чем другие. Это связано с тем, что время безотказной работы почти полностью зависит от персонала, в который входят оператор машины, отдел технического обслуживания и руководитель процесса. Когда-то блестящая программа утилизации на месте может измениться за одну ночь, когда сменится оператор или другой ключевой персонал. Еще один важный момент, который следует отметить, заключается в том, что время безотказной работы не будет оставаться постоянным. Когда предприятие впервые внедряет установку дистилляции растворителя, большое внимание уделяется процессу, что приводит к значительному увеличению времени безотказной работы. К сожалению, когда волнение уляжется и наступит реальность повседневной рутинной работы, установка по переработке растворителей, скорее всего, не будет иметь такого же высокого уровня концентрации и внимания. Мы отмечаем это как поучительную историю, чтобы убедиться, что предприятия точно оценивают время безотказной работы.\r\nБыло бы здорово, если бы единственным требованием для поиска идеального регенератора растворителей было количество отходов, которое он перерабатывает за день. Но это не так. Есть два других фактора, которые необходимо учитывать: температура кипения растворителя (растворителей), которые будут извлечены с помощью оборудования для дистилляции растворителя, и процентное содержание загрязняющих веществ в потоке отходов очистки растворителя. Чем выше температура кипения и процентное содержание загрязняющих веществ в растворителе, тем больше времени потребуется машине для обработки отходов. Оба фактора независимо друг от друга влияют на размер устройства, необходимого для объекта. Растворитель с более высокой температурой кипения означает, что для прохождения процесса дистилляции требуется больше энергии. Это приводит к увеличению времени, необходимого для достижения агрегатом правильной температуры, что продлевает цикл восстановления. В то время как более высокое загрязнение означает, что машинам придется чаще сливать остаток, чтобы гарантировать, что материал не станет слишком вязким для обработки. Больше циклов слива означает больше времени.\r\nПодведем итоги.\r\nНадеемся, что эта статья помогла Вам  получить достоверную информацию о том, как вы можете определить идеальную установку для дистилляции растворителя для вашего предприятия. Мы помогли вам понять четыре фактора, которые необходимо учитывать при определении производительности вашей установки по регенерации растворителей: \r\nобъем отходов растворителя,\r\n время работы,\r\n температура кипения\r\n и процент загрязнения. \r\n",
                            Image = "Img/news/help.png",
                            SmallDescription = "Восстановление растворителя на месте проще, чем вы думаете. Но прежде чем вы приобретете дистиллятор, вам необходимо определить мощность, которая потребуется вашему оборудованию. Есть четыре критерия, которые необходимо изучить, чтобы определить требуемую производительность установки по регенерации растворителя: объем отходов растворителя, время работы, температура кипения и процент загрязнения.",
                            Title = "4 основных параметря для выбора дистиллятора",
                            UrlName = "pomosh-v-vibore-distillatora-rastvoriteley"
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
                            DateOfSaller = new DateTime(2022, 11, 2, 20, 43, 1, 814, DateTimeKind.Local).AddTicks(2480),
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
                            DateOfSaller = new DateTime(2022, 11, 2, 20, 43, 1, 814, DateTimeKind.Local).AddTicks(2572),
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

            modelBuilder.Entity("DistEquipment.Shared.Work", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Works");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Count = 1,
                            Name = "Одна смена 8 часов"
                        },
                        new
                        {
                            Id = 2,
                            Count = 2,
                            Name = "Две смены 16 часов"
                        },
                        new
                        {
                            Id = 3,
                            Count = 3,
                            Name = "Непрерывная работа 24 часа"
                        });
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

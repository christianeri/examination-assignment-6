﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApp.Contexts;

#nullable disable

namespace WebApp.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebApp.Models.Entities.BrandEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BrandName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Brands");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BrandName = "Andersson"
                        },
                        new
                        {
                            Id = 2,
                            BrandName = "Weber"
                        },
                        new
                        {
                            Id = 3,
                            BrandName = "Dreame"
                        },
                        new
                        {
                            Id = 4,
                            BrandName = "Beurer"
                        },
                        new
                        {
                            Id = 5,
                            BrandName = "Everest"
                        },
                        new
                        {
                            Id = 6,
                            BrandName = "Asics"
                        },
                        new
                        {
                            Id = 7,
                            BrandName = "Mil-Tec"
                        });
                });

            modelBuilder.Entity("WebApp.Models.Entities.ContactEntity", b =>
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

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Organization")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("WebApp.Models.Entities.ProductEntity", b =>
                {
                    b.Property<string>("ArticleNumber")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("money");

                    b.HasKey("ArticleNumber");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ArticleNumber = "A11",
                            BrandId = 1,
                            Description = "Med Andersson BHS 3.3 får du en kompakt och portabel högtalare med snygga detaljer och LED-ljus. Du kan enkelt ta samtal direkt ur högtalaren med handsfree-funktionen. Koppla din mobil till högtalaren via Bluetooth och börja lyssna!  ",
                            ImageUrl = "pexels-mwabonje-12562635.jpg",
                            Name = "BHS 3.3",
                            Price = 399m
                        },
                        new
                        {
                            ArticleNumber = "A22",
                            BrandId = 1,
                            Description = "De trådlösa hörlurarna är robusta och bekväma, med vadderad huvudbygel och mjuka öronkuddar, och kan utan problem användas flera timmar i sträck.",
                            ImageUrl = "pexels-sound-on-3761020.jpg",
                            Name = "T570 BT",
                            Price = 399m
                        },
                        new
                        {
                            ArticleNumber = "A33",
                            BrandId = 2,
                            Description = "Weber Master-Touch® GBS E-5750 är kolgrillen som förenar den traditionella grillkänslan med nya innovativa funktioner kombinerat med en rejäl dos bekvämlighet. Med det medföljande Gourmet BBQ System-grillgallret kan du laga frukost, tillaga ett långkok eller en frasig pizza ute i det fria. Årets Master-Touch har förbättrad ventilation som gör att du nu kan grilla och röka i en och samma grill, Tuck-Away lockhållare och One-Touch rengöringssystem som gör kolgrillning till vardags så mycket bekvämare.",
                            ImageUrl = "pexels-min-an-1171585.jpg",
                            Name = "Master-Touch® GBS E-5750",
                            Price = 3290m
                        },
                        new
                        {
                            ArticleNumber = "A44",
                            BrandId = 3,
                            Description = "D9 Max från Dreame är en kraftfull robotdammsugare med 4000 Pa i sugkapacitet och en borstlös gummiborste för att säkerställa att allt damm och smuts rensas bort från dina golv!",
                            ImageUrl = "pexels-jens-mahnke-844874.jpg",
                            Name = "D9 Max",
                            Price = 3390m
                        },
                        new
                        {
                            ArticleNumber = "A55",
                            BrandId = 4,
                            Description = "Beurer BM 28 är en helautomatisk blodtrycksmätare för överarmen. Den visar systoliskt och diastoliskt tryck samt puls.",
                            ImageUrl = "pexels-mikhail-nilov-8670204.jpg",
                            Name = "BM 28",
                            Price = 449m
                        },
                        new
                        {
                            ArticleNumber = "A66",
                            BrandId = 5,
                            Description = "Klassiska enlagers-kängor som passar för dig som rör dig i skogen, på leden eller i stan. Utformade med ovandel i Heinen Terracare-skinn och med vattentät, cellgummibotten med Certech 2.0-konstruktion som är både lätt och flexibel. Lundhags Wayfinder-yttersula är tillverkad i mjukt 60 ShA-gummimaterial och ger utmärkt grepp.",
                            ImageUrl = "pexels-aidan-jarrett-718981.jpg",
                            Name = "U Park",
                            Price = 2175m
                        },
                        new
                        {
                            ArticleNumber = "A77",
                            BrandId = 6,
                            Description = "Stabila löparskor med bekväm dämpning, för dig som springer längre pass. Skorna har en specialutformad ovandel i mesh som är ventilerande och som omsluter foten med en mjuk känsla. FlyteFoam-mellansulan ger lätt stötdämpning under löpningen och GEL-teknologin i hälen skapar mjukare landningar och smidigare övergångar.",
                            ImageUrl = "pexels-melvin-buezo-2529148.jpg",
                            Name = "W Gt-1000",
                            Price = 1099m
                        },
                        new
                        {
                            ArticleNumber = "A88",
                            BrandId = 5,
                            Description = "Sandaler med stötdämpande och elastisk naturkorksfotbädd som är fuktavvisande. Sandalerna ger även bra mellanfotsstöd och har djup hälkopp för optimal stabilitet.",
                            ImageUrl = "pexels-mike-bird-112285.jpg",
                            Name = "U Comfort Sandal",
                            Price = 379m
                        },
                        new
                        {
                            ArticleNumber = "A99",
                            BrandId = 7,
                            Description = "Handgjort ansiktsskägg är lämplig för utomhusaktiviteter, överlevnad, alla typer jakt och fiske, så rolig och fantastisk. Dra åt snabbt, lossa eller ta bort skägget med knappfästen, så att ditt ansikte alltid blir varmt och skyddat.",
                            ImageUrl = "tactical-beard-brown.png",
                            Name = "Taktiskt skägg",
                            Price = 249m
                        });
                });

            modelBuilder.Entity("WebApp.Models.Entities.ProductTagEntity", b =>
                {
                    b.Property<string>("ArticleNumber")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("TagId")
                        .HasColumnType("int");

                    b.HasKey("ArticleNumber", "TagId");

                    b.HasIndex("TagId");

                    b.ToTable("ProductTags");

                    b.HasData(
                        new
                        {
                            ArticleNumber = "A11",
                            TagId = 1
                        },
                        new
                        {
                            ArticleNumber = "A11",
                            TagId = 3
                        },
                        new
                        {
                            ArticleNumber = "A22",
                            TagId = 1
                        },
                        new
                        {
                            ArticleNumber = "A22",
                            TagId = 3
                        },
                        new
                        {
                            ArticleNumber = "A33",
                            TagId = 1
                        },
                        new
                        {
                            ArticleNumber = "A44",
                            TagId = 1
                        },
                        new
                        {
                            ArticleNumber = "A44",
                            TagId = 2
                        },
                        new
                        {
                            ArticleNumber = "A55",
                            TagId = 1
                        },
                        new
                        {
                            ArticleNumber = "A66",
                            TagId = 1
                        },
                        new
                        {
                            ArticleNumber = "A77",
                            TagId = 1
                        },
                        new
                        {
                            ArticleNumber = "A88",
                            TagId = 1
                        },
                        new
                        {
                            ArticleNumber = "A88",
                            TagId = 3
                        },
                        new
                        {
                            ArticleNumber = "A99",
                            TagId = 1
                        },
                        new
                        {
                            ArticleNumber = "A99",
                            TagId = 2
                        },
                        new
                        {
                            ArticleNumber = "A99",
                            TagId = 3
                        });
                });

            modelBuilder.Entity("WebApp.Models.Entities.TagEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("TagName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tags");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            TagName = "New"
                        },
                        new
                        {
                            Id = 2,
                            TagName = "Featured"
                        },
                        new
                        {
                            Id = 3,
                            TagName = "Popular"
                        });
                });

            modelBuilder.Entity("WebApp.Models.Entities.ProductTagEntity", b =>
                {
                    b.HasOne("WebApp.Models.Entities.ProductEntity", "Product")
                        .WithMany("ProductTags")
                        .HasForeignKey("ArticleNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApp.Models.Entities.TagEntity", "Tag")
                        .WithMany("ProductTags")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("WebApp.Models.Entities.ProductEntity", b =>
                {
                    b.Navigation("ProductTags");
                });

            modelBuilder.Entity("WebApp.Models.Entities.TagEntity", b =>
                {
                    b.Navigation("ProductTags");
                });
#pragma warning restore 612, 618
        }
    }
}

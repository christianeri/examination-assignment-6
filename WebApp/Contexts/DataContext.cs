using Microsoft.EntityFrameworkCore;
using WebApp.Models.Entities;

namespace WebApp.Contexts
{
    public class DataContext:DbContext
    {
        
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        
        public DbSet<ContactEntity> Contacts { get; set; }
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<ProductTagEntity> ProductTags { get; set; }
        public DbSet<TagEntity> Tags { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductEntity>().HasData(
                new ProductEntity { ArticleNumber = "A11", ImageUrl = "pexels-mwabonje-12562635.jpg", Brand = "Andersson", Category = "Audio", Name = "BHS 3.3", Description = "Med Andersson BHS 3.3 får du en kompakt och portabel högtalare med snygga detaljer och LED-ljus. Du kan enkelt ta samtal direkt ur högtalaren med handsfree-funktionen. Koppla din mobil till högtalaren via Bluetooth och börja lyssna!  ", Price = 399 },
                new ProductEntity { ArticleNumber = "A22", ImageUrl = "pexels-sound-on-3761020.jpg", Brand = "JBL", Category = "Audio", Name = "T570 BT", Description = "De trådlösa hörlurarna är robusta och bekväma, med vadderad huvudbygel och mjuka öronkuddar, och kan utan problem användas flera timmar i sträck.", Price = 399 },
                new ProductEntity { ArticleNumber = "A33", ImageUrl = "pexels-min-an-1171585.jpg", Brand = "Weber", Category = "Home", Name = "Master-Touch® GBS E-5750", Description = "Weber Master-Touch® GBS E-5750 är kolgrillen som förenar den traditionella grillkänslan med nya innovativa funktioner kombinerat med en rejäl dos bekvämlighet. Med det medföljande Gourmet BBQ System-grillgallret kan du laga frukost, tillaga ett långkok eller en frasig pizza ute i det fria. Årets Master-Touch har förbättrad ventilation som gör att du nu kan grilla och röka i en och samma grill, Tuck-Away lockhållare och One-Touch rengöringssystem som gör kolgrillning till vardags så mycket bekvämare.", Price = 3290 },
                new ProductEntity { ArticleNumber = "A44", ImageUrl = "pexels-jens-mahnke-844874.jpg", Brand = "Dreame", Category = "Home", Name = "D9 Max", Description = "D9 Max från Dreame är en kraftfull robotdammsugare med 4000 Pa i sugkapacitet och en borstlös gummiborste för att säkerställa att allt damm och smuts rensas bort från dina golv!", Price = 3390 },
                new ProductEntity { ArticleNumber = "A55", ImageUrl = "pexels-mikhail-nilov-8670204.jpg", Brand = "Beurer", Category = "Home", Name = "BM 28", Description = "Beurer BM 28 är en helautomatisk blodtrycksmätare för överarmen. Den visar systoliskt och diastoliskt tryck samt puls.", Price = 449 },
                new ProductEntity { ArticleNumber = "A66", ImageUrl = "pexels-aidan-jarrett-718981.jpg", Brand = "Lundhags", Category = "Shoes", Name = "U Park", Description = "Klassiska enlagers-kängor som passar för dig som rör dig i skogen, på leden eller i stan. Utformade med ovandel i Heinen Terracare-skinn och med vattentät, cellgummibotten med Certech 2.0-konstruktion som är både lätt och flexibel. Lundhags Wayfinder-yttersula är tillverkad i mjukt 60 ShA-gummimaterial och ger utmärkt grepp.", Price = 2175 },
                new ProductEntity { ArticleNumber = "A77", ImageUrl = "pexels-melvin-buezo-2529148.jpg", Brand = "Asics", Category = "Shoes", Name = "W Gt-1000", Description = "Stabila löparskor med bekväm dämpning, för dig som springer längre pass. Skorna har en specialutformad ovandel i mesh som är ventilerande och som omsluter foten med en mjuk känsla. FlyteFoam-mellansulan ger lätt stötdämpning under löpningen och GEL-teknologin i hälen skapar mjukare landningar och smidigare övergångar.", Price = 1099 },
                new ProductEntity { ArticleNumber = "A88", ImageUrl = "pexels-mike-bird-112285.jpg", Brand = "Everest", Category = "Shoes", Name = "U Comfort Sandal", Description = "Sandaler med stötdämpande och elastisk naturkorksfotbädd som är fuktavvisande. Sandalerna ger även bra mellanfotsstöd och har djup hälkopp för optimal stabilitet.", Price = 379 },
                new ProductEntity { ArticleNumber = "A99", ImageUrl = "tactical-beard-brown.png", Brand = "Mil-Tec", Category = "Outdoor", Name = "Taktiskt skägg", Description = "Handgjort ansiktsskägg är lämplig för utomhusaktiviteter, överlevnad, alla typer jakt och fiske, så rolig och fantastisk. Dra åt snabbt, lossa eller ta bort skägget med knappfästen, så att ditt ansikte alltid blir varmt och skyddat.", Price = 249 }
            );

            modelBuilder.Entity<TagEntity>().HasData(
                new TagEntity {Id = 1, TagName = "New"},                
                new TagEntity {Id = 2, TagName = "Featured" },
                new TagEntity {Id = 3, TagName = "Popular" }
            );            
            
            modelBuilder.Entity<ProductTagEntity>().HasData(
                new ProductTagEntity { ArticleNumber = "A11", TagId = 1},                
                new ProductTagEntity { ArticleNumber = "A11", TagId = 3},                
                new ProductTagEntity { ArticleNumber = "A22", TagId = 1},
                new ProductTagEntity { ArticleNumber = "A22", TagId = 3},
                new ProductTagEntity { ArticleNumber = "A33", TagId = 1},
                new ProductTagEntity { ArticleNumber = "A44", TagId = 1},
                new ProductTagEntity { ArticleNumber = "A44", TagId = 2},
                new ProductTagEntity { ArticleNumber = "A55", TagId = 1},
                new ProductTagEntity { ArticleNumber = "A66", TagId = 1},
                new ProductTagEntity { ArticleNumber = "A77", TagId = 1},
                new ProductTagEntity { ArticleNumber = "A88", TagId = 1},
                new ProductTagEntity { ArticleNumber = "A88", TagId = 3},
                new ProductTagEntity { ArticleNumber = "A99", TagId = 1},
                new ProductTagEntity { ArticleNumber = "A99", TagId = 2},
                new ProductTagEntity { ArticleNumber = "A99", TagId = 3}
            );
        }
    }
}

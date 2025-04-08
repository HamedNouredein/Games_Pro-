

namespace Games_Pro.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options)
            :base(options) 
        {
                
        }
        public DbSet<Game> Games { get; set; }
        public DbSet<Category> Categorys { get; set; }
        public DbSet<GameDevice> GameDevics { get; set; }
        public DbSet<Device> Devices { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasData(new Category[]
                {
                    new Category{Id=1,Name="Sports"},
                    new Category{Id=2,Name="Actions"},
                    new Category{Id=3,Name="Music"},
                    new Category{Id=4,Name="Pazzl"},
                    new Category{Id=5,Name="Fighting"},
                    new Category{Id=6,Name="Films"}
                });
            modelBuilder.Entity<Device>()
                .HasData(new Device[]
                {
                    new Device{Id=1,Name="playstation",Icon="bi bi-playstation"},
                    new Device{Id=2,Name="xbox",Icon="bi bi-xbox"},
                    new Device{Id=3,Name="Nintendo",Icon="bi bi-nintendi-swtich"},
                    new Device{Id=4,Name="PC",Icon="bi bi-pc-display"}
                });
            modelBuilder.Entity<GameDevice>()
                .HasKey(e => new { e.GameId, e.DeviceId });
            base.OnModelCreating(modelBuilder);
        }
    }
}

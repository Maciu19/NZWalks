using Microsoft.EntityFrameworkCore;
using NZWalksAPI.Models.Domain;

namespace NZWalksAPI.Data
{
    public class NZWalksDbContext : DbContext
    {
        public NZWalksDbContext(DbContextOptions<NZWalksDbContext> dbContextOptions)
            : base(dbContextOptions) 
            // pass the dbContextOptions to the base class
        {
            
        }

        public DbSet<Difficulty> Difficulties { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }
        public DbSet<Image> Images { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var difficulties = new List<Difficulty>()
            {
                new Difficulty()
                {
                    Id = Guid.Parse("e2dcb513-7247-4d75-b7db-03aade5ff1ef"),
                    Name = "Easy",
                },
                new Difficulty()
                {
                    Id = Guid.Parse("6ac9da36-95e8-4bac-860a-87f1eaa6edb3"),
                    Name = "Medium",
                },
                new Difficulty()
                {
                    Id = Guid.Parse("9e5f67ec-4619-4ba9-b445-d87fd17ed8d8"),
                    Name = "Hard",
                }
            };

            // Seed difficulties to the database
            modelBuilder.Entity<Difficulty>().HasData(difficulties);

            // Seed data for Regions
            var regions = new List<Region>()
            {
                new Region()
                {
                    Id = Guid.Parse("27a6d24f-371e-4af4-a2f7-ab74d297b7f9"),
                    Name = "Auckland",
                    Code = "AKL",
                    RegionImageUrl = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.britannica.com%2Fplace%2FAuckland-New-Zealand&psig=AOvVaw2hpeRBm_qe0iCUd2BG8wRe&ust=1690877606356000&source=images&cd=vfe&opi=89978449&ved=0CBEQjRxqFwoTCJjly4rAuIADFQAAAAAdAAAAABAE"
                },
                new Region()
                {
                    Id = Guid.Parse("f700ede5-f310-4bdd-8be6-911b81231e87"),
                    Name = "Northland",
                    Code = "NTL",
                    RegionImageUrl = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.live-work.immigration.govt.nz%2Fchoose-new-zealand%2Fregions-cities%2Fnorthland&psig=AOvVaw2RORpAHaf0KRscqiTYkxKS&ust=1690877642707000&source=images&cd=vfe&opi=89978449&ved=0CBEQjRxqFwoTCLDY7ZvAuIADFQAAAAAdAAAAABAE"
                },
                new Region()
                {
                    Id = Guid.Parse("2c9c5ca2-9b91-4e9f-b41d-ddf7da3f20fc"),
                    Name = "Bay Of Plenty",
                    Code = "BOP",
                    RegionImageUrl = null
                },
                new Region()
                {
                    Id = Guid.Parse("349b6d85-64be-4a73-ba9f-55c91cb471cf"),
                    Name = "Wellington",
                    Code = "WGN",
                    RegionImageUrl = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.britannica.com%2Fplace%2FWellington-New-Zealand&psig=AOvVaw11t71unddmgm6Gb9G_g-A1&ust=1690877729327000&source=images&cd=vfe&opi=89978449&ved=0CBEQjRxqFwoTCOjlnMXAuIADFQAAAAAdAAAAABAE"
                },
                new Region()
                {
                    Id = Guid.Parse("c6c60f8f-a36a-4cac-b974-5d5d3e0b996f"),
                    Name = "Nelson",
                    Code = "MSN",
                    RegionImageUrl = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fen.wikipedia.org%2Fwiki%2FNelson%2C_New_Zealand&psig=AOvVaw3pcHu97yy98Fr_k1DNtsmZ&ust=1690877770505000&source=images&cd=vfe&opi=89978449&ved=0CBEQjRxqFwoTCOC-4NjAuIADFQAAAAAdAAAAABAE"
                },
                new Region()
                {
                    Id = Guid.Parse("0bb7df90-bf33-49ba-8c0f-64c382aaf43a"),
                    Name = "Southland",
                    Code = "STL",
                    RegionImageUrl = null
                },
            };

            modelBuilder.Entity<Region>().HasData(regions); 
            // Insert the regions data inside the regions table
        }
    }
}

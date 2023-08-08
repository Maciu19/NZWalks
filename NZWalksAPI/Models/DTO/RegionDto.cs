namespace NZWalksAPI.Models.DTO
{
    public class RegionDto
    {
        // RegionDto will have properties that we want to expose back to the client
        // DTO can be a subset of the Domain Model => It can have 1 or multiple properties 

        // In this case this will have all the properties of the Region Domain Model

        public Guid Id { get; set; }
        public string Code { get; set; } 
        public string Name { get; set; }
        public string? RegionImageUrl { get; set; }
    }
}

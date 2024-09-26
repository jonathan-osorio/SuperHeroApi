namespace SuperHeroApi.Entities
{
    public class Villain
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string Alias { get; set; } = string.Empty;
        public DateTime Birthday { get; set; }
        public int Height { get; set; }
        public string Individuality { get; set; } = string.Empty;
        public string IndividualityDescription { get; set; } = string.Empty;
        public string Faction { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public string Likes { get; set; } = string.Empty;
        public string ProfilePictureURL { get; set; } = string.Empty;
    }
}

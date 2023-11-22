namespace PokemonReviewApp.Models
{
    // Join table (Pokemon & Owner)
    public class PokemonOwner
    {
        public int PokemonId { get; set; }
        public int OwnerId { get; set; }
        public Pokemon Pokemon { get; set; } // One-to-one
        public Owner Owner { get; set; } // One-to-one
    }
}

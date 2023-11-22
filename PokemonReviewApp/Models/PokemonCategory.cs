namespace PokemonReviewApp.Models
{
    // Join table (Pokemon & Category)
    public class PokemonCategory
    {
        public int PokemonId { get; set; }
        public int CategoryId { get; set; }
        public Pokemon Pokemon { get; set; } // One-to-one
        public Category Category { get; set; } // One-to-one
    }
}

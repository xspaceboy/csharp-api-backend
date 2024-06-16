namespace PokemonAPI.Models
{
    public struct PokemonState
    {
        public string Name { get; set; }
        public int Value { get; set; }
    }

    public struct PokemonEvolution
    {
        public string? From { get; set; }
        public string[] To { get; set; }
    }

    public class Pokemon
    {
        public int Number { get; set; }
        public string Name { get; set; }

        public string Generation { get; set; }

        public int Height { get; set; }

        public int Weight { get; set; }

        public string[] Types { get; set; }

        public PokemonState[] Stats  { get; set; }

        public string[] Moves {  get; set; }

        public string[] Abilities { get; set; }

        public PokemonEvolution Evolution { get; set; }

        public string Image { get; set; }
    }
}

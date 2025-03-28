using System.Text.RegularExpressions;

namespace MIDTERM_HO3
{
    public static class PokemonRepository
    {
        private static List<Pokemon> pokemons = new List<Pokemon>();

        public static void Initialize()
        {
            pokemons.Add(new Pokemon
            {
                Name = "Bulbasaur",
                Type = "Grass",
                Height = 0.7f,
                Weight = 2.04f,
                NextEvolution = "Venasaur",
                BaseEvolution = "Bulbasaur",
                Generation = "Generation-1",
                id = 1,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Ivysaur",
                Type = "Grass",
                Height = 0.7f,
                Weight = 2.04f,
                NextEvolution = "Venasaur",
                BaseEvolution = "Bulbasaur",
                Generation = "Generation-1",
                id = 2,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Venusaur",
                Type = "Grass",
                Height = 2.0f,
                Weight = 6.07f,
                NextEvolution = "Gigantamax Venusaur",
                BaseEvolution = "Ivysaur",
                Generation = "Generation-1",
                id = 3,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Charmander",
                Type = "Fire",
                Height = 0.61f,
                Weight = 2.00f,
                NextEvolution = "Charizard",
                BaseEvolution = "Charmeleon",
                Generation = "Generation-1",
                id = 4,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Charmeleon",
                Type = "Fire",
                Height = 1.1f,
                Weight = 3.07f,
                NextEvolution = "Charmander",
                BaseEvolution = "Charizard",
                Generation = "Generation-1",
                id = 5,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Charizard",
                Type = "Fire",
                Height = 1.7f,
                Weight = 5.07f,
                NextEvolution = "Charmander",
                BaseEvolution = "Chameleon",
                Generation = "Generation-1",
                id = 6,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Squirtle",
                Type = "Water",
                Height = 0.5f,
                Weight = 1.08f,
                NextEvolution = "Wartortle",
                BaseEvolution = "Squirtle",
                Generation = "Generation-1",
                id = 7,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Wartortle",
                Type = "Water",
                Height = 0.5f,
                Weight = 1.08f,
                NextEvolution = "Blastoise",
                BaseEvolution = "Squirtle",
                Generation = "Generation-1",
                id = 7,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Blastoise",
                Type = "Water",
                Height = 1.6f,
                Weight = 5.03f,
                NextEvolution = "Blastoise",
                BaseEvolution = "Wartorle",
                Generation = "Generation-1",
                id = 8,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Caterpie",
                Type = "Bug",
                Height = 0.3f,
                Weight = 1.00f,
                NextEvolution = "Metapod",
                BaseEvolution = "Caterpie",
                Generation = "Generation-1",
                id = 9,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Metapod",
                Type = "Bug",
                Height = 0.7f,
                Weight = 2.04f,
                NextEvolution = "Butterfree",
                BaseEvolution = "Caterpie",
                Generation = "Generation-1",
                id = 10,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Butterfree",
                Type = "Bug",
                Height = 0.7f,
                Weight = 2.04f,
                NextEvolution = "Butterfree",
                BaseEvolution = "Metapod",
                Generation = "Generation-1",
                id = 11,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Weedle",
                Type = "Bug/Poison",
                Height = 0.3f,
                Weight = 1.00f,
                NextEvolution = "Kakuna",
                BaseEvolution = "Weedle",
                Generation = "Generation-1",
                id = 12,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Kakuna",
                Type = "Bug/Poison",
                Height = 0.6f,
                Weight = 2.00f,
                NextEvolution = "Beedrill",
                BaseEvolution = "Weedle",
                Generation = "Generation-1",
                id = 13,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Beedrill",
                Type = "Bug/Poison",
                Height = 1.00f,
                Weight = 3.03f,
                NextEvolution = "Mega-Beedrill",
                BaseEvolution = "Kakuna",
                Generation = "Generation-1",
                id = 14,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Pidgey",
                Type = "Normal/Flying",
                Height = 0.03f,
                Weight = 1.00f,
                NextEvolution = "Pidgeotto",
                BaseEvolution = "Pidgey",
                Generation = "Generation-1",
                id = 15,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Pidgeotto",
                Type = "Normal/Flying",
                Height = 0.03f,
                Weight = 1.00f,
                NextEvolution = "Pidgeot",
                BaseEvolution = "Pidgey",
                Generation = "Generation-1",
                id = 16,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Pidgeot",
                Type = "Normal/Flying",
                Height = 0.03f,
                Weight = 1.00f,
                NextEvolution = "Pidgeot",
                BaseEvolution = "Pidgeotto",
                Generation = "Generation-1",
                id = 17,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Rattata",
                Type = "Normal",
                Height = 0.03f,
                Weight = 1.00f,
                NextEvolution = "Rattata",
                BaseEvolution = "Raticate",
                Generation = "Generation-1",
                id = 18,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Raticate",
                Type = "Normal",
                Height = 0.07f,
                Weight = 2.04f,
                NextEvolution = "Rattata",
                BaseEvolution = "Rattata",
                Generation = "Generation-1",
                id = 19,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Spearow",
                Type = "Normal/Flying",
                Height = 0.03f,
                Weight = 1.00f,
                NextEvolution = "Fearow",
                BaseEvolution = "Spearow",
                Generation = "Generation-1",
                id = 20,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Fearow",
                Type = "Normal/Flying",
                Height = 1.02f,
                Weight = 3.11f,
                NextEvolution = "Fearow",
                BaseEvolution = "Spearow",
                Generation = "Generation-1",
                id = 21,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Ekans",
                Type = "Poison",
                Height = 2.00f,
                Weight = 6.07f,
                NextEvolution = "Arbok",
                BaseEvolution = "Ekans",
                Generation = "Generation-1",
                id = 22,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Arbok",
                Type = "Poison",
                Height = 3.05f,
                Weight = 11.06f,
                NextEvolution = "Arbok",
                BaseEvolution = "Ekans",
                Generation = "Generation-1",
                id = 23,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Pikachu",
                Type = "Electric",
                Height = 0.04f,
                Weight = 6.00f,
                NextEvolution = "Raichu",
                BaseEvolution = "Pichu",
                Generation = "Generation-1",
                id = 24,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Raichu",
                Type = "Electric",
                Height = 0.08f,
                Weight = 30.00f,
                NextEvolution = "Raichu",
                BaseEvolution = "Pikachu",
                Generation = "Generation-1",
                id = 25,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Sandshrew",
                Type = "Ground",
                Height = 0.06f,
                Weight = 12.00f,
                NextEvolution = "Sandslash",
                BaseEvolution = "Sandshrew",
                Generation = "Generation-1",
                id = 26,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Sandslash",
                Type = "Ground",
                Height = 1.00f,
                Weight = 29.05f,
                NextEvolution = "Sandslash",
                BaseEvolution = "Sandshrew",
                Generation = "Generation-1",
                id = 27,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Nidoran",
                Type = "Poison",
                Height = 0.04f,
                Weight = 7.00f,
                NextEvolution = "Nidorina",
                BaseEvolution = "Nidoran",
                Generation = "Generation-1",
                id = 28,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Nidorina",
                Type = "Poison",
                Height = 0.08f,
                Weight = 20.00f,
                NextEvolution = "Nidoran",
                BaseEvolution = "Nidoqueen",
                Generation = "Generation-1",
                id = 29,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Nidoqueen",
                Type = "Poison",
                Height = 1.3f,
                Weight = 60.0f,
                NextEvolution = "Nidoqueen",
                BaseEvolution = "Nidoran",
                Generation = "Generation-1",
                id = 30,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Nidoran",
                Type = "Poison",
                Height = 0.5f,
                Weight = 9.0f,
                NextEvolution = "Nidorino",
                BaseEvolution = "Nidoran",
                Generation = "Generation-1",
                id = 31,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Nidorino",
                Type = "Poison",
                Height = 0.9f,
                Weight = 19.5f,
                NextEvolution = "Nidoking",
                BaseEvolution = "Nidoran",
                Generation = "Generation-1",
                id = 32,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Nidoking",
                Type = "Poison",
                Height = 1.3f,
                Weight = 62.0f,
                NextEvolution = "Nidoking",
                BaseEvolution = "Nidorino",
                Generation = "Generation-1",
                id = 33,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Clefairy",
                Type = "Fairy",
                Height = 0.6f,
                Weight = 7.5f,
                NextEvolution = "Clefable",
                BaseEvolution = "Cleffa",
                Generation = "Generation-1",
                id = 34,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Clefable",
                Type = "Fairy",
                Height = 1.3f,
                Weight = 40.0f,
                NextEvolution = "Clefable",
                BaseEvolution = "Clefairy",
                Generation = "Generation-1",
                id = 35,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Vulpix",
                Type = "Fire",
                Height = 0.6f,
                Weight = 9.9f,
                NextEvolution = "Ninetales",
                BaseEvolution = "Vulpix",
                Generation = "Generation-1",
                id = 36,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Ninetales",
                Type = "Fire",
                Height = 1.1f,
                Weight = 19.9f,
                NextEvolution = "Ninetales",
                BaseEvolution = "Vulpix",
                Generation = "Generation-1",
                id = 37,
            });
            pokemons.Add(new Pokemon
            {
                Name = "JigglyPuff",
                Type = "Normal/Fairy",
                Height = 0.5f,
                Weight = 5.5f,
                NextEvolution = "WigglyBuff",
                BaseEvolution = "IgglyBuff",
                Generation = "Generation-1",
                id = 38,
            });
            pokemons.Add(new Pokemon
            {
                Name = "WigglyPuff",
                Type = "Normal/Fairy",
                Height = 1.0f,
                Weight = 12.0f,
                NextEvolution = "WigglyPuff",
                BaseEvolution = "JigglyPuff",
                Generation = "Generation-1",
                id = 39,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Zubat",
                Type = "Normal/Flying",
                Height = 0.6f,
                Weight = 7.5f,
                NextEvolution = "Golbat",
                BaseEvolution = "Zubat",
                Generation = "Generation-1",
                id = 40,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Golbat",
                Type = "Normal/Flying",
                Height = 1.6f,
                Weight = 55.0f,
                NextEvolution = "Crobat",
                BaseEvolution = "Zubat",
                Generation = "Generation-1",
                id = 41,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Oddish",
                Type = "Grass/Poison",
                Height = 0.5f,
                Weight = 5.4f,
                NextEvolution = "Gloom",
                BaseEvolution = "Oddish",
                Generation = "Generation-1",
                id = 42,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Gloom",
                Type = "Grass/Poison",
                Height = 0.8f,
                Weight = 8.6f,
                NextEvolution = "VilePlume/Bellosom",
                BaseEvolution = "Oddish",
                Generation = "Generation-1",
                id = 43,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Vileplume",
                Type = "Grass/Poison",
                Height = 1.6f,
                Weight = 55.0f,
                NextEvolution = "Vileplume",
                BaseEvolution = "Gloom",
                Generation = "Generation-1",
                id = 44,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Paras",
                Type = "Bug/Grass",
                Height = 0.3f,
                Weight = 5.4f,
                NextEvolution = "Parasect",
                BaseEvolution = "Paras",
                Generation = "Generation-1",
                id = 45,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Parasect",
                Type = "Bug/Grass",
                Height = 1.0f,
                Weight = 29.5f,
                NextEvolution = "Parasect",
                BaseEvolution = "Paras",
                Generation = "Generation-1",
                id = 46,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Venonat",
                Type = "Bug/Grass",
                Height = 1.0f,
                Weight = 30.0f,
                NextEvolution = "Venomoth",
                BaseEvolution = "Venonat",
                Generation = "Generation-1",
                id = 47,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Venomoth",
                Type = "Bug/Poison",
                Height = 1.5f,
                Weight = 12.5f,
                NextEvolution = "Venomoth",
                BaseEvolution = "Venonat",
                Generation = "Generation-1",
                id = 48,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Diglett",
                Type = "Ground",
                Height = 0.2f,
                Weight = 0.8f,
                NextEvolution = "Dugtrio",
                BaseEvolution = "Diglett",
                Generation = "Generation-1",
                id = 49,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Dugtrio",
                Type = "Ground",
                Height = 0.7f,
                Weight = 33.3f,
                NextEvolution = "Dugtrio",
                BaseEvolution = "Diglett",
                Generation = "Generation-1",
                id = 50,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Meowth",
                Type = "Normal",
                Height = 0.4f,
                Weight = 4.2f,
                NextEvolution = "Persian",
                BaseEvolution = "Meowth",
                Generation = "Generation-1",
                id = 51,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Persian",
                Type = "Normal",
                Height = 0.4f,
                Weight = 4.2f,
                NextEvolution = "Persian",
                BaseEvolution = "Meowth",
                Generation = "Generation-1",
                id = 52,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Psyduck",
                Type = "Water",
                Height = 0.8f,
                Weight = 19.6f,
                NextEvolution = "Golduck",
                BaseEvolution = "Psyduck",
                Generation = "Generation-1",
                id = 53,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Golduck",
                Type = "Water",
                Height = 0.8f,
                Weight = 19.6f,
                NextEvolution = "Golduck",
                BaseEvolution = "Psyduck",
                Generation = "Generation-1",
                id = 53,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Mankey",
                Type = "Fighthing",
                Height = 0.5f,
                Weight = 28.0f,
                NextEvolution = "Primeape",
                BaseEvolution = "Mankey",
                Generation = "Generation-1",
                id = 54,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Primeape",
                Type = "Fighthing",
                Height = 1.0f,
                Weight = 32.0f,
                NextEvolution = "Annihilape",
                BaseEvolution = "Mankey",
                Generation = "Generation-1",
                id = 55,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Growlithe",
                Type = "Fire",
                Height = 0.7f,
                Weight = 19.0f,
                NextEvolution = "Arcanine",
                BaseEvolution = "Growlithe",
                Generation = "Generation-1",
                id = 56,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Arcanine",
                Type = "Fire",
                Height = 1.9f,
                Weight = 155.0f,
                NextEvolution = "Arcanine",
                BaseEvolution = "Growlithe",
                Generation = "Generation-1",
                id = 56,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Poliwag",
                Type = "Water",
                Height = 0.6f,
                Weight = 12.4f,
                NextEvolution = "Poliwhirl",
                BaseEvolution = "Poliwag",
                Generation = "Generation-1",
                id = 57,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Poliwhirl",
                Type = "Water",
                Height = 1.0f,
                Weight = 20f,
                NextEvolution = "Poliwhirl",
                BaseEvolution = "Poliwag",
                Generation = "Generation-1",
                id = 58,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Poliwharth",
                Type = "Water/Figthing",
                Height = 1.0f,
                Weight = 20f,
                NextEvolution = "Poliwhirl",
                BaseEvolution = "Poliwag",
                Generation = "Generation-1",
                id = 59,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Abra",
                Type = "Physic",
                Height = 0.9f,
                Weight = 19.5f,
                NextEvolution = "Kadabra",
                BaseEvolution = "Abra",
                Generation = "Generation-1",
                id = 60,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Kadabra",
                Type = "Physic",
                Height = 0.9f,
                Weight = 19.5f,
                NextEvolution = "Alakazam",
                BaseEvolution = "Abra",
                Generation = "Generation-1",
                id = 61,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Alakazam",
                Type = "Physic",
                Height = 0.9f,
                Weight = 19.5f,
                NextEvolution = "Alakazam",
                BaseEvolution = "Abra",
                Generation = "Generation-1",
                id = 62,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Machop",
                Type = "Fighting",
                Height = 0.8f,
                Weight = 19.5f,
                NextEvolution = "Machoke",
                BaseEvolution = "Machop",
                Generation = "Generation-1",
                id = 63,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Machoke",
                Type = "Fighting",
                Height = 1.5f,
                Weight = 70.3f,
                NextEvolution = "Machamp",
                BaseEvolution = "Machop",
                Generation = "Generation-1",
                id = 64,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Machamp",
                Type = "Fighting",
                Height = 1.5f,
                Weight = 70.3f,
                NextEvolution = "Machamp",
                BaseEvolution = "Machop",
                Generation = "Generation-1",
                id = 65,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Bellsprout",
                Type = "Fighting",
                Height = 0.7f,
                Weight = 4.0f,
                NextEvolution = "Weepinbell",
                BaseEvolution = "Bellsprout",
                Generation = "Generation-1",
                id = 66,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Weepinbel",
                Type = "Grass",
                Height = 1.0f,
                Weight = 6.4f,
                NextEvolution = "Victreebel",
                BaseEvolution = "Bellsprout",
                Generation = "Generation-1",
                id = 67,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Victreebe",
                Type = "Grass",
                Height = 1.7f,
                Weight = 6.4f,
                NextEvolution = "Victreebel",
                BaseEvolution = "Bellsprout",
                Generation = "Generation-1",
                id = 68,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Tentacool",
                Type = "Water/Poison",
                Height = 0.9f,
                Weight = 45.5f,
                NextEvolution = "Tentacruel",
                BaseEvolution = "Tentacool",
                Generation = "Generation-1",
                id = 69,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Tentacruel",
                Type = "Water/Poison",
                Height = 0.9f,
                Weight = 45.5f,
                NextEvolution = "Tentacruel",
                BaseEvolution = "Tentacool",
                Generation = "Generation-1",
                id = 70,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Geodude",
                Type = "Rock",
                Height = 0.9f,
                Weight = 45.5f,
                NextEvolution = "Graveler",
                BaseEvolution = "Geodude",
                Generation = "Generation-1",
                id = 71,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Graveler",
                Type = "Rock",
                Height = 0.9f,
                Weight = 45.5f,
                NextEvolution = "Golem",
                BaseEvolution = "Geodude",
                Generation = "Generation-1",
                id = 72,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Golem",
                Type = "Rock",
                Height = 1.4f,
                Weight = 300.0f,
                NextEvolution = "Golem",
                BaseEvolution = "Geodude",
                Generation = "Generation-1",
                id = 73,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Ponyta",
                Type = "Fire",
                Height = 1.0f,
                Weight = 30.0f,
                NextEvolution = "Rapidash",
                BaseEvolution = "Ponyta",
                Generation = "Generation-1",
                id = 74,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Rapidash",
                Type = "Fire",
                Height = 1.7f,
                Weight = 95.0f,
                NextEvolution = "Rapidash",
                BaseEvolution = "Ponyta",
                Generation = "Generation-1",
                id = 75,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Slowpoke",
                Type = "Water",
                Height = 1.7f,
                Weight = 95.0f,
                NextEvolution = "Slowbro/Slowking",
                BaseEvolution = "Slowpoke",
                Generation = "Generation-1",
                id = 76,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Slowbro",
                Type = "Water",
                Height = 1.7f,
                Weight = 95.0f,
                NextEvolution = "Slowbro/Slowking",
                BaseEvolution = "Slowpoke",
                Generation = "Generation-1",
                id = 77,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Magnemite",
                Type = "Electric",
                Height = 0.3f,
                Weight = 6.0f,
                NextEvolution = "Magneton",
                BaseEvolution = "Magnamite",
                Generation = "Generation-1",
                id = 78,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Magneton",
                Type = "Electric",
                Height = 0.3f,
                Weight = 6.0f,
                NextEvolution = "Magneton",
                BaseEvolution = "Magnamite",
                Generation = "Generation-1",
                id = 79,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Farfetch'd ",
                Type = "Electric",
                Height = 0.8f,
                Weight = 15.0f,
                NextEvolution = "N/A",
                BaseEvolution = "N/A",
                Generation = "Generation-1",
                id = 80,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Doduo",
                Type = "Normal/Flying",
                Height = 0.8f,
                Weight = 15.0f,
                NextEvolution = "Dodrio",
                BaseEvolution = "N/A",
                Generation = "Generation-1",
                id = 81,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Dodrio",
                Type = "Normal/Flying",
                Height = 0.8f,
                Weight = 15.0f,
                NextEvolution = "N/A",
                BaseEvolution = "N/A",
                Generation = "Generation-1",
                id = 82,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Seel",
                Type = "Water",
                Height = 1.1f,
                Weight = 90.0f,
                NextEvolution = "Dewgong",
                BaseEvolution = "N/A",
                Generation = "Generation-1",
                id = 83,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Dewgong",
                Type = "Water",
                Height = 1.7f,
                Weight = 120.0f,
                NextEvolution = "Dewgong",
                BaseEvolution = "Seel",
                Generation = "Generation-1",
                id = 84,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Grimer",
                Type = "Poison",
                Height = 0.9f,
                Weight = 30.0f,
                NextEvolution = "Muk",
                BaseEvolution = "Grimer",
                Generation = "Generation-1",
                id = 85,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Muk",
                Type = "Poison",
                Height = 0.9f,
                Weight = 30.0f,
                NextEvolution = "Muk",
                BaseEvolution = "Grimer",
                Generation = "Generation-1",
                id = 86,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Shellder",
                Type = "Poison",
                Height = 0.3f,
                Weight = 4.0f,
                NextEvolution = "Muk",
                BaseEvolution = "Grimer",
                Generation = "Generation-1",
                id = 87,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Cloyster",
                Type = "Poison",
                Height = 0.3f,
                Weight = 4.0f,
                NextEvolution = "Shellder",
                BaseEvolution = "Grimer",
                Generation = "Generation-1",
                id = 88,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Glastly",
                Type = "Ghost/Poison",
                Height = 1.3f,
                Weight = 0.1f,
                NextEvolution = "Haunter",
                BaseEvolution = "Gaslty",
                Generation = "Generation-1",
                id = 89,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Haunter",
                Type = "Ghost/Poison",
                Height = 1.6f,
                Weight = 0.1f,
                NextEvolution = "Genger",
                BaseEvolution = "Gastly",
                Generation = "Generation-1",
                id = 90,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Gengar",
                Type = "Ghost/Poison",
                Height = 1.5f,
                Weight = 40.5f,
                NextEvolution = "Genger",
                BaseEvolution = "Haunter",
                Generation = "Generation-1",
                id = 91,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Onix",
                Type = "Rock/Ground",
                Height = 8.8f,
                Weight = 210.5f,
                NextEvolution = "Steelix",
                BaseEvolution = "N/A",
                Generation = "Generation-1",
                id = 92,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Drowzee",
                Type = "Psychic",
                Height = 1.0f,
                Weight = 32.4f,
                NextEvolution = "Hypno",
                BaseEvolution = "N/A",
                Generation = "Generation-1",
                id = 93,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Hypno",
                Type = "Psychic",
                Height = 1.6f,
                Weight = 75.6f,
                NextEvolution = "Hypno",
                BaseEvolution = "N/A",
                Generation = "Generation-1",
                id = 94,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Crabby",
                Type = "Water",
                Height = 0.4f,
                Weight = 6.5f,
                NextEvolution = "Kingler",
                BaseEvolution = "N/A",
                Generation = "Generation-1",
                id = 95,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Kingler",
                Type = "Water",
                Height = 1.3f,
                Weight = 60.5f,
                NextEvolution = "Kingler",
                BaseEvolution = "Krabby",
                Generation = "Generation-1",
                id = 96,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Voltorb",
                Type = "Electric",
                Height = 0.5f,
                Weight = 10.4f,
                NextEvolution = "Electrode",
                BaseEvolution = "N/A",
                Generation = "Generation-1",
                id = 97,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Electrode",
                Type = "Electric",
                Height = 1.2f,
                Weight = 66.6f,
                NextEvolution = "Electrode",
                BaseEvolution = "Voltrobe",
                Generation = "Generation-1",
                id = 98,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Exeggcute",
                Type = "Grass/Psychic",
                Height = 0.4f,
                Weight = 2.5f,
                NextEvolution = "Exeggutor",
                BaseEvolution = "N/A",
                Generation = "Generation-1",
                id = 99,
            });
            pokemons.Add(new Pokemon
            {
                Name = "Exeggutor",
                Type = "Grass/Psychic",
                Height = 2.0f,
                Weight = 120.0f,
                NextEvolution = "Exeggutor",
                BaseEvolution = "N/A",
                Generation = "Generation-1",
                id = 100,
            });
        }
        public static List<Pokemon> GetPokemonList()
        {
            if (pokemons == null || pokemons.Count == 0)
            {
                Initialize();
            }
            return pokemons;
        }
        public static void AddPokemon(Pokemon pokemon)
        {
            pokemons.Add(pokemon);
        }
    }
}


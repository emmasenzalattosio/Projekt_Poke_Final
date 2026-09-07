using System;
using System.Collections.Generic;

namespace Poke_Proje
{
    public class PokemonCenter
    {
        private List<Pokemon> pokemonList;
        private List<Trainer> trainerList;

        public PokemonCenter()
        {
            pokemonList = new List<Pokemon>();
            trainerList = new List<Trainer>();
        }

        public List<Pokemon> GetAllPokeon()
        {
            return pokemonList;
        }

        public List<Trainer> GetAllTrainers()
        {
            return trainerList;
        }

        public void AddPokemon(Pokemon pokemon)
        {
            if (pokemon == null)
            {
                Console.WriteLine("No Pokémon to add.");
                return;
            }

            pokemonList.Add(pokemon);
            
        }

        public void AddTrainer(Trainer trainer)
        {
            if (trainer == null)
            {
                Console.WriteLine("No trainer to add.");
                return;
            }

            trainerList.Add(trainer);
            Console.WriteLine($"Trainer {trainer.Name} was added.");
            Console.Clear();
        }

        public void ShowAllPokemon()
        {
            Console.WriteLine("All Pokémon in the Center: \n");
            foreach (Pokemon p in pokemonList)
            {
                Console.WriteLine(p.ShowStatus());
            }
        }

        public void ShowAllTrainers()
        {
            List<string> lines = new List<string>();
            foreach (Trainer t in trainerList)
            {
                lines.Add($"- {t.Name} ({t.ass_poke.Count} Pokémon)");
            }
            ConsoleUI.DrawFrame("👥 All Trainers", lines, ConsoleColor.Cyan, ConsoleColor.Yellow);
        }

        public Pokemon SearchPokemon(string name)
        {
            Pokemon found = null;

            foreach (Pokemon p in pokemonList)
            {
                if (p.Name.ToLower() == name.ToLower())
                {
                    found = p;
                    break;
                }
            }

            if (found != null)
            {
                ConsoleUI.DrawFrame($"✅ Gefunden {found.Name}", new[] { found.ShowStatus().TrimEnd('\n', '\r') }, ConsoleColor.Green, ConsoleColor.Yellow);
            }
            else
            {
                ConsoleUI.DrawFrame("❌ Suchergebnis", new[] { "Pokemon nicht gefunden" }, ConsoleColor.Red, ConsoleColor.Yellow);
            }

            return found;
        }

        public void AssignPokeon(Pokemon pokemon, Trainer trainer)
        {
            trainer.AssignPokemon(pokemon);
        }

        public void GetBehavior(Pokemon pokemon)
        {
            Console.WriteLine(pokemon.Behavior());
        }

        public void HealPokemon(Pokemon pokemon)
        {
            pokemon.Heal();
        }

        public void HealPokemon(string name)
        {
            Pokemon found = SearchPokemon(name);
            if (found != null)
            {
                found.Heal();
            }
        }

        public bool RemovePokemon(Pokemon pokemon)
        {
            if (pokemonList.Contains(pokemon))
            {
                pokemonList.Remove(pokemon);
                return true;
            }
            return false;
        }
    }
}

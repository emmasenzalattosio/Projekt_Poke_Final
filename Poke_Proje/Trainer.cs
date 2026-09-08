using System;
using System.Collections.Generic;
using System.Linq;

namespace Poke_Proje
{
    public class Trainer
    {
        public string Name;
        public List<Pokemon> ass_poke { get; set; }

        public Trainer(string name)
        {
            this.Name = name;
            this.ass_poke = new List<Pokemon>();
        }

        private int ReadNumber(int min, int max)
        {
            int result;

            while (true)
            {
                Console.Write($"Enter a number ({min}-{max}): ");
                if (int.TryParse(Console.ReadLine(), out result) && result >= min && result <= max)
                    return result;

                Console.WriteLine("Invalid, try again.");
            }
        }

        public Pokemon? ChoosePokemonFromTeam()
        {
            if (ass_poke.Count == 0)
            {
                Console.WriteLine($"{Name} has no Pokémon in the team.");
                return null;
            }

            Console.Clear();
            List<string> lines = new List<string>();
            for (int i = 0; i < ass_poke.Count; i++)
            {
                lines.Add($"[{i + 1}] {ass_poke[i].Name} - HP: {ass_poke[i].GetCurrentHp()}/{ass_poke[i].GetMaxHp()}");
            }
            ConsoleUI.WriteCenteredScreen($"🎒 {Name}'s team", lines, ConsoleColor.Yellow);

            int choice = ReadNumber(1, ass_poke.Count);
            return ass_poke[choice - 1];
        }

        public void AssignPokemon(Pokemon pokemon)
        {
            if (pokemon == null)
            {
                Console.WriteLine("No Pokémon was given to the trainer.");
                return;
            }

            if (ass_poke.Count >= 5)
            {
                Console.WriteLine($"{Name} already has too many pokes, chill mal brudi");
                return;
            }

            pokemon.SetTrainer(Name);
            ass_poke.Add(pokemon);           
            Console.WriteLine();
        }

        public void ShowPokemon()
        {
            Console.Clear();

            if (ass_poke.Count == 0)
            {
                ConsoleUI.WriteCenteredScreen($"🎒 {Name}'s Pokémon", new[] { "No Pokémon assigned yet.", "", "Press any key to return to the menu..." }, ConsoleColor.Yellow);
                Console.ReadKey(true);
                return;
            }

            List<string> lines = new List<string>();
            foreach (Pokemon p in ass_poke)
            {
                lines.Add(p.ShowStatus().TrimEnd('\n', '\r'));
            }
            lines.Add(string.Empty);
            lines.Add("Press any key to return to the menu...");
            ConsoleUI.WriteCenteredScreen($"🎒 {Name}'s Pokémon", lines, ConsoleColor.Yellow);

            Console.ReadKey(true);
        }

        public void HealPokemon(Pokemon pokemon)
        {
            if (pokemon == null)
            {
                Console.WriteLine("No Pokémon was selected for healing.");
                return;
            }

            pokemon.Heal();
            Console.WriteLine($"{Name} healed {pokemon.Name}.");
            Console.WriteLine($"HP: {pokemon.GetCurrentHp()}/{pokemon.GetMaxHp()}");
        }

        public void HealPokemon(string name)
        {
            Pokemon? pokemon = ass_poke.FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

            if (pokemon == null)
            {
                Console.WriteLine($"{name} is not in {Name}'s team.");
                return;
            }

            HealPokemon(pokemon);
        }

        public void HealTeam()
        {
            Console.Clear();

            List<string> lines = new List<string>();

            if (ass_poke.Count == 0)
            {
                lines.Add($"{Name} has no Pokémon to heal.");
            }
            else
            {
                foreach (Pokemon p in ass_poke)
                {
                    p.Heal();
                    lines.Add($"{p.Name}: {p.GetCurrentHp()}/{p.GetMaxHp()}");
                }
            }

            lines.Add(string.Empty);
            lines.Add("Press any key to return to the menu...");
            ConsoleUI.WriteCenteredScreen($"💊 {Name}'s team healed", lines, ConsoleColor.Yellow);
            Console.ReadKey(true);
        }

        public void ClearTeam()
        {
            ass_poke.Clear();
        }

        public bool HasPokemon()
        {
            return ass_poke.Count > 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace Poke_Proje
{
    public class NiceCute
    {
        private readonly PokemonCenter Center;
        private readonly Arena Arena;

        public NiceCute(PokemonCenter center, Arena arena)
        {
            Center = center;
            Arena = arena;
        }

        private const string BannerText = @"█▀▀▀▀▀▄   ▄▀▀▀▀▄  █▀▀█ ▀▀█  ▄▀▀▀▀▀█  ▄▀▀▀▀▄▄▀▀▄   ▄▀▀▀▀▄   ▄▀▀▀▀▄ 
█      █ █      █ █  ▓   █ █      ▓ █          █ █      █ █      █
█  █▀  █ █  █▀  █ █   ▄▄▀  █  █▀▀▀▀ █  ░   ░   █ █  █▀  █ █  ░   █
▓  ▀▀ ▄▀ ▓  █▄  █ ▓  ▄  ▀▄ ▓  █▄█▄▄ ▓  ░   ░   █ ▓  █▄  █ ▓  ░   █
▒  █▀▀   ▒  ▀▀  ▒ ▒  █   ▒ ▒      ▒ ▒  ▒   ▒   ▓ ▒  ▀▀  ▒ ▒  ▒   ▓
░▄▄█      ▀▄▄▄▄▀  ░▄▄█ ▄▄░  ▀▄▄▄▄▄█ ▒▄▄▓ ▄▄▓ ▄▄▒  ▀▄▄▄▄▀  ▒▄▄▓ ▄▄▒";

        public void Start()
        {
            Trainer? selectedTrainer = SelectTrainer();
            if (selectedTrainer == null)
            {
                return;
            }

            ShowActionMenu(selectedTrainer);
        }


        private Trainer? SelectTrainer()
        {
            List<Trainer> trainers = Center.GetAllTrainers();

            if (trainers.Count == 0)
            {
                ConsoleUI.WriteCentered("No trainers were found in the Pokemon Center.");
                Console.ReadKey(true);
                return null;
            }

            int selectedIndex = 0;

            const string chooseTrainerArt = @"   ________                                                       __             _                
  / ____/ /_  ____  ____  ________     __  ______  __  _______   / /__________ _(_)___  ___  _____
 / /   / __ \/ __ \/ __ \/ ___/ _ \   / / / / __ \/ / / / ___/  / __/ ___/ __ `/ / __ \/ _ \/ ___/
/ /___/ / / / /_/ / /_/ (__  )  __/  / /_/ / /_/ / /_/ / /     / /_/ /  / /_/ / / / / /  __/ /    
\____/_/ /_/\____/\____/____/\___/   \__, /\____/\__,_/_/      \__/_/   \__,_/_/_/ /_/\___/_/     
                                    /____/                                                       ";

            while (true)
            {
                Console.Clear();

                List<string> trainerNames = trainers.Select(t => $"🧑‍🎓 {t.Name} - Chan").ToList();
                ConsoleUI.WriteFramedScreen("🎮 Choose Your Trainer 🎮", trainerNames, selectedIndex, ConsoleColor.Green, ConsoleColor.Yellow, BannerText, chooseTrainerArt);

                ConsoleKey key = Console.ReadKey(true).Key;


                if (key == ConsoleKey.UpArrow)
                {
                    selectedIndex--;
                    if (selectedIndex < 0)
                    {
                        selectedIndex = trainers.Count - 1;
                    }
                }
                else if (key == ConsoleKey.DownArrow)
                {
                    selectedIndex++;
                    if (selectedIndex >= trainers.Count)
                    {
                        selectedIndex = 0;
                    }
                }
                else if (key == ConsoleKey.Enter)
                {
                    return trainers[selectedIndex];
                }
            }
        }

        private void ShowActionMenu(Trainer trainer)
        {
            string[] options =
            {
                "👀 View Pokémon",
                "🔍 Search Pokémon",
                "🧑‍🤝‍🧑 Show Trainers",
                "⚔️  Start Battle",
                "💊 Heal Team",
                "🕵️  Team WH Ambush",
                "🚪 Exit"
            };

            int selected = 0;

            while (true)
            {
                Console.Clear();

                ConsoleUI.WriteFramedScreen($"🧢 Trainer: {trainer.Name} 🧢", options, selected, ConsoleColor.DarkMagenta, ConsoleColor.Yellow, BannerText);

                ConsoleKey key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.UpArrow)
                {
                    selected--;
                    if (selected < 0)
                    {
                        selected = options.Length - 1;
                    }
                }
                else if (key == ConsoleKey.DownArrow)
                {
                    selected++;
                    if (selected >= options.Length)
                    {
                        selected = 0;
                    }
                }
                else if (key == ConsoleKey.Enter)
                {
                    switch (selected)
                    {
                        case 0:
                            trainer.ShowPokemon();
                            break;

                        case 1:
                            Console.Clear();
                            ConsoleUI.WriteCentered("Enter the name of the Pokémon you want to search:");
                            string searchName = Console.ReadLine() ?? string.Empty;
                            Center.SearchPokemon(searchName);
                            Console.ReadKey(true);
                            break;

                        case 2:
                            Console.Clear();
                            Center.ShowAllTrainers();
                            Console.ReadKey(true);
                            break;

                        case 3:
                            Arena.StartBattle(trainer);
                            break;

                        case 4:
                            trainer.HealTeam();
                            break;

                        case 5:
                            Arena.RocketEncounter(trainer);
                            break;

                        case 6:
                            Console.Clear();
                            ConsoleUI.WriteCentered("Goodbye, trainer! See you at the next battle!");
                            Console.ReadKey(true);
                            return;
                    }
                }
            }
        }


    }
}

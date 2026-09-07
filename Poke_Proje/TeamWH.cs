using System;
using System.Collections.Generic;
using System.Text;

namespace Poke_Proje
{
    public class TeamWH : Trainer
    {
        private string[] evilQuotes;
        private Random rnd;

        public TeamWH(string name) : base(name)
        {
            rnd = new Random();
            evilQuotes = new string[]
            {
                "Prepare for trouble, make it double!!",
                "To protect the world from devastation... lol jk we stealin yo shit",
                "Team WH blast off at the speed of light, surrender now or prepare to fight",
                "Your pokeon are ours now bestie"
            };
        }

        public void StealPokemon(Trainer victim)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"\n!!! TEAM WH APPEARED OUTTA NOWHERE !!!");
            Console.WriteLine($"{Name}: \"{evilQuotes[rnd.Next(evilQuotes.Length)]}\"");
            Console.ResetColor();

            if (!victim.HasPokemon())
            {
                Console.WriteLine($"{Name}: \"Bruh you broke, aint got no pokeon to steal lmao\"");
                Console.WriteLine("*Team WH walks away disappointed*");
                return;
            }

            // yoink all the pokeon
            List<Pokemon> stolenGoods = new List<Pokemon>(victim.ass_poke);
            victim.ClearTeam();

            foreach (Pokemon p in stolenGoods)
            {
                this.ass_poke.Add(p);
                p.SetTrainer(this.Name);
                Console.WriteLine($"{Name} stole {p.Name}!! *yoink*");
            }

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"\n{Name}: \"Wanna be a real trainer?? Then come get them back!!\"");
            Console.WriteLine($"{Name}: \"But first you gotta git gud lol\"");
            Console.ResetColor();
        }

        public void AskToBecomeRealTrainer()
        {
            Console.WriteLine("\n---> Press [Y] if you wanna be a real trainer and fight for your pokeon back <---");
            Console.WriteLine("---> Press [N] if you a coward and keep crying <---");
        }
    }
}
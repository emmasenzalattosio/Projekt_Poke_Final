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

        public List<string> StealPokemon(Trainer victim)
        {
            List<string> lines = new List<string>
            {
                "!!! TEAM WH APPEARED OUTTA NOWHERE !!!",
                $"{Name}: \"{evilQuotes[rnd.Next(evilQuotes.Length)]}\""
            };

            if (!victim.HasPokemon())
            {
                lines.Add($"{Name}: \"Bruh you broke, aint got no pokeon to steal lmao\"");
                lines.Add("*Team WH walks away disappointed*");
                return lines;
            }

            // yoink all the pokeon
            List<Pokemon> stolenGoods = new List<Pokemon>(victim.ass_poke);
            victim.ClearTeam();

            foreach (Pokemon p in stolenGoods)
            {
                this.ass_poke.Add(p);
                p.SetTrainer(this.Name);
                lines.Add($"{Name} stole {p.Name}!! *yoink*");
            }

            lines.Add(string.Empty);
            lines.Add($"{Name}: \"Wanna be a real trainer?? Then come get them back!!\"");
            lines.Add($"{Name}: \"But first you gotta git gud lol\"");
            return lines;
        }
    }
}
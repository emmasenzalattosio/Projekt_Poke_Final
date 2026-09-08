using System;
using System.Collections.Generic;
using System.Linq;

namespace Poke_Proje
{
    public class Arena
    {
        public PokemonCenter Center { get; set; }
        public TeamWH RocketTeam;
        private Pokemon RocketGuard;
        private Random random = new Random();

        public Arena()
        {
            Center = new PokemonCenter();

            Trainer Holger = new Trainer("Holger");
            Center.AddTrainer(Holger);

            Trainer Aman = new Trainer("Aman");
            Center.AddTrainer(Aman);

            Trainer Hasan = new Trainer("Hasan");
            Center.AddTrainer(Hasan);

            Trainer Jens = new Trainer("Jens");
            Center.AddTrainer(Jens);

            Trainer Chris = new Trainer("Chris");
            Center.AddTrainer(Chris);

            Trainer Vanessa = new Trainer("Vanessa");
            Center.AddTrainer(Vanessa);

            Trainer Emma = new Trainer("Emma");
            Center.AddTrainer(Emma);

            Trainer Josi = new Trainer("Josi");
            Center.AddTrainer(Josi);

            Trainer Babak = new Trainer("Babak");
            Center.AddTrainer(Babak);

            Trainer Mohammed = new Trainer("Mohammed");
            Center.AddTrainer(Mohammed);

            Trainer Ilia = new Trainer("Ilia");
            Center.AddTrainer(Ilia);

            Trainer Sasha = new Trainer("Sasha");
            Center.AddTrainer(Sasha);

            Trainer Raffael = new Trainer("Raffael");
            Center.AddTrainer(Raffael);

            Trainer Fabian = new Trainer("Fabian");
            Center.AddTrainer(Fabian);

            Trainer Kathy = new Trainer("Kathy");
            Center.AddTrainer(Kathy);

            Trainer Azzeddine = new Trainer("Azzeddine");
            Center.AddTrainer(Azzeddine);

            Trainer Daniel = new Trainer("Daniel");
            Center.AddTrainer(Daniel);

            Trainer Marcel = new Trainer("Marcel");
            Center.AddTrainer(Marcel);

            Trainer Roman = new Trainer("Roman");
            Center.AddTrainer(Roman);

            Trainer Felix = new Trainer("Felix");
            Center.AddTrainer(Felix);

            Trainer Daniel2 = new Trainer("Daniel2");
            Center.AddTrainer(Daniel2);

            Trainer Sven = new Trainer("Sven");
            Center.AddTrainer(Sven);

            Trainer Aikut = new Trainer("Aykut");
            Center.AddTrainer(Aikut);

            Console.Clear();

            Dramatic Kosturso = new Dramatic("[Kosturso]", "Trainer: [Jens]", 50, 110, 40, 80);
            Kosturso.AddAttack("Dramatischer hieb", 35);
            Kosturso.AddAttack("Josi hating", 15);
            Kosturso.AddAttack("Big foot attack", 40);
            Kosturso.AddAttack("Tonsur-Reflektor", 50);
            Center.AddPokemon(Kosturso);
            Jens.AssignPokemon(Kosturso);

            Dramatic Traumato = new Dramatic("[Traumato]", "Trainer: [Mohammed]", 45, 70, 50, 40);
            Traumato.AddAttack("Schnarcher", 60);
            Traumato.AddAttack("Hypnose", 10);
            Traumato.AddAttack("Ehm Ehm Ehm", 80);
            Traumato.AddAttack("Hiding", 60);
            Center.AddPokemon(Traumato);
            Mohammed.AssignPokemon(Traumato);

            Dramatic Wheezing = new Dramatic("[Galar Wheezing]", "Trainer: [Holger]", 64, 100, 60, 65);
            Wheezing.AddAttack("Raucher Husten", 60);
            Wheezing.AddAttack("BOOOAAAHH schallwelle", 70);
            Wheezing.AddAttack("Dauer-Ascher", 35);
            Wheezing.AddAttack("Alles Scheisse - Konter", 45);
            Center.AddPokemon(Wheezing);
            Holger.AssignPokemon(Wheezing);

            Dramatic Enamorus = new Dramatic("[Enamorus]", "Trainer: [Fabian]", 33, 70, 40, 80);
            Enamorus.AddAttack("perfektionismus", 40);
            Enamorus.AddAttack("Schlaumeier", 25);
            Enamorus.AddAttack("Hairline reduzierer", 50);
            Enamorus.AddAttack("forehead shining", 80);
            Center.AddPokemon(Enamorus);
            Fabian.AssignPokemon(Enamorus);

            Dramatic Screamtail = new Dramatic("[Scream Tail]", "Trainer: [Marcel]", 29, 60, 20, 40);
            Screamtail.AddAttack("Femboy Falle", 40);
            Screamtail.AddAttack("choker curse", 50);
            Screamtail.AddAttack("catwalk", 10);
            Screamtail.AddAttack("E-Boy kick", 40);
            Center.AddPokemon(Screamtail);
            Marcel.AssignPokemon(Screamtail);

            Dramatic Mime = new Dramatic("[Mr.Mime]", "Trainer: [Felix]", 37, 90, 70, 35);
            Mime.AddAttack("Beschweren", 35);
            Mime.AddAttack("Eingeschnappt sein", 10);
            Mime.AddAttack("Energie Drinken", 20);
            Mime.AddAttack("Meine Frau ist Krank", 45);
            Center.AddPokemon(Mime);
            Felix.AssignPokemon(Mime);

            Dramatic Jigglypuff = new Dramatic("[Jigglypuff]", "Trainer: [Emma]", 67, 67, 67, 67);
            Jigglypuff.AddAttack("ADHD Punch", 15);
            Jigglypuff.AddAttack("Alko Kick", 35);
            Jigglypuff.AddAttack("Balkan-Beat-Slam", 60);
            Jigglypuff.AddAttack("Sprechverbot", 10);
            Center.AddPokemon(Jigglypuff);
            Emma.AssignPokemon(Jigglypuff);

            Chill Snorlax = new Chill("[Snorlax]", "Trainer: [Hasan]", 100, 150, 100, 100);
            Snorlax.AddAttack("Protein Overload", 80);
            Snorlax.AddAttack("Erholung", 0);
            Snorlax.AddAttack("Führerschein klauen", 15);
            Snorlax.AddAttack("Unendliche Masturbation", 100);
            Center.AddPokemon(Snorlax);
            Hasan.AssignPokemon(Snorlax);

            Chill Slaking = new Chill("[Slaking]", "Trainer: [Babak]", 72, 120, 90, 90);
            Slaking.AddAttack("5-Min Terrine", 60);
            Slaking.AddAttack("Babak sachen halt", 30);
            Slaking.AddAttack("Beeing there", 40);
            Slaking.AddAttack("Just a chill guy", 80);
            Center.AddPokemon(Slaking);
            Babak.AssignPokemon(Slaking);

            Chill Ghastly = new Chill("[Ghastly]", "Trainer: [Sven]", 18, 38, 32, 33);
            Ghastly.AddAttack("Weed Smoker", 25);
            Ghastly.AddAttack("Roller Tricks", 35);
            Ghastly.AddAttack("Ankle breaker", 40);
            Ghastly.AddAttack("Alko Popper", 15);
            Center.AddPokemon(Ghastly);
            Sven.AssignPokemon(Ghastly);

            Chill Probopass = new Chill("[Probopass]", "Trainer: [Raffael]", 44, 80, 22, 18);
            Probopass.AddAttack("Figuren Anmalen", 15);
            Probopass.AddAttack("Ohnmächtig werden", 1000);
            Probopass.AddAttack("Maschine sein", 60);
            Probopass.AddAttack("Klausuren genie", 40);
            Center.AddPokemon(Probopass);
            Raffael.AssignPokemon(Probopass);

            Chill Squirtle = new Chill("[Squirtle]", "Trainer: [Roman]", 9999, 9999, 9999, 9999);
            Squirtle.AddAttack("Yung GOAT", 9999);
            Squirtle.AddAttack("Big PP", 9999);
            Squirtle.AddAttack("Domain Expansion: JigaBrain", 9999);
            Squirtle.AddAttack("Hollow Purple", 9999);
            Center.AddPokemon(Squirtle);
            Roman.AssignPokemon(Squirtle);

            Sneaky Popplio = new Sneaky("[Popplio]", "Trainer: [Ilia] ", 9, 28, 22, 18);
            Popplio.AddAttack("Ohm Gelächter", 40);
            Popplio.AddAttack("Krypto-Mining", 25);
            Popplio.AddAttack("Tipps-Geben", 30);
            Popplio.AddAttack("Vibe-Check", 15);
            Center.AddPokemon(Popplio);
            Ilia.AssignPokemon(Popplio);

            Sneaky Machamp = new Sneaky("[Machoke]", "Trainer: [Sasha]", 69, 100, 150, 150);
            Machamp.AddAttack("Haarspalterei", 70);
            Machamp.AddAttack("Alpecin-Schild", 5);
            Machamp.AddAttack("Friseur-Verweigerung", 60);
            Machamp.AddAttack("Drei-Haar antenne", 111);
            Center.AddPokemon(Machamp);
            Sasha.AssignPokemon(Machamp);

            Sneaky Leafeon = new Sneaky("[Leafeon]", "Trainer: [Kathy]", 36, 77, 80, 33);
            Leafeon.AddAttack("Insulin Injektion", 45);
            Leafeon.AddAttack("Zucker Entzug", 30);
            Leafeon.AddAttack("Glukose-Schock", 50);
            Leafeon.AddAttack("Blutzucker-Messung", 15);
            Center.AddPokemon(Leafeon);
            Kathy.AssignPokemon(Leafeon);

            Sneaky Meowth = new Sneaky("[Meowth]", "Trainer: [Azzeddine]", 20, 49, 36, 28);
            Meowth.AddAttack("Krücken-Konter", 30);
            Meowth.AddAttack("Humpeln", 15);
            Meowth.AddAttack("Gips-Projektil", 60);
            Meowth.AddAttack("Ragebait", 100);
            Center.AddPokemon(Meowth);
            Azzeddine.AssignPokemon(Meowth);

            Sneaky Arceus = new Sneaky("[Arceus]", "Trainer: [Aikut]", 1000, 1000, 1000, 1000);
            Arceus.AddAttack("PrivatJet-Sturzflug", 1000);
            Arceus.AddAttack("Snack-Schild", 1000);
            Arceus.AddAttack("CEO-Mindset", 1000);
            Arceus.AddAttack("Geld-Kanone", 1000);
            Center.AddPokemon(Arceus);
            Aikut.AssignPokemon(Arceus);

            Chaotic Pantifrost = new Chaotic("[Pantifrost]", "Trainer: [Pantifrost]", 39, 78, 69, 30);
            Pantifrost.AddAttack("Rosenkohl-Wurf", 60);
            Pantifrost.AddAttack("Foil-Flex", 40);
            Pantifrost.AddAttack("Booster-Rausch", 30);
            Pantifrost.AddAttack("Mint-Zustand", 20);
            Center.AddPokemon(Pantifrost);
            Chris.AssignPokemon(Pantifrost);

            Chaotic Bisasam = new Chaotic("[Bisasam]", "Trainer: [Vanessa]", 10, 30, 19, 23);
            Bisasam.AddAttack("Babybel-Randale", 30);
            Bisasam.AddAttack("Käserad-Walzer", 60);
            Bisasam.AddAttack("Locken-Verhedderung", 45);
            Bisasam.AddAttack("Hasan-Mobben", 100);
            Center.AddPokemon(Bisasam);
            Vanessa.AssignPokemon(Bisasam);

            Chaotic Dugtrio = new Chaotic("[Alolan Dugtrio]", "Trainer: [Josi]", 33, 50, 25, 25);
            Dugtrio.AddAttack("Hormon-Overflow", 60);
            Dugtrio.AddAttack("Linux-Vortrag", 15);
            Dugtrio.AddAttack("Drunken-Fist", 40);
            Dugtrio.AddAttack("Drug-Shot", 60);
            Center.AddPokemon(Dugtrio);
            Josi.AssignPokemon(Dugtrio);

            Chaotic Maboyystiff = new Chaotic("[Maboyystiff]", "Trainer: [Daniel]", 60, 100, 35, 75);
            Maboyystiff.AddAttack("Fötzen-Uhr", 75);
            Maboyystiff.AddAttack("Dädsch-Dämpfer", 45);
            Maboyystiff.AddAttack("„Mahrgwardt, dor Gaffee griescht!", 100);
            Maboyystiff.AddAttack("Eierschecken-Energie", 25);
            Center.AddPokemon(Maboyystiff);
            Daniel.AssignPokemon(Maboyystiff);

            Chaotic Swalot = new Chaotic("[Swalot]", "Trainer: [Aman]", 100, 100, 100, 100);
            Swalot.AddAttack("Süß-sein", 100);
            Swalot.AddAttack("Stecher", 100);
            Swalot.AddAttack("Geile sau", 100);
            Swalot.AddAttack("Strahlende-Persöhnlichkeit", 100);
            Center.AddPokemon(Swalot);
            Aman.AssignPokemon(Swalot);

            // Team WH, they be lurking around ready to yoink someone's pokeon
            RocketTeam = new TeamWH("Team WH");
            Chaotic rocketGuardPoke = new Chaotic("[Team WH Grunt]", "Trainer: [Team WH]", 50, 100, 60, 50);
            rocketGuardPoke.AddAttack("Yoink Slam", 50);
            rocketGuardPoke.AddAttack("Sneaky Snatch", 40);
            rocketGuardPoke.AddAttack("Cheap Shot", 60);
            rocketGuardPoke.AddAttack("Bounce", 30);
            RocketTeam.AssignPokemon(rocketGuardPoke);
            RocketGuard = rocketGuardPoke;
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

        public void StartBattle(Trainer trainer)
        {
            List<Pokemon> all = Center.GetAllPokeon();

            if (all.Count == 0)
            {
                Console.Clear();
                ConsoleUI.DrawFrame("🥊 Start Battle", new[] { "There are no Pokémon in the center to battle.", "", "Press any key to continue..." }, ConsoleColor.Cyan, ConsoleColor.Yellow);
                Console.ReadKey(true);
                return;
            }

            Pokemon fighter;

            if (trainer != null && trainer.ass_poke.Count > 0)
            {
                fighter = trainer.ChoosePokemonFromTeam();
                if (fighter == null)
                {
                    return;
                }
            }
            else
            {
                Console.Clear();
                List<string> fighterLines = new List<string>();
                for (int i = 0; i < all.Count; i++)
                {
                    fighterLines.Add($"[{i + 1}] {all[i].Name} - HP: {all[i].GetCurrentHp()}/{all[i].GetMaxHp()}");
                }
                ConsoleUI.DrawFrame("🥊 Choose your fighter", fighterLines, ConsoleColor.Cyan, ConsoleColor.Yellow);

                fighter = all[ReadNumber(1, all.Count) - 1];
            }

            List<Pokemon> enemyOptions = all.Where(p => p != fighter).ToList();
            if (enemyOptions.Count == 0)
            {
                Console.Clear();
                ConsoleUI.DrawFrame("🎯 Choose your enemy", new[] { "No enemy Pokémon available.", "", "Press any key to continue..." }, ConsoleColor.Red, ConsoleColor.Yellow);
                Console.ReadKey(true);
                return;
            }

            Console.Clear();
            List<string> enemyLines = new List<string>();
            for (int i = 0; i < enemyOptions.Count; i++)
            {
                enemyLines.Add($"[{i + 1}] {enemyOptions[i].Name} - HP: {enemyOptions[i].GetCurrentHp()}/{enemyOptions[i].GetMaxHp()}");
            }
            ConsoleUI.DrawFrame("🎯 Choose your enemy", enemyLines, ConsoleColor.Red, ConsoleColor.Yellow);

            Pokemon enemy = enemyOptions[ReadNumber(1, enemyOptions.Count) - 1];

            Fight(fighter, enemy);
        }

        public void RocketEncounter(Trainer trainer)
        {
            bool hadPokemon = trainer.HasPokemon();
            List<string> stealLines = RocketTeam.StealPokemon(trainer);

            if (!hadPokemon)
            {
                Console.Clear();
                stealLines.Add(string.Empty);
                stealLines.Add("Press any key to continue...");
                ConsoleUI.DrawFrame("🕵️ Team WH Ambush", stealLines, ConsoleColor.Magenta, ConsoleColor.Yellow);
                Console.ReadKey(true);
                return;
            }

            // everything Team WH is holding except their own guard pokemon is loot they just stole
            List<Pokemon> stolenPokemon = RocketTeam.ass_poke.Where(p => p != RocketGuard).ToList();

            stealLines.Add(string.Empty);
            stealLines.Add("---> Press [Y] to fight for your pokeon back, [N] to walk away <---");

            Console.Clear();
            ConsoleUI.DrawFrame("🕵️ Team WH Ambush", stealLines, ConsoleColor.Magenta, ConsoleColor.Yellow);
            ConsoleKey key = Console.ReadKey(true).Key;

            if (key != ConsoleKey.Y)
            {
                Console.Clear();
                ConsoleUI.DrawFrame("🕵️ Team WH Ambush", new[] { $"{trainer.Name} chickens out for now, Team WH keeps the loot...", "", "Press any key to continue..." }, ConsoleColor.Magenta, ConsoleColor.Yellow);
                Console.ReadKey(true);
                return;
            }

            List<Pokemon> ownOptions = Center.GetAllPokeon().Where(p => !RocketTeam.ass_poke.Contains(p)).ToList();

            if (ownOptions.Count == 0)
            {
                Console.Clear();
                ConsoleUI.DrawFrame("🕵️ Team WH Ambush", new[] { "No pokeon left in the center to fight with, come back later.", "", "Press any key to continue..." }, ConsoleColor.Magenta, ConsoleColor.Yellow);
                Console.ReadKey(true);
                return;
            }

            Console.Clear();
            List<string> ownLines = new List<string>();
            for (int i = 0; i < ownOptions.Count; i++)
            {
                ownLines.Add($"[{i + 1}] {ownOptions[i].Name} - HP: {ownOptions[i].GetCurrentHp()}/{ownOptions[i].GetMaxHp()}");
            }
            ConsoleUI.DrawFrame("🕵️ Choose your fighter to win your pokeon back", ownLines, ConsoleColor.Magenta, ConsoleColor.Yellow);

            Pokemon championPick = ownOptions[ReadNumber(1, ownOptions.Count) - 1];
            Pokemon rocketFighter = RocketGuard;
            rocketFighter.Heal(); // patch em up so every ambush is a fair fight

            Fight(championPick, rocketFighter);

            List<string> outcomeLines = new List<string>();

            if (rocketFighter.IsDefeated() && !championPick.IsDefeated())
            {
                outcomeLines.Add("You beat Team WH!! Here's your pokeon back.");
                foreach (Pokemon p in stolenPokemon)
                {
                    RocketTeam.ass_poke.Remove(p);
                    trainer.AssignPokemon(p);
                }
            }
            else
            {
                outcomeLines.Add("Team WH keeps your pokeon for now, git gud and try again.");
            }

            outcomeLines.Add(string.Empty);
            outcomeLines.Add("Press any key to continue...");

            Console.Clear();
            ConsoleUI.DrawFrame("🕵️ Ambush Result", outcomeLines, ConsoleColor.Magenta, ConsoleColor.Yellow);
            Console.ReadKey(true);
        }

        private void Fight(Pokemon me, Pokemon enemy)
        {
            Console.Clear();
            ConsoleUI.DrawFrame("⚔️ BATTLE START", new[]
            {
                $"{me.Name} VS {enemy.Name}",
                me.GetBattleStatus(),
                enemy.GetBattleStatus(),
                "",
                "Press any key to continue..."
            }, ConsoleColor.Red, ConsoleColor.Yellow);
            Console.ReadKey(true);

            int round = 1;
            List<string> turnSummary = new List<string>();

            while (!me.IsDefeated() && !enemy.IsDefeated())
            {
                Console.Clear();

                List<string> roundLines = new List<string>(turnSummary);
                if (turnSummary.Count > 0)
                {
                    roundLines.Add(string.Empty);
                }
                roundLines.Add($"--- Round {round} ---");
                roundLines.Add($"{me.Name}: HP {me.GetCurrentHp()}/{me.GetMaxHp()}");
                roundLines.Add($"{enemy.Name}: HP {enemy.GetCurrentHp()}/{enemy.GetMaxHp()}");
                roundLines.Add(string.Empty);
                roundLines.Add("Choose your attack:");
                for (int i = 0; i < me.attacks.Count; i++)
                {
                    roundLines.Add($"[{i + 1}] {me.attacks[i].Name} [{me.attacks[i].Damage} dmg]");
                }
                ConsoleUI.DrawFrame("🎮 Choose your attack", roundLines, ConsoleColor.Cyan, ConsoleColor.Yellow);

                Attack playerAttack = me.attacks[ReadNumber(1, me.attacks.Count) - 1];
                enemy.TakeDamage(playerAttack.Damage);

                turnSummary = new List<string> { $"{me.Name} uses {playerAttack.Name}!" };

                if (enemy.IsDefeated())
                {
                    break;
                }

                Attack enemyAttack = enemy.attacks[random.Next(enemy.attacks.Count)];
                me.TakeDamage(enemyAttack.Damage);

                turnSummary.Add($"{enemy.Name} uses {enemyAttack.Name}!");
                turnSummary.Add($"{me.Name} HP: {me.GetCurrentHp()}/{me.GetMaxHp()}");
                turnSummary.Add($"{enemy.Name} HP: {enemy.GetCurrentHp()}/{enemy.GetMaxHp()}");

                round++;
            }

            Console.Clear();

            List<string> resultLines = new List<string>(turnSummary);
            if (turnSummary.Count > 0)
            {
                resultLines.Add(string.Empty);
            }

            if (enemy.IsDefeated() && !me.IsDefeated())
            {
                resultLines.Add($"🏆 {me.Name} wins the battle!");
            }
            else if (me.IsDefeated() && !enemy.IsDefeated())
            {
                resultLines.Add($"🏆 {enemy.Name} wins the battle!");
            }
            else
            {
                resultLines.Add("🤝 It's a draw! Both Pokémon are down.");
            }

            resultLines.Add($"{me.Name}: HP {me.GetCurrentHp()}/{me.GetMaxHp()}");
            resultLines.Add($"{enemy.Name}: HP {enemy.GetCurrentHp()}/{enemy.GetMaxHp()}");
            resultLines.Add(string.Empty);
            resultLines.Add("Press any key to continue...");

            ConsoleUI.DrawFrame("🏁 BATTLE RESULT", resultLines, ConsoleColor.Green, ConsoleColor.Yellow);
            Console.ReadKey(true);
        }
    }
}

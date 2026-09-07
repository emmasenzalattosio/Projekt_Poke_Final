using System;

namespace Poke_Proje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Emoji();

            Arena arena = new Arena();

            NiceCute menu = new NiceCute(arena.Center, arena);
            menu.Start();
        }

        static void Emoji()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
        }
    }
}

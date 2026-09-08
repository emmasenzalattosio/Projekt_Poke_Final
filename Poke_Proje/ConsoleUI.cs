using System;
using System.Collections.Generic;
using System.Linq;

namespace Poke_Proje
{
    public static class ConsoleUI
    {
        public static void WriteCentered(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                Console.WriteLine();
                return;
            }

            string[] lines = text.Split(new[] { "\r\n", "\n" }, StringSplitOptions.None);

            int maxWidth = lines.Max(line => line.Length);

            int leftPadding = Math.Max(0, (Console.WindowWidth - maxWidth) / 2);

            foreach (string line in lines)
            {
                Console.WriteLine(new string(' ', leftPadding) + line);
            }
        }

        public static void WriteCenteredHighlighted(string text, bool selected, int boxWidth = 30)
        {
            string display = selected ? $"> {text}" : $"  {text}";
            display = display.PadRight(boxWidth);

            int leftPadding = Math.Max(0, (Console.WindowWidth - boxWidth) / 2);

            Console.Write(new string(' ', leftPadding));

            if (selected)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
            }

            Console.Write(display);

            if (selected)
            {
                Console.ResetColor();
            }

            Console.WriteLine();
        }

        public static void WriteCenteredScreen(string title, IEnumerable<string> lines, ConsoleColor titleColor = ConsoleColor.Yellow)
        {
            if (!string.IsNullOrWhiteSpace(title))
            {
                Console.ForegroundColor = titleColor;
                WriteCentered(title.Trim());
                Console.ResetColor();
                WriteCentered(string.Empty);
            }

            foreach (string line in lines)
            {
                WriteCentered(line ?? string.Empty);
            }
        }

        /// <summary>
        /// Prints one or more "banner" blocks of ASCII art/text followed by a selectable
        /// menu list, all centered on screen (no border).
        /// </summary>
        /// <param name="bannerBlocks">Any number of multi-line text blocks to show above the menu (e.g. logo art). Pass none if not needed.</param>
        public static void WriteCenteredMenu(string title, IEnumerable<string> items, int selectedIndex, ConsoleColor titleColor = ConsoleColor.Yellow, params string[] bannerBlocks)
        {
            List<string> lines = new List<string>();

            if (bannerBlocks != null)
            {
                foreach (string block in bannerBlocks)
                {
                    if (string.IsNullOrEmpty(block))
                    {
                        continue;
                    }

                    lines.AddRange(block.Split(new[] { "\r\n", "\n" }, StringSplitOptions.None));
                    lines.Add(string.Empty);
                }
            }

            List<string> options = items.ToList();
            for (int i = 0; i < options.Count; i++)
            {
                string prefix = i == selectedIndex ? "▶" : " ";
                lines.Add($"{prefix} {options[i]}");
            }

            WriteCenteredScreen(title, lines, titleColor);
        }
    }
}

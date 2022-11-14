using System;
using System.Text.RegularExpressions;

namespace EditorHTML
{
    public class Viewer
    {
        public static void Show(string text)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            Console.WriteLine("MODO EDITOR");
            Console.WriteLine("----------");

        }

        public static void Replace(string text)
        {
            var strong = new Regex("");
        }

    }

}
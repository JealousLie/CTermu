using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CTermu
{
    public static class Config
    {
        // Console color specificatoin
        public static ConsoleColor ErrorColor { get; private set; }
        public static ConsoleColor WarningColor { get; private set; }
        public static ConsoleColor InfoColor { get; set; }

        public static string Path { get; private set; }

        public static void CheckConfig()
        {
            if (!(File.Exists(@"C:\Program Files\CTermu\Config.termu")))
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("No config File found! Prepearing to create a new one ...");
                Console.ResetColor();
            }
            else
            {
                LoadConfig(@"C:\Program Files\CTermu\Config.termu");
            }
            Path = "Test";
        }

        private static void LoadConfig(string cfgPath)
        {
            // Implement Configuration loading
        }

        private static void CreateConfig()
        {
        }
    }
}

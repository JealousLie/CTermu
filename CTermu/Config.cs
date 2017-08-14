using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CTermu
{
    public class Config
    {
        public Config() : this(ConsoleColor.Red, ConsoleColor.Yellow, ConsoleColor.Green, ConsoleColor.Blue, ConsoleColor.Magenta, @"C:\Program Files\CTermu\Config.termu")
        {
        }
        public Config(ConsoleColor error, ConsoleColor warning, ConsoleColor info, ConsoleColor folder, ConsoleColor file) : this(error, warning, info, folder, file,
            @"C:\Program Files\CTermu\Config.termu")
        {
        }
        public Config(ConsoleColor error, ConsoleColor warning, ConsoleColor info, ConsoleColor folder, ConsoleColor file, string configPath)
        {
            ErrorColor = error;
            WarningColor = warning;
            InfoColor = info;
            FolderColor = folder;
            FileColor = file;
            ConfigPath = configPath;
        }
        // Console color specificatoin
        public ConsoleColor ErrorColor { get; private set; }     // Red
        public ConsoleColor WarningColor { get; private set; }   // Yellow
        public ConsoleColor InfoColor { get; set; }              // Green
        public ConsoleColor FolderColor { get; set; }
        public ConsoleColor FileColor { get; set; }
        public string ConfigPath { get; private set; }

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
            // Implement creation of configuration
        }
    }
}

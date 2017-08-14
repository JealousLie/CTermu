using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CTermu
{
    // Enhält alle Methoden, welche im privaten Dictionary 'CommandList' aufgeführt sind.
    public static class Commands
    {
        private static Config _Configuration;
        private static Config Configuration
        {
            get { return _Configuration; }
            set
            {
                if(value == null)
                {
                    throw new NullReferenceException();
                }
                else
                {
                    _Configuration = value;
                }
            }
        }
        public static void Echo(string[] args)
        {
            foreach (string item in args)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public static void Exit(string[] args)
        {
            Environment.Exit(0);
        }

        public static void ChangeDirectory(string[] args)
        {
            string targetDir = args.First();
            try
            {
                Environment.CurrentDirectory = targetDir;
            }
            catch (IOException)
            {
                Console.ForegroundColor = Configuration.ErrorColor;
                Console.WriteLine("Target Device/Directory didn't respond!");
                Console.ResetColor();
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Permission denied");
            }
        }

        // Needs further implementation. Like "ls -l" which prints out size, date/time last modified and filename
        public static void List(string[] args)
        {
            foreach (string item in Directory.GetDirectories(Environment.CurrentDirectory))
            {
                Console.ForegroundColor = Configuration.FolderColor;
                string directory = item.Split(new string[] { @"\" }, StringSplitOptions.None).Last().ToString();
                Console.WriteLine(directory);
                Console.ResetColor();
            }
            foreach (string item in Directory.GetFiles(Environment.CurrentDirectory))
            {
                Console.ForegroundColor = Configuration.FileColor;
                string dicFile = item.Split(new string[] { @"\" }, StringSplitOptions.None).Last().ToString();
                Console.WriteLine(dicFile);
                Console.ResetColor();
            }
        }

        public static void Clear(string[] args)
        {
            Console.Clear();
        }
    }
}

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
                Console.WriteLine("Target Device/Directory didn't respond!");
            }
        }

        public static void List(string[] args)
        {
            foreach (string item in Directory.GetDirectories(Environment.CurrentDirectory))
            {
                string directory = item.Split(new string[] { @"\" }, StringSplitOptions.None).Last().ToString();
                Console.WriteLine(directory);
            }
            foreach (string item in Directory.GetFiles(Environment.CurrentDirectory))
            {
                string dicFile = item.Split(new string[] { @"\" }, StringSplitOptions.None).Last().ToString();
                Console.WriteLine(dicFile);
            }
        }
    }
}

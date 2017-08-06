using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTermu
{
    class Termu
    {
        public Termu()
        {
            Config.CheckConfig();
            AwaitCommand();
        }

        /// <summary>
        /// Setzt das Terminal in einen Wartezustand.
        /// </summary>
        /// <param name="interrupKey">Die Taste zum beenden vom Idle-State.</param>
        public void Idle(ConsoleKey interrupKey)
        {
            Console.Clear();
            Console.ResetColor();
            Console.WriteLine("Idle\n" +
                "Press " + interrupKey.ToString() + " to continue ...");
            while (Console.ReadKey().Key != interrupKey)
            {
                Console.ReadLine();
            }
        }

        public void AwaitCommand()
        {
            while (true)
            {
                Console.Write("$ ");
                string command = Console.ReadLine();
                string command_main = command.Split(new char[] { ' ' }).First();
                string[] arguments = command.Split(new char[] { ' ' }).Skip(1).ToArray();
                if (CommandList.ContainsKey(command_main))
                {
                    Action<string[]> function_to_execute = null;
                    CommandList.TryGetValue(command_main, out function_to_execute);
                    function_to_execute(arguments);
                }
                else
                {
                    Console.WriteLine("Command '" + command_main + "' is not a valid command.");
                }
            }
        }

        private static void Help(string[] args)
        {
            // Implement Help Function
        }

        

        /// <summary>
        /// Eine Wörterbuch, welches einen String und die dazugehörige Funktion beschreibt.
        /// </summary>
        private static Dictionary<string, Action<string[]>> CommandList = new Dictionary<string, Action<string[]>>
        {
            { "help", Help },
            { "echo", Commands.Echo}
        };
    }
}

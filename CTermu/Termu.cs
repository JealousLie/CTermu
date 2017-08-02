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

        }

        private void ChangeMode()
        {
        }

        public string[] Help()
        {
            return new string[0];
        }

        private bool CheckIfFirstTime()
        {
            return true;
        }
    }
}

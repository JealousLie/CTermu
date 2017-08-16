using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTermu
{
    class MenuSystem
    {
        /*
        public string Question { get; set; } = { "Bildskalierung ändern?" };
        public string[] Options { get; set; } = { "yes", "no" };
        public int MaxWidth { get; set; }
        public int MaxHeight { get; set; }
        

        /////////////////////////////////////
        // Test Aufbau                     //
        // Verbesserungswürdig :)          //
        /////////////////////////////////////

        static void Main(string[] args)
        {
            string Question = "Bildskalierung ändern?";
            string[] Options = { "yes", "no", "Bestimmt größer als die frage, alles andere ist unlogisch", "nicht größer" };
            int menuWidth = (Question.Length);

            for (int i = 0; i != Options.Length; i++)
            {

                string temp = Options[i];

                if (menuWidth < temp.Length)
                {

                    menuWidth = temp.Length;

                }

            }
            Console.WriteLine(menuWidth);
            string line = new string('-', menuWidth +4);
            string space = new string(' ', menuWidth - Question.Length);
            Console.WriteLine(space);
            Console.WriteLine(line+ "\n| " + Question + space + " |\n" + line);
            
            for (int i = 0; i < Options.Length; i++)
            {
                string temp = Options[i];
                string spaceO = new string(' ', menuWidth - temp.Length);
                Console.Write("> " + Options[i] + spaceO + " |\n");
            }
            Console.WriteLine(line);
            Console.ReadKey();
        }     
        */




    }
}

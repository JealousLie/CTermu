using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}

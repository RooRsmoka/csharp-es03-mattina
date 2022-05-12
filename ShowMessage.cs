using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_es03_mattina
{
    internal class ShowMessage
    {
        public static void AppendMessage(string sTesto)
        {
            // Prima implementazione (ricorsiva)
            //if (sTesto.Length > 10)
            //{
            //    Console.WriteLine(sTesto.Substring(0, 10));
            //    AppendMessage(sTesto.Substring(10));
            //} else
            //{
            //    Console.WriteLine(sTesto);
            //}

            // Seconda implementazione (iterattiva)
            //while (sTesto.Length > 10)
            //{
            //    Console.WriteLine(sTesto.Substring(0, 10));
            //    sTesto = sTesto.Substring(10);
            //}
            //Console.WriteLine(sTesto);

            // Terza implementazione
            int iPos = 0;
            foreach (char c in sTesto)
            {
                if (iPos == 10)
                {
                    Console.WriteLine();
                    iPos = 0;
                }
                Console.Write(c);
                iPos++;
            }
        }
    }
}

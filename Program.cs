using System;

namespace csharp_es03_mattina
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShowMessage.AppendMessage("Nel mezzo del cammin di nostra vita, mi ritrovai per una selva oscura...");

            {
                int iValore;
                //while (int.TryParse(Console.ReadLine(), out iValore))
                string sValore = Console.ReadLine();
                iValore = Convert.ToInt32(sValore);
                while (iValore != 0)
                {
                    Console.WriteLine(Borsellino.Add(iValore));
                    sValore = Console.ReadLine();
                    iValore = Convert.ToInt32(sValore);
                }
            }
            {
                Salvadanaio salva1 = new Salvadanaio();
                Salvadanaio salva2 = new Salvadanaio();
                int iValore;
                while (int.TryParse(Console.ReadLine(), out iValore))
                {
                    Console.WriteLine("Salvadanaio n°1: {0}", salva1.Add(iValore));
                    iValore = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Salvadanaio n°2: {0}", salva2.Add(iValore));
                }
            }
        }
    }
}

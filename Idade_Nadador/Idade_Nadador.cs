using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idade_Nadador
{
    internal class Idade_Nadador
    {
        static void Main(string[] args)
        {
    
            Denovo();
               
        }
        public static void Denovo()
        {
            int Idade;

            Console.WriteLine("Digite a idade do nadador:");
            Idade = int.Parse(Console.ReadLine());

            if (Idade >= 5 && Idade <= 7)
            {
                Console.Write("O nadador e do grupo: \t");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Infantil A \n");
                Console.ResetColor();
            }
            if (Idade >= 8 && Idade <= 11)
            {
                Console.Write("O nadador e do grupo: \t");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Infaltil B \n");
                Console.ResetColor();
            }
            if (Idade == 12 || Idade == 13)
            {
                Console.Write("O nadador e do grupo: \t");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Juvenil A \n");
                Console.ResetColor();
            }
            if (Idade >= 14 && Idade <= 17)
            {
                Console.Write("O nadador e do grupo: \t");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Juvenil B \n");
                Console.ResetColor();
            }
            if (Idade >= 18)
            {
                Console.Write("O nadador e do grupo: \t");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Adultos \n");
                Console.ResetColor();
            }

            Denovo();
        }
    }
}

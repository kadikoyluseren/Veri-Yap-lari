
// ÖĞRENCİ NUMARASI : 16253037
// AD SOYAD : SEREN KADIKÖYLÜ

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1VY16253037
{
    class Program
    {
        static void Main(string[] args)
        {
            string cumle;
            Console.Write("Bir cumle girin: ");
            cumle = Console.ReadLine();

            Palindrom pal = new Palindrom();
            cumle = pal.boslukNoktalamaSil(cumle);

            Stack<char> stk = new Stack<char>();
            stk = pal.cumleToStack(cumle);

            Queue<char> que = new Queue<char>();
            que = pal.cumleToQueue(cumle);

            pal.Karsilastir(stk, que);

        }
    }
}

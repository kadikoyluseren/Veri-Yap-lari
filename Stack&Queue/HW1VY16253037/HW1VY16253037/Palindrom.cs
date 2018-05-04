using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace HW1VY16253037
{
    class Palindrom
    {
        public string boslukNoktalamaSil(string cumle)
        {
            cumle = cumle.ToLower();
            cumle = Regex.Replace(cumle, @"(\p{P})", "");
            cumle = cumle.Replace(" ", "");
            return cumle;
        }

        public Stack<char> cumleToStack(string cumle)
        {
            Stack<char> stk = new Stack<char>();
            for (int i = 0; i < cumle.Length; i++)
            {
                stk.Push(cumle[i]);
            }
            return stk;
        }

        public Queue<char> cumleToQueue(string cumle)
        {
            Queue<char> que = new Queue<char>();
            for (int i = 0; i < cumle.Length; i++)
            {
                que.Enqueue(cumle[i]);
            }
            return que;
        }

        public void Karsilastir(Stack<char> stk, Queue<char> que)
        {
            int i = 0;
            int j=stk.Count;
            while (stk.Count!=0)
            {
                if (stk.Pop() == que.Dequeue())
                    ++i;
                else
                {
                    Console.WriteLine("Ifade palindrom degildir!");
                    break;
                }
            }
            if(i==j)
                Console.WriteLine("Ifade palindromdur!");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace toBase2List {
    class main {
        static void Main(string[] args) {
            digitRand c = new digitRand();
            digitRand2 c2 = new digitRand2();
            uniformDistribution f = new uniformDistribution();
            for (int i = 1; i <= 30; i++)
            {
                Console.WriteLine("Вариант: " + i);
                Console.WriteLine("===================");
                Console.WriteLine("Равномерность:");
                f.getXUniformDistr(i);
                Console.WriteLine("Случайность чисел:");
                c2.iGetAnswer(i);
                Console.WriteLine("Случайность разрядов:");
                c.iGetAnswer(i);
                Console.WriteLine("===================");
            }
            Console.ReadLine();
        }

    }
}

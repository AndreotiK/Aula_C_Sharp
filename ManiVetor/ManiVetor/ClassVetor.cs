using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManiVetor
{
    class ClassVetor
    {
        public void teste1()
        {
            int[] Vetor = { 100, 200, 300, 400, 500, 600, 700, 800, 900, 1000 };

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("pos {0} : {1}", i, Vetor[i]);
                Task.Delay(1000).Wait();
            }
            Console.ReadKey();
        }
        public void teste2()
        {
            int[] Vetor = { 100, 200, 300, 400, 500, 600, 700, 800, 900, 1000 };

            for (int i = 0; i < Vetor.Length; i++)
            {
                Console.WriteLine("pos {0} : {1}", i, Vetor[i]);
                Task.Delay(1000).Wait();
            }
            Console.ReadKey();
        }
        public void teste3()
        {
            int[] Vetor = { 100, 200, 300, 400, 500, 600, 700, 800, 900, 1000 };

            foreach (int var in Vetor)
            {
                Console.WriteLine("vetor: " + var);
                Task.Delay(1000).Wait();
            }
            Console.ReadKey();
        }
    }
}

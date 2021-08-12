using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Aplicação__12_08_
{
    class Program
    {
        public static void ManVar()
        {
            int D1 = -47800;//32bit
            uint D2 = 80000;//32bit sem sinal
            short D3 = -12800;//16bit
            ushort D4 = 55000;//16bit sem sinal
            long D5 = -10400700;//64bit
            ulong D6 = 10400700L;//64bit sem sinal
            string Nome = "Pedro Henrique Scapin";



            Console.WriteLine("Int com sinal : " + D1);
            Console.WriteLine("Int sem sinal : " + D2);
            Console.WriteLine("Short com sinal : " + D3);
            Console.WriteLine("Short sem sinal : " + D4);
            Console.WriteLine("Long com sinal : " + D5);
            Console.WriteLine("Long sem sinal : " + D6);
            Console.WriteLine("String : " + Nome);



            Console.ReadKey();
        }




    }
}
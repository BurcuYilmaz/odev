using System;

namespace Odev2
{
    class Program : islem
    {
        public override int Toplama(int a, int b)
        {
            return a + b;
        }
        public override int Carpma(int a, int b)
        {
            return a * b;
        }
        public override int Bolme(int a, int b)
        {
            return a / b;
        }
        public override int Cikarma(int a, int b)
        {
            return a - b;
        }
        static void Main(string[] args)
        {
            Program p = new Program();

            Console.WriteLine("toplam:" +p.Toplama(8,7));
            Console.WriteLine("Çarpma:" + p.Carpma(8, 7));
            Console.WriteLine("Çıkarma:" + p.Cikarma(8, 7));
            Console.WriteLine("Bölme:" + p.Bolme(8, 7));
            
        }

    }
}

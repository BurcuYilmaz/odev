using System;

namespace Odev1
{
    public class Program : islem
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Toplama(5, 6);
            p.Cikarma(8, 9);
            p.Bolme(9, 3);
            p.Carpma(2, 5, 7);
            Console.WriteLine("Toplama :" +p.Toplama(5, 6));
            Console.WriteLine("Cikarma :" + p.Cikarma(8, 9));
            Console.WriteLine("Bolme :" + p.Bolme(9, 3));
            Console.WriteLine("Carpma :" + p.Carpma(2, 5, 7));
        }
    }
}

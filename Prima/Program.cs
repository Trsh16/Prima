using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prima
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan bilangan : ");
            int bilangan = Convert.ToInt32(Console.ReadLine());
            string hasil;
            int n = 0;
            for (int i = 1; i <= bilangan; i++)
            {
                int bil = bilangan % i;
                if (bil == 0)
                    n = n + 1;
                else
                    n = n;
            }
            if (n > 2)
                hasil = "bukan bilangan prima";
            else
                hasil = "bilangan prima";
            Console.WriteLine("Jadi bilangan adalah : " + hasil);
            Console.ReadKey();
        }
    }
}

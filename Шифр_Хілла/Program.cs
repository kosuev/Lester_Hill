using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Шифр_Хілла
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your key");
            string key = Console.ReadLine();
            Mat(key);
            Console.ReadKey();
        }

        static void Mat(string key)
        {
            int k = key.Length;
           if (k < 9)                            //доповнюємо повідомлення
                for (int i = 0; i <= 9 - k; i++)
                    key = key + ".";
            Console.WriteLine(key);

            int[,] Mat = new int[3, 3];
            int n = 0;
            for (int i = 0; i < 3; i++)
            for (int j = 0; j < 3; j++)
                {                    
                    Mat[i, j] = Convert.ToInt16(key[n]);
                    Console.Write(Mat[i, j]);
                    if (j == 2)
                        Console.Write("\n");
                    n++;
                }
        }
    }
}

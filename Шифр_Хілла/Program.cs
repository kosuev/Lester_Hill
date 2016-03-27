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
            Console.WriteLine("Enter your key:");
            string key = Console.ReadLine();
            Console.WriteLine("Enter your message:");
            Console.Write("\n");
            string text = Console.ReadLine();
            Shifr(key, text);
            Console.ReadKey();
        }

        static void Shifr(string key, string msg)
        {
            int k = key.Length;
            int[] zt=new int[3];
            if (k < 9)                            //доповнюємо повідомлення
            {
                for (int i = 0; i <= 9 - k; i++)
                    key = key + ".";
                Console.WriteLine("Key: "+key);
            }

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
                    zt[i]+= Mat[i, j] * msg[j];
                }
            Console.WriteLine("\nCrypted text: "+"\n"+Convert.ToChar(zt[0]%127)+ Convert.ToChar(zt[1]%127)+ Convert.ToChar(zt[2]%127));
            
                   
        }

        static int Det(string key)
        {
            int k = key.Length;
            if (k < 9)                            //доповнюємо повідомлення
            {
                for (int i = 0; i <= 9 - k; i++)
                    key = key + ".";
            }

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
            int det_key = Mat[0, 0] * (Mat[1, 1] * Mat[2, 2] - Mat[1, 2] * Mat[2, 1]) - Mat[0, 1] * (Mat[1, 0] * Mat[2, 2] - Mat[1, 2] * Mat[2, 0]) + Mat[0, 2] * (Mat[1, 0] * Mat[2, 1] - Mat[1, 1] * Mat[2, 0]);
            while (det_key < 0)
                det_key += 175;
            Console.WriteLine(det_key);
            return det_key;
        }

    }
}

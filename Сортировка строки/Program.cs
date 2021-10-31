using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static string random = "frGref32Y4P32I3GrN2yBugvB3irAwxRndUYgbcRa8";
        static string alpha = "abcdefghijklmnopqrstuvwxyz";
        static string beta = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        static string gamma = "1234567890";
        static string omega = "№;%:?*!@#$%^&*()_+-=";
        static string a = string.Empty;
        static string b = string.Empty;
        static string g = string.Empty;
        static string o = string.Empty;
        
        static void Main(string[] args)
        {
            int[] g11 = new int[1000];
            string GG = string.Empty;
            
            for (int x = 0; x < random.Length; x++)
            {
                for (int y = 0; y < alpha.Length; y++)
                {
                    if(random[x] == alpha[y])
                    {
                        a += random[x];
                    }
                }
            }

            Console.WriteLine("Маленькие буквы: " + Character(a));
            Console.WriteLine("");

            
            

            for (int x = 0; x < random.Length; x++)
            {
                for (int y = 0; y < beta.Length; y++)
                {
                    if (random[x] == beta[y])
                    {
                        b += random[x];
                    }
                }
            }
            Console.WriteLine("Большие буквы: " + CharacterB(b));
            Console.WriteLine("");
            
            for (int x = 0; x < random.Length; x++)
            {
                for (int y = 0; y < gamma.Length; y++)
                {
                    if (random[x] == gamma[y])
                    {
                        g += random[x];

                    }
                }
            }
            int temp;
            int Col = g.Length;
            int[] mas = new int[Col];
            int x5 = 0;
            while ( x5 < mas.Length)
            {
                for (int u = 0; u < g.Length;u++ )
                {
                    mas[x5] = int.Parse(g[u].ToString());
                    x5++;
                }
            }
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[i] > mas[j])
                    {
                        temp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = temp;
                    }
                }
            }
            Console.WriteLine("Цифры: ");
            for(int x = 0; x < mas.Length;x++)
            {
                Console.Write( + mas[x]);
            }
            for (int x = 0; x < random.Length; x++)
            {
                for (int y = 0; y < omega.Length; y++)
                {
                    if (random[x] == omega[y])
                    {
                        o += random[x];
                    }
                }
            }
            Console.ReadLine();
        }

        static string Character(string t)
        {
            
        
            string Sugar = string.Empty;
            int Index = 0;
            
            while (Index < alpha.Length)
            {
                for (int net = 0; net < t.Length; net++)
                {

                    if (t[net] == alpha[Index])
                    {

                        Sugar += t[net].ToString();
                        
                    }
                }
                Index++;
                
            }
            return Sugar;
        }
        static string CharacterB(string t)
        {
            

            string Sugar = string.Empty;
            int Index = 0;

            while (Index < beta.Length)
            {
                for (int net = 0; net < t.Length; net++)
                {

                    if (t[net] == beta[Index])
                    {

                        Sugar += t[net].ToString();

                    }
                }
                Index++;

            }
            return Sugar;
        }
    }
}

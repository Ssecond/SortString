using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static string s = "fgjhr5uy547ydrhfdhYfeqfJQ24UHHIKAFSFKHktyktyktyktkcgfndrthrt6uuy(*%^&*$%^345621#!AJokdsjfl;ek;lwerkfglwektgw4ejtoe(*&%^$R%E$^SFHCHGF%R&R";
        static string ptrc = "0123456789";
        static string ptrm = "abcdefghijklmnopqrstuvwxyz";
        static string ptrb = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        static string scrap = "~!@#$%^&*()_+|`-=\\[]{};:<>?,./№";

           static string b = string.Empty;
           static string m = string.Empty;
           static string c = string.Empty;
           static string x = string.Empty;
        static int temp;

        static void Main(string[] args)
        {
            


            

            for (int z = 0; z < s.Length; z++)
            {
                
                if (Bm(s[z]))
                {
                   
                    m += s[z].ToString();
                }

                if (Bb(s[z]))
                {
                    b += s[z].ToString();
                }

                if (C(s[z]))
                {
                    for (int g = 0;g<c.Length;c++)
                    {
                        for (int n = g+1;n < c.Length;n++)
                        {
                            if (c[g] > c[n])
                            {
                            temp = c[g];
                            c[g] = c[n];
                            c[n] = temp;
                            
                            }
                        }
                    }
                    c += s[z].ToString();
                }

                if (X(s[z]))
                    
                {
                    x += s[z].ToString();
                }
            }

            


            Console.WriteLine(b);
            Console.WriteLine(m);
            Console.WriteLine(c);
            Console.WriteLine(x);
            Console.ReadLine();

        }
        static bool Bm(char c)
        {
            
            bool v = false;
            for (int y = 0; y < ptrm.Length; y++)
            {

                if (ptrm[y] == c)
                {
                    
                    v = true;
                    break;
                }

            }

            return v;
        }

        static bool Bb(char c)
        {
            
            bool v = false;
            for (int y = 0; y < ptrb.Length; y++)
            {

                if (ptrb[y] == c)
                {
                    v = true;
                    break;
                }
            }

            return v;
        }

        static bool C(char c)
        {
            
            bool v = false;
            for (int y = 0; y < ptrc.Length; y++)
            {
                if (ptrc[y] == c)
                {
                    v = true;
                    break;
                }
            }

            return v;
        }
        static bool X(char c)
        {

            bool v = false;
            for (int y = 0; y < scrap.Length; y++)
            {
                if (scrap[y] == c)
                {
                    v = true;
                    break;
                }
            }

            return v;
        }
       
    
        
        }
    
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeTrue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a palidrome or not: ");
            try
            {
                int x = int.Parse(Console.ReadLine());

                bool pal = false;
                if (x <= -Math.Pow(2, 31) || x >= Math.Pow(2, 31))
                {
                    pal = false;
                }
                else
                {
                    int siz = x.ToString().Length; //get how many digits in the number
                    string xs = x.ToString();
                    if (xs[0] == '-')
                    {
                       xs = xs.Substring(1);
                       siz--;
                    }
                    if (siz > 1)
                    {
                        for (int i = 0; i < siz / 2; i++)
                        {

                                if (xs[i] == xs[siz - i - 1])
                                {
                                    pal = true;
                                }
                                else
                                {
                                    pal = false;
                                    break;
                                }
                            
                        }
                    }
                    else
                    {
                        pal = true;
                    }
                }
                Console.WriteLine("The number is a " + pal + " palindrome");
                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Number invalid");
                Console.ReadLine();
            }
        }
    }
}

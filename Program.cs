using System;
using System.Collections;
using System.Linq;

namespace Cube
{
    class Program
    {
        static void Main()
        {
            
            string s = "abcd";



            string t = Shuffler(s);
            AddedLetter(s, t);


            Console.ReadKey();
        }

        public static string Shuffler(string s )
        {
            Random rnd = new Random();
            char randomChar = (char)rnd.Next('a', 'z');
            Console.WriteLine("s : {0}", s);
            s += randomChar;

            string rand = new string(s.ToCharArray().OrderBy(s => (rnd.Next(2) % 2) == 0).ToArray()); ////Using LINQ
            Console.WriteLine("t : {0}",rand);

            return rand;

        }
        public static string AddedLetter(string s, string t)
        {
            char[] s1 = s.ToCharArray();
            char[] t1 = t.ToCharArray();
            var tempS1 = s1.ToList();
            var tempT1 = t1.ToList();

            string result = "";

            for (int i = 0; i < tempS1.Count; i++)
            {
                for (int j = 0; j < tempT1.Count; j++)
                {
                    if (tempS1[i] == tempT1[j])
                    {
                        tempS1.RemoveAt(i);
                        tempT1.RemoveAt(j);
                    }
                }
                i--;
            }

            foreach (var item in tempT1)
            {
                Console.WriteLine( item);
            }

            return result;
        }    
    }
}


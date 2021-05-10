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
            Console.WriteLine("s : {0}", s);

            string t = Shuffler(s);
            Console.WriteLine("t : {0}", t);
            
            AddedLetter(s, t);
            
            
            
            string s1="";
            Console.WriteLine("s : {0}", s1);
            
            string t1="y";
            Console.WriteLine("t : {0}", t1);
            
            AddedLetter(s1,t1);  //y
            
            
            
            string s2="a";
            Console.WriteLine("s : {0}", s2);
            
            string t2="aa";
            Console.WriteLine("t : {0}", t2);
            
            AddedLetter(s2,t2); //a
            
            
            
            string s3="ae";
            Console.WriteLine("s : {0}", s3);
            
            string t3="aea";
            Console.WriteLine("t : {0}", t3);
            
            AddedLetter(s3,t3); //a
            


            
            Console.ReadKey();
        }

        public static string Shuffler(string s )
        {
            Random rnd = new Random();
            char randomChar = (char)rnd.Next('a', 'z');
            s += randomChar;

            string randomString = new string(s.ToCharArray().OrderBy(s => (rnd.Next(2) % 2) == 0).ToArray()); ////Using LINQ

            return randomString;

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
                Console.WriteLine(item);
            }

            return result;
        }    
    }
}


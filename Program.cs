using System;
using System.Collections;
using System.Linq;

namespace Cube
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "abcd";
            string t = MixAndShow(s);
            AddedChar(s,t);
            


            //*Using Linq
            //Random rnd = new Random();
            //string str = "abcd";
            //char randomChar = (char)rnd.Next('a', 'z');
            //str = str + randomChar;
            //string rand = new string(str.ToCharArray().OrderBy(s => (rnd.Next(2) % 2) == 0).ToArray()); 
            //Console.WriteLine(str);
            //Console.WriteLine(rand);
           


            Console.ReadKey();
        }
        public static string MixAndShow(string s)
        {
            Random rnd = new Random();
            char randomChar = (char)rnd.Next('a', 'z');
            char[] sArray = s.ToCharArray();
            char[] randomArray = new char[sArray.Length + 1];
            randomArray[sArray.Length] = randomChar;
            int randomnumber;
            string output = "";


            for (int i = sArray.Length; i >= 1; i--)
            {
                randomnumber = rnd.Next(1, i + 1) - 1;
                randomArray[i - 1] = sArray[randomnumber];
                sArray[randomnumber] = sArray[i - 1];
            }

            Console.WriteLine("s = {0} ", s);
            Console.Write("t = ");

            foreach (char o in randomArray)
            {
                Console.Write(o) ;
            }

            return output;

        }

        public static string AddedChar ( string s, string t)
        {
            char[] s1 = s.ToCharArray();
            char[] t1 = t.ToCharArray();
            var tempS1 = s1.ToList();
            var tempT1 = t1.ToList();
            string output = "";


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
                Console.WriteLine(item.ToString());
            }

            return output;
        }
    }
}


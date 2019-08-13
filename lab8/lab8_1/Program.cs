using System;

using System.Text.RegularExpressions;

namespace lab8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            String text = "The houme router ip adress is: 192.168.0.1. The Google ip adress is: 00001000.000.000001000.000010001000";
            String pattern = @"([0-1]{8}.){3}[0-1]{8}";
            MatchCollection collection = Regex.Matches(text, pattern);
            foreach(Match m in collection)
            {
                Console.WriteLine(m.Value);
            }

            //2
            text = Regex.Replace(text, @"\p{P}", "");
            Console.WriteLine(Regex.Replace(text, @"\d", ""));
            //3
            String text1;
            String text2;
            Console.Write("text1: ");
            text1 = Console.ReadLine();
            Console.Write("text2: ");
            text2 = Console.ReadLine();

            pattern = @"\w+";
            collection = Regex.Matches(text2, pattern);
            foreach (Match m in collection)
            {
               if (text1.Contains(m.Value))
                {
                   text1 = text1.Replace(m.Value, "");
                }
            }
            Console.WriteLine("text1: " + text1);
            Console.ReadKey();
        }
    }
}

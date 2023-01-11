using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace Codewars
{
    public class Task_on_codewars
    {
        public int Task5_count = 0;
        public void TASK1_REGEX(string str)
        {
            Regex regex = new Regex(@"[^A-Z]", RegexOptions.IgnoreCase);
            string s = regex.Replace(str, "");
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine(new string(charArray));
        }
        public void TASK1_LINQ(string str)
        {
            Console.WriteLine(new string (str.Where(Char.IsLetter).Reverse().ToArray()));
        }
        public  void TASK2_Algorithm(int start, int finish)
        {
            int count = 0;
            for(int i = start; i < finish;)
            {
                if (i + 3 > finish)
                {
                    i++; count++;
                }
                else 
                {
                    i += 3;
                    count++;
                };
            }
            Console.WriteLine (count);
        }
        public void Task3_Regex (string phrase)
        {
            var secondQuery = Regex.Replace(phrase, /*В первом критерии ищем
                                                     первый символ строки \w и во втором условии
                                                     ищем пробел и первый символ строки*/@"(^\w)|(\s\w)", m => m.Value.ToUpper());
            Console.WriteLine(secondQuery);
        }
        public void Task3_LINQ(string phrase)
        {
            Console.WriteLine(String.Join(" ", phrase.Split().Select(i => Char.ToUpper(i[0]) + i.Substring(1) )));
        }
        public void Task4_LINQ(int[] arr)
        {
            if (arr == null) { return; }
            //временное решение, не понял, как сделать без данного предупреждения.
#pragma warning disable CS8602 // Разыменование вероятной пустой ссылки.
            var arrcopy = arr.GroupBy(x => x)
                             .Where(x => x.Count() % 2 != 0 && x.Key > 0)
                             .MaxBy(x => x.Key).Key;
#pragma warning restore CS8602 // Разыменование вероятной пустой ссылки.
            Console.WriteLine(arrcopy);

        }
        public int TASK5_Recursion(int number)
        {
            if (number.ToString().Length != 1) Task5_count++;
            int[] arr= new int[number.ToString().Length];
            int x = 0;
            int c = 1;
            foreach (char i in number.ToString())
            {
                arr[x++] =int.Parse(i.ToString());
            }
            for(int i =0;i<arr.Length;i++)
            {
                if (arr[i] == 0) continue;
                c *=arr[i];
            }
            return ((double)(c) / 10 >= 1) ? TASK5_Recursion(c) : Task5_count;

        }
        public string TASK6_Regex(string mainstring,string? filterstring = "")
        {
            string[] Filter = (filterstring != null) ? filterstring.ToLower().Split(" ") : "".ToLower().Split(" ");
            string[] Main = mainstring.ToLower().Split(" ");
            string Result = "";
            foreach (string s in Main)
            {
                if (Filter.Contains(s))Result += s+" ";
                else Result += Regex.Replace(s, @"(^\w)", m => m.Value.ToUpper())+ " ";
            }
            return Regex.Replace(Result, @"(^\w)", m=>m.Value.ToUpper()).Remove(Result.Length - 1);
            
        }
    }
    public class Program
    { 
        static void Main(string[] args)
        {
            Task_on_codewars method = new Task_on_codewars();
            Console.WriteLine(method.TASK5_Recursion(100));
        }
    }
}
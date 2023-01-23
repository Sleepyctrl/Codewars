using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Linq;
using System.Security.AccessControl;
using System.Text.RegularExpressions;

namespace Codewars
{
    public class Task1
    {
        public static string ReverseAndOmmit_REGEX(string str)
        {
            Regex regex = new Regex(@"[^A-Z]", RegexOptions.IgnoreCase);
            string s = regex.Replace(str, "");
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        public static string ReverseAndOmmit_LINQ(string str)
        {
            return new string(str.Where(Char.IsLetter).Reverse().ToArray());
        }

    }
    public class Task2
    {
        public static int Cats_EasyAlgorithm(int start, int finish)
        {
            int count = 0;
            for (int i = start; i < finish;)
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
            return count;
        }
    }
    public class Task3
    {
        public static string  FirstLetterWordToUp_Regex(string phrase)
        {
            var secondQuery = Regex.Replace(phrase, /*В первом критерии ищем
                                                     первый символ строки \w и во втором условии
                                                     ищем пробел и первый символ строки*/@"(^\w)|(\s\w)", m => m.Value.ToUpper());
            return secondQuery;
        }
        public static string FirstLetterWordToUp_LINQ(string phrase)
        {
            return phrase != "" ? String.Join(" ", phrase.Split().Select(i => Char.ToUpper(i[0]) + i.Substring(1))) : "";
        }
    }
    public class Task4
    {
        public static int Find_the_odd_int_that_appears_an_odd_time_LINQ(int[] arr)
        {
            var arrcopy = arr.GroupBy(x => x).Where(x => x.Count() % 2 != 0);
            return arrcopy.Count()>=1? arrcopy.First().Key : 0;
        }
    }
    public class Task5
    {
        public static int Numbers_of_time_multiply_until_single_digit_Recursion(int number)
        {
            for (int i = 0; ; i++)
            {
                if (number < 10) return i;
                number = sol(number);
            }
        }
        public static int sol(int n)
        {
            if (n < 10) return (int)n;
            else return (int)(n % 10) * sol(n / 10);
        }
    }
    public class Task6
    {
        public static string Convert_first_char_into_title_case_with_except_Regex(string mainstring, string? filterstring = "")
        {
            //Первая буква первого слова является началом предложения, потому всегда пишется с заглавной буквы
            string[] Filter = (filterstring != null) ? filterstring.ToLower().Split(" ") : "".ToLower().Split(" ");
            string[] Main = mainstring.ToLower().Split(" ");
            string Result = "";
            foreach (string s in Main)
            {
                if (Filter.Contains(s)) Result += s + " ";
                else Result += Regex.Replace(s, @"(^\w)", m => m.Value.ToUpper()) + " ";
            }
            return Regex.Replace(Result, @"(^\w)", m => m.Value.ToUpper()).Remove(Result.Length - 1);

        }
    }
    public class Task7
    {
        public static bool Is_integer_prime(int n)
        {
            if (n == 2) return true;
            if (n == 0 || n == 1 || n < 0 || n % 2 == 0) return false;
            var boundary = (int)Math.Sqrt(n);
            for (int i = 3; i <= boundary; i+=2)
            {
                if (n % i == 0 && i != n) return false;
            }
            return true;
        }
    }
    public class Task8
    {
        public static int[] Move_Zeros_to_end(int[] arr)
        {
            //Kata.MoveZeroes(new int[] {1, 2, 0, 1, 0, 1, 0, 3, 0, 1}) => new int[] {1, 2, 1, 1, 3, 1, 0, 0, 0, 0}
            return arr.Where(x => x != 0).Concat(arr.Where(x => x == 0)).ToArray();
        }

    }
    public class Task9
    {
        public static int[] TASK9(int[] Numbers, int Target)
        {
            //two_sum([1, 2, 3], 4) == {0, 2}
            for (int i = 0; i < Numbers.Length; i++)
            {
                for (int b = 1; b < Numbers.Length; b++)
                {
                    if (Numbers[i] + Numbers[b] == Target && i != b)
                    {
                        return new int[] { i, b };
                    }
                }
            }
            // public static int[] TwoSum(int[] numbers, int target) =>
            // numbers.Select((x,i)=>new [] {i, Array.IndexOf(numbers,target-x,i+1)})
            // .First(x => x[1] != -1);
            return new int[0];
        }
    }
    public class Task10
    {
        public static bool TASK10(string str)
        {
            return str == "" ? false : !new Regex(@"[\W]|[._]").IsMatch(str);
        }
    }
    public class Task11
    {
        public static string TASK11(int[] args)
        {
            int count;
            //string builder
            List<string> list = new List<string>();
            // solution([-10, -9, -8, -6, -4, -5, -1, 0, 1, 3, 4, 5, 7, 8, 9, 11, 12, 14, 15, 17, 19, 20, 21]);
            //{ -10, -9, -8, -6, -3, -2, -1, 0, 1, 3, 4, 5, 7, 8, 9, 10, 11, 14, 15, 17, 18, 19, 20 }
            // returns "-10--8,-6,-3-1,3-5,7-11,14,15,17-20"

            for (int i = 0; i <= args.Length; i++)
            {
                count = 1;
                for (int g = i + 1; g <= args.Length; g++)
                {
                    if (g == args.Length && count >= 3)
                    {
                        list.Add($"{args[g - count]}-{args[g - 1]}");
                        return String.Join(",", list);
                    }

                    if (g != args.Length && args[i] + 1 == args[g])
                    {
                        count++; i++;
                    }
                    else
                    {
                        if (count >= 3)
                        {
                            list.Add($"{args[g - count]}-{args[g - 1]}");
                        }
                        else
                        {

                            if (count == 2)
                            {
                                list.Add($"{args[i - 1]}");
                                list.Add($"{args[i]}");
                            }
                            else
                            {
                                list.Add($"{args[i]}");
                            }

                        }

                        break;
                    }

                }
            }
            return String.Join(",", list);


        }
    }
        
       
    
    public class Program
    {
        static void Main(string[] args)
        {
          
        }
    }
}
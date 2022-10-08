using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeat
{
    public static class Work
    {
        public static string LongestWord(string str)
        {
            StringBuilder sb = new StringBuilder();
            var result = "";

            foreach(var e in str)
            {
                if(e != ' ')
                {
                    sb.Append(e);
                }
                else
                {
                    if(sb.Length > result.Length)
                    {
                        result = sb.ToString();
                    }                  
                    sb = new StringBuilder();
                }
            }

            if (sb.Length > result.Length)
            {
                result = sb.ToString();
            }

            return result;
        }

        public static long FirtFactorial(int n)
        {
            long product = 1;
            if(n < 0) return default(long);
            if (n <= 1) return n;
            while (n > 1)
            {
                product *= n;
                n -= 1;
            }
            return product;
        }

        private static string Reverse(string str)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = str.Length-1; i >=0; i--)
            {
                sb.Append(str[i]);
            }
            return sb.ToString();
        }
        public static string FirstReverse(string str)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in str)
            {
                if(c != ' ')
                {
                    sb.Append(c);
                }
                else
                    break;
            }
            return Reverse(sb.ToString());
        }

        public static string ReverseEachWord(string str)
        {
            StringBuilder sb = new StringBuilder();
            var result = new StringBuilder();
            foreach(var e in str)
            {
                if(e != ' ') 
                    sb.Append(e);
                else
                {
                    result.Append(Reverse(sb.ToString()) + " ");
                    sb = new StringBuilder();
                }
            }
          return  result.Append(Reverse(sb.ToString())).ToString();
        }
        public static bool CheckAnagram(string str1, string str2)
        {
            str1 = str1.ToLower().Trim();
            str2 = str2.ToLower().Trim();

            if (str1.Length != str2.Length) return false;

            for(int i = 0; i < str1.Length; i++)
            {
                if (!str2.Contains(str1[i])) return false;
            }
            return true;
        }

        public static bool CheckPalidrome(string str)
        {
            str = str.ToLower().Trim();
            int min = 0;
            int max = str.Length-1;

            for(int i = 0; i < str.Length; i++)
            {
                if (str[min] != str[max])
                {
                    return false;
                }
                min++;
                max--;
            }

            return true;
        }

        public static string RunLenght(string str)
        {
            //aaabbacc
            //3a2b1a2c
            var result = "";
            var res = str[0];
            int counter = 1;

            for(int i = 1; i<str.Length; i++)
            {
                if (str[i] != res)
                {
                    result += $"{counter}{res}";
                    res = str[i];
                    counter = 1;
                }
                else
                {
                    res = str[i];
                    counter++;
                }
                
            }
            result += $"{counter}{res}";
            return result;
        }

        public static int CountPalidrome(string str)
        {
            var arr = str.Split(" ");
            int counter = 0;
            foreach(var e in arr)
            {
                if(CheckPalidrome(e)) counter++;
            }
            return counter;
        }

        private static bool checkPrime(int n)
        {
            if(n < 2) return false;
            if(n == 2) return true;

            int factors = 0;
            for(var i = 1; i <= n; i++)
            {
                if(n%i == 0)
                {
                    factors++;
                    //break;
                }
            }
            
            return factors == 2?true: false;

        }
        public static string ReturnStringOfPrimes(int[] str)
        {
            var result = "";
            foreach(var e in str)
            {
                if (checkPrime(e))
                {
                    result += e;
                }
            }
            return result;
        }

        public static int[] ReArrangeElts(int[] arr)
        {
            Array.Sort(arr);
            var odds = new List<int>();
            var even = new List<int>();
          
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i]%2 == 0) 
                    even.Add(arr[i]);
                else 
                    odds.Add(arr[i]);
            }

            bool flag = false;

            int k = 0;
            int j = 0;
            int index = 0;
            int n = arr.Length;

            if (arr[0]%2 == 0)
            {
                flag = true;
            }

            while(index < n)
            {
                if(flag == true)
                {
                    arr[index] = even[j];
                    index++;
                    j++;
                    flag = !flag;
                }
                else
                {
                    arr[index] = odds[k];
                    index++;
                    k++;
                    flag = !flag;
                }
            }

            return arr;

        }
    }
}

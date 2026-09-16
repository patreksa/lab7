using System;

namespace MyApp
{
    public static class Lab1Methods
    {
        private static int Partition(int[] arr, int start, int end)
        {
            int pivot = arr[end];
            int pIndex = start;

            for (int i = start; i < end; i++)
            {
                if (arr[i] <= pivot)
                {
                    int temp = arr[i];
                    arr[i] = arr[pIndex];
                    arr[pIndex] = temp;
                    pIndex++;
                }
            }

            {
                int temp = arr[pIndex];
                arr[pIndex] = arr[end];
                arr[end] = temp;
            }

            return pIndex;
        }

        public static void QSort(int[] arr)
        {
            if (arr is null)
                throw new NullReferenceException("arr is null!");

            if (arr.Length < 2)
                return;

            QSort(arr, 0, arr.Length - 1);
        }

        public static void QSort(int[] arr, int start, int end)
        {
            if (arr is null)
                throw new NullReferenceException("arr is null!");

            if (start >= end)
                return;

            if (start < 0 || end < 0 || start >= arr.Length || end >= arr.Length)
                throw new ArgumentException($"Invalid bounds: start={start}, end={end}, length={arr.Length}");

            int p = Partition(arr, start, end);
            QSort(arr, start, p - 1);
            QSort(arr, p + 1, end);
        }

        public static string IsPalindrome(string s)
        {
            if (s is null)
                throw new NullReferenceException("string is null!");

            char[] chars = s.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }

        public static long Factorial(int num)
        {
            if (num < 0)
                throw new ArgumentException("Can't count factorial for negative numbers");

            long result = 1;
            for (int i = 1; i <= num; i++)
                result *= i;

            return result;
        }

        public static long Fibonacci(int num)
        {
            if (num < 0)
                throw new ArgumentException("Can't count fibbonaci for negative numbers");

            int a = 0;
            int b = 1;
            for (int i = 0; i < num; i++)
            {
                int temp = a + b;
                a = b;
                b = temp;
            }

            return a;
        }

        public static int SubstringSearch(string s, string sub)
        {
            if (s is null || sub is null)
                throw new NullReferenceException("String is null!");

            int n = s.Length;
            int m = sub.Length;

            if (m == 0)
                return 0;

            for (int i = 0; i < n - m + 1; i++)
            {
                bool found = true;
                for (int j = 0; j < m; j++)
                {
                    if (s[i + j] != sub[j])
                    {
                        found = false;
                        break;
                    }
                }
                if (found)
                    return i;
            }

            return -1;
        }

        public static bool IsPrime(int num)
        {
            if (num < 2)
                return false;

            int a = 1;
            int k = 0;
            int limit = (int)Math.Sqrt(num);

            while (a <= limit)
            {
                if (num % a == 0)
                {
                    k++;
                    if (a != num / a)
                        k++;
                }
                a++;
            }

            return k == 2;
        }

        public static int ReversedInt(int x)
        {
            int sign = x < 0 ? -1 : 1;

            int xAbs = Math.Abs(x);
            long reversed = 0;

            while (xAbs > 0)
            {
                int digit = xAbs % 10;
                reversed = reversed * 10 + digit;
                xAbs /= 10;
            }

            reversed *= sign;
            return (int)reversed;
        }

        public static string IntToRoman(int num)
        {
            if (num < 1 || num > 3999)
                throw new ArgumentException("Number must be in range 1-3999");

            int[] arr = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            string[] symbols = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

            var roman = string.Empty;
            int i = 0;

            while (num > 0 && i < arr.Length)
            {
                while (num >= arr[i])
                {
                    roman += symbols[i];
                    num -= arr[i];
                }
                i++;
            }

            return roman;
        }
    }
}

using System;

namespace ConsoleApp15
{
    class Anagram
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine().ToLower();
            string str2 = Console.ReadLine().ToLower();
            char[] cr = new char[str.Length];
            char[] cr2 = new char[str2.Length];
            if (str.Length == str2.Length)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    cr[i] = str[i];
                    cr2[i] = str2[i];
                }

                Array.Sort(cr);
                Array.Sort(cr2);

                bool isAnagram = false;

                for (int i = 0; i < str.Length; i++)
                {
                    if (cr[i] != cr2[i]) { }
                    else { isAnagram = true; }
                }
                if (isAnagram)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
            else
            {
                Console.WriteLine("Different length!");
            }
        }
    }
}

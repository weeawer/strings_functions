using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            string line = Console.ReadLine();
            GetWords(out string[] words, line);
            ShowInfo(words);
            Console.ReadLine();
        }
        static void GetWords(out string[] words, string line)
        {
            words = new string[0];
            foreach (string s in line.Split())
            {
                AddWord(ref words, s);
            }
        }

        static void AddWord(ref string[] words, string word)
        {
            if (!Contains(words, word))
            {
                words = AddArr(words, word);
            }
        }

        static string[] AddArr(string[] arr1, string word)
        {
            string[] res = new string[arr1.Length + 1];
            for (int i = 0; i < arr1.Length; i++)
            {
                res[i] = arr1[i];
            }
            res[arr1.Length] = word;
            return res;
        }

        static bool Contains(string[] words, string word)
        {
            foreach (string item in words)
            {
                if (item == word)
                {
                    return true;
                }
            }
            return false;
        }

        static void ShowInfo(string[] words)
        {
            Console.WriteLine(string.Join(" ", words));
        }
    }
    
}

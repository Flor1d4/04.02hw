using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04._02hw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vowel = 0;
            Console.WriteLine("Введите предложение(на английском): ");
            string input = Console.ReadLine();
            Console.WriteLine("Введите индекс буквы которую нужно удалить: ");
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите букву которую нужно удалить: ");
           char CharacterToDelete = Console.ReadLine()[0];
            Console.WriteLine("Введите букву которую нужно вставить: ");
            char CharacterToInsert = Console.ReadLine()[0];
            Console.WriteLine("Введите введите на какую позицию вставить: ");
            int insertPosition = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите слово которое нужно заменить: ");
            string wordToReplace = Console.ReadLine();
            Console.WriteLine("Введите слово замену: ");
            string replacementWord = Console.ReadLine();          
            string result = input;
            result = result.Remove(index, 1);
            result = result.Replace(CharacterToDelete.ToString(), "");
            result = result.Insert(insertPosition, CharacterToInsert.ToString());
            bool Palindrome = result.Equals(String(result));
            result = result.Replace(wordToReplace, replacementWord);
            result = Words(result);

            string[] words = result.Split(' ');

            foreach (string word in words)
            {
                char lastCharacter = word[word.Length - 1];
                if ("aeiouyAEIOUY".IndexOf(lastCharacter) >= 0)
                {
                    vowel++;
                }
            }
            Console.WriteLine("Результат: " + result);
            Console.WriteLine("Палиндрома: " + Palindrome);
             Console.WriteLine("Кол-во слов заканчиваются на гласную: " + vowel);
        }

        static string String(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
         return new string(charArray);
        }

        static string Words(string s)
        {
            string[] words = s.Split(' ');
             Array.Reverse(words);
            return string.Join(" ", words);
        }
    
    }
}

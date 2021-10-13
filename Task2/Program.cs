using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            // Определить является ли строка палиндромом без учёта пробелов и регистра.
            Console.WriteLine("Введите с клавиатуры предложение. Предложение представляет собой слова," +
                " разделенные пробелом. Знаки препинания не использовать.");
            String sentence1 = Console.ReadLine();
            char[] separator = new char[] { ' ' };
            string[] stringArray = sentence1.Split(separator);
            int result = 0;
            bool ignoreCase = true;
            string sentence2 = sentence1 = "";

            for (int i = 0; i < stringArray.Length; i++)
            {
                sentence1 += stringArray[i];
            }

            for (int i = sentence1.Length - 1; i > -1; i--)
            {
                sentence2 += sentence1[i];
            }

            result = string.Compare(sentence1, sentence2, ignoreCase);

            if (result == 0)
            {
                Console.WriteLine("Предложение является палиндромом");
            }

            else
            {
                Console.WriteLine("Предложение не является палиндромом");
            }

            Console.ReadLine();
        }
    }
}

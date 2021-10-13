using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxLength
{
    class Program
    {
        static void Main(string[] args)
        {
            // Найти самое длинное слово в строке.
            Console.WriteLine("Введите с клавиатуры предложение. Предложение представляет собой слова," +
                " разделенные пробелом. Знаки препинания не использовать.");
            String sentence = Console.ReadLine();
            char[] separator = new char[] { ' ' };
            string[] stringArray = sentence.Split(separator);
            string result = "";
            int length = 0;

            for (int i = 0; i < stringArray.Length; i++)
            {
                if (length <= stringArray[i].Length)
                {
                    length = stringArray[i].Length;
                    result = stringArray[i];
                }
            }
            Console.WriteLine("Самое длинное слово в строке: {0}", result);
            Console.ReadLine();
        }
    }
}

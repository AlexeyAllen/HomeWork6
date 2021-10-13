using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurlyBrace
{
    class Program
    {
        static void Main(string[] args)
        {
            // Удалить текст, заключенный в фигурные скобки.
            Console.WriteLine("Введите строку со словами, включенными в фигурные скобки");
            String sentence = Console.ReadLine();
            char[] separator = new char[] { ' ' };
            string[] stringArray = sentence.Split(separator);
            string[] stringArray2 = new string [stringArray.Length];
            sentence = "";
            string openCurly = "{";
            string openCurlyHidden = "/{";
            string closeCurly = "}";
            string closeCurlyHidden = "}";

            for (int i = 0; i < stringArray.Length; i++)
            {
                int check1 = stringArray[i].IndexOf(openCurly);
                int check2 = stringArray[i].IndexOf(openCurlyHidden);
                int check3 = stringArray[i].LastIndexOf(closeCurly);
                int check4 = stringArray[i].LastIndexOf(closeCurlyHidden);

                if ((check1 == 0 || check2 == 0) && ((check3 == stringArray[i].Length-1) || (check4 == stringArray[i].Length - 1)))
                {
                    stringArray[i] = null;
                    sentence += stringArray[i];
                }
                else
                {
                    sentence += stringArray[i] + " ";
                }
            }

            Console.WriteLine("Строка без слов, включенных в фигурные скобки: {0}", sentence);
            Console.ReadLine();
        }
    }
}

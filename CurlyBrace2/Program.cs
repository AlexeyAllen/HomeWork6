using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurlyBrace2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Удалить текст, заключенный в фигурные скобки.
            Console.WriteLine("Введите строку с фрагментами, заключенными в фигурные скобки");
            String stringWithCurly = Console.ReadLine();
            char curlyOpen = '{';
            char curlyClosed = '}';
            int locOpen = 0;
            int locClose = 0;

            locOpen = stringWithCurly.IndexOf('{');
            locClose = stringWithCurly.IndexOf('}');
            if ((locOpen < 0) || (locClose < 0) || (locClose < locOpen))
            {
                goto End1;
            }

            for (int i = 0; i < stringWithCurly.Length; i++)
            {
                if (stringWithCurly[i] == curlyOpen)
                {
                    locOpen = stringWithCurly.IndexOf('{');

                    for (int j = i + 1; j < stringWithCurly.Length; j++)
                    {
                        if (stringWithCurly[j] == curlyClosed)
                        {
                            locClose = stringWithCurly.IndexOf('}');
                            int exprLength = locClose - (locOpen - 1);
                            stringWithCurly = stringWithCurly.Remove(locOpen, exprLength);
                            locOpen = locClose = 0;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine("Строка после удаления фрагмента (фрагментов), заключенного в фигурные скобки:\n{0}", stringWithCurly);

        End1:
            if ((locOpen < 0) || (locClose < 0) || (locClose < locOpen))
            {
                Console.WriteLine("Строка не содержит фрагмента, заключенного в фигурные скобки");
            }
            Console.ReadLine();
        }
    }
}

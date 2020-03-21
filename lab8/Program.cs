using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите строку с которой нужно работать");
                string str = Console.ReadLine();
                Console.WriteLine("Введите слово для поиска в строке");
                string word = Console.ReadLine();
                Console.WriteLine("Введите номер элемента");
                int count = Convert.ToInt32(Console.ReadLine());

                if(str.Length == 0)
                {
                    Console.WriteLine("Строка не может быть пустой");
                    Console.ReadKey();
                    return;
                }
                string[] splited = str.Split(' ');
                int counter = 0;
                string upper_word = "";

                if(splited.Length > 1)
                    splited[splited.Length - 2] = word;

                for(int i = 0; i < splited.Length; i++)
                {
                    if (splited[i].Length != 0)
                    {
                        if (splited[i] == word)
                            counter++;

                        if (count != 0 && splited[i][0] == splited[i].ToUpper()[0])
                        {
                            upper_word = splited[i];
                            count--;
                        }
                    }
                }


                Show_(splited);
                Console.WriteLine((splited.Length <= 1)?"не удалось заменить предпоследнее слово":"");
                Console.WriteLine("Слово " + word + " встретилось в строке " + counter + " раз.");

                if(count == 0)
                    Console.WriteLine("Слово с большой буквы под заданным номером - " + upper_word);
                else
                    Console.WriteLine("Нет слова с большой буквы под заданным номером");
                Console.ReadKey();

            }
            catch(FormatException e)
            {
                Console.WriteLine("Неверный формат числа." + e.Message);
                Console.ReadKey();
                return;
            }
            return;
        }

        static void Show_(string[] str)
        {
            for(int i = 0; i < str.Length; i++)
                if(str[i].Length != 0)
                    Console.Write(str[i] + " ");
            Console.WriteLine();
        }
    }
}

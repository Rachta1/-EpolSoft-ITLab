using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanieEpolSoft2reshenie
{
    class Program
    {
        static void Main(string[] args)
        {
            string stroka;
            string[] MassivStrok = new string[9];
            string[] NewMassivStrok = new string[9];
            char[] strokaToChar = new char[9];
            char[] strokaToChar1 = new char[9];
            bool b = true;


            while (true)//Бесконечный цикл. Условие выхода из цикла: введенная строка должна содержать 9 символов; символы в строке либо '1',либо'0'
            {

                Console.Write("Введите строку,размерностью 9 символов, символы могут принимать значение либо '0', либо '1': ");
                stroka = Console.ReadLine();//Ввод строки с клавиатуры
                strokaToChar = stroka.ToCharArray();//Преобразовывает строку в массив символов

                for (int i = 0; i < strokaToChar.Length; i++)//Цикл, который Проверяет выполнение условий для строки
                {
                    try//Обработка исключений. Массив символов не должен превышать 9 символов(элементов)
                    {

                        if ((strokaToChar[i] == '1') || (strokaToChar[i] == '0'))
                        {
                            strokaToChar1[i] = strokaToChar[i];
                            b = true;
                        }

                        else
                        {
                            Console.WriteLine("Ошибка ввода: в строке присутствую недопустимые символы. Повторите ввод.");
                            b = false;
                            break;
                        }
                    }
                    catch
                    {
                        b = false;
                        break;
                    }
                }
                if ((strokaToChar.Length != 9))
                {
                    b = false;
                    Console.WriteLine("Введено недопустимое число символов.Повторите ввод.");
                }
                if (b == true)
                {
                    break;
                }

            }
            Console.Write("Введенная строка: ");//Вывод строки на консоль
            foreach (char result in strokaToChar1)
            {
                Console.Write(result);
            }
            Console.WriteLine();
            Console.WriteLine("Введите 9 элементов массива с клавиатуры: ");
            for (int i = 0; i < 9; i++)
            {
                Console.Write("{0} элемент массива: ", i + 1);
                MassivStrok[i] = Console.ReadLine();//Ввод входного массива с клавиатуры
            }
            Console.Write("Новый массив состоит из элементов: ");
            for (int i = 0; i < 9; i++)//Цикл, который поочередно проверяет каждый символ строки. Если символ строки'1'- значение соответсвующего входного массива присваивается выходному массиву
            {
                if (strokaToChar1[i] == '1')
                {
                    NewMassivStrok[i] = MassivStrok[i];
                    Console.Write("{0} ", NewMassivStrok[i]);//Вывод выходного массива
                }
            }
            Console.ReadKey();
        }

    }
}

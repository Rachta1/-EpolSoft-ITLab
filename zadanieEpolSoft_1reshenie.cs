using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanieEpolSoft
{
    class zadanieEpolSoft_1reshenie
    {
        static void Main(string[] args)
        {
            string stroka = "011010111";
            string[] massivstrok = {"кот", "собака", "гусь", "мышь", "волк", "заяц", "зубр", "олень", "медведь"};
            string[] newMassivStrok = new string[9];
            char[] strokaToChar = new char[9];
            strokaToChar=stroka.ToCharArray(); //преобразовывает строку в массив символов
            Console.Write("Входной массив строк, состоящий из 9 элементов: ");
            foreach (string result in massivstrok) //вывод входного массива строк
            {
                Console.Write("{0} ",result);
            }
            Console.WriteLine();
            Console.Write("Строка, состоящая из символов '0' или '1': ");
            for (int i=0;i<9;i++) //Цикл, который просматривает поочередно символы. Если символ'1', то записывает соответсвующий элемент в новый массив
            {
                if(strokaToChar[i]=='1')
                {
                    newMassivStrok[i] = massivstrok[i];
                }
                Console.Write(strokaToChar[i]);
               
            }
            Console.WriteLine();
            Console.Write("Выходной массив строк: ");
            foreach (string result in newMassivStrok)//Вывод выходного массива
            {
                Console.Write(" {0}", result);
            }
            Console.ReadKey();
        }
    }
}
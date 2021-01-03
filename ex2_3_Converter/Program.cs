using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Написать конвертер валют (3 валюты).
У пользователя есть баланс в каждой из представленных валют. Он может попросить сконвертировать часть баланса с одной валюты в другую.
Тогда у него с баланса одной валюты снимется X и зачислится на баланс другой Y. Курс конвертации должен быть просто прописан в программе.
Программа должна завершиться тогда, когда это решит пользователь.*/
namespace ex2_3_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Конвентер валют. Выбор операции- нажмите от 1 до 6. Для выхода из программы нажмите ноль\n");
            double myRub = 100.0;  //изначально в кошельке рублей rub-->usd(/73.87), rub-->uero(/90.79) 
            double myUsd = 300.0;   //изначально в кошельке долларов usd-->rub(*73.87), usd-->euro(/1.23)
            double myEuro = 500.0;  //изначально в кошельке евро euro-->usd(*1.23), euro-->rub(*90.79)
            double varForChange = 0.0; //будет храниться временное значение при конвертации
            double varSummaForChange = 0.0;//переменная для суммы конвертации
            int inputChoice; // навигация по меню

            do
            {
                Console.WriteLine($"Ваш тукущий баланс: || {myRub} рублей || {myUsd} USD || {myEuro} EURO \n");
                Console.WriteLine("1. Перевод рублей в доллары\n2. Перевод рублей в Евро\n3. Перевод долларов в рубли\n" +
               "4. Перевод долларов в Евро\n5. Перевод Евро в доллары\n6. Перевод Евро в рубли\n0. Выход\n");
                inputChoice = Convert.ToInt32(Console.ReadLine());
                switch (inputChoice)
                {
                    case 0:
                        break;
                    case 1: //Перевод рублей в доллары
                        {
                            Console.WriteLine("Сколько рублей перевести в доллары? ");
                            varSummaForChange = Convert.ToSingle(Console.ReadLine());
                            if (myRub < varSummaForChange) //алгоритм, если у пользователя не хватает текущей валюты для обмена 
                            {
                                do
                                {
                                    Console.WriteLine("У Вас недостаточно денег, введите суму меньше или ноль для выбора валюты");
                                    varSummaForChange = Convert.ToSingle(Console.ReadLine());
                                } while (myRub < varSummaForChange);
                            }
                            varForChange = varSummaForChange / 73.87;
                            myRub -= varSummaForChange;
                            myUsd += varForChange;
                            Console.Clear();
                        }
                        break;
                    case 2://Перевод рублей в Евро
                        {
                            Console.WriteLine("Сколько рублей перевести в евро? "); 
                            varSummaForChange = Convert.ToSingle(Console.ReadLine());
                            if (myRub < varSummaForChange) //алгоритм, если у пользователя не хватает текущей валюты для обмена 
                            {
                                do
                                {
                                    Console.WriteLine("У Вас недостаточно денег, введите суму меньше или ноль для выбора валюты");
                                    varSummaForChange = Convert.ToSingle(Console.ReadLine());
                                } while (myRub < varSummaForChange);
                            }
                            varForChange = varSummaForChange / 90.79;
                            myRub -= varSummaForChange;
                            myEuro += varForChange;
                            Console.Clear();
                        }
                        break;
                    case 3://Перевод долларов в рубли
                        {
                            Console.WriteLine("Сколько долларов перевести в рубли? ");
                            varSummaForChange = Convert.ToSingle(Console.ReadLine());
                            if (myUsd < varSummaForChange) //алгоритм, если у пользователя не хватает текущей валюты для обмена 
                            {
                                do
                                {
                                    Console.WriteLine("У Вас недостаточно денег, введите суму меньше или ноль для выбора валюты");
                                    varSummaForChange = Convert.ToSingle(Console.ReadLine());
                                } while (myUsd < varSummaForChange);
                            }
                            varForChange = varSummaForChange * 73.87;
                            myUsd -= varSummaForChange;
                            myRub += varForChange;
                            Console.Clear();
                        }
                        break;
                    case 4: //Перевод доллары в Евро
                        {
                            Console.WriteLine("Сколько долларов перевести в Евро? ");
                            varSummaForChange = Convert.ToSingle(Console.ReadLine());
                            if (myUsd < varSummaForChange) //алгоритм, если у пользователя не хватает текущей валюты для обмена 
                            {
                                do
                                {
                                    Console.WriteLine("У Вас недостаточно денег, введите суму меньше или ноль для выбора валюты");
                                    varSummaForChange = Convert.ToSingle(Console.ReadLine());
                                } while (myUsd < varSummaForChange);
                            }
                            varForChange = varSummaForChange / 1.23;
                            myUsd -= varSummaForChange;
                            myEuro += varForChange;
                            Console.Clear();
                        }
                        break;
                    case 5://Перевод Евро в доллары
                        {
                            Console.WriteLine("Сколько Евро перевести в доллары? ");
                            varSummaForChange = Convert.ToSingle(Console.ReadLine());
                            if (myEuro < varSummaForChange) //алгоритм, если у пользователя не хватает текущей валюты для обмена 
                            {
                                do
                                {
                                    Console.WriteLine("У Вас недостаточно денег, введите суму меньше или ноль для выбора валюты");
                                    varSummaForChange = Convert.ToSingle(Console.ReadLine());
                                } while (myEuro < varSummaForChange);
                            }
                            varForChange = varSummaForChange * 1.23;
                            myEuro -= varSummaForChange;
                            myUsd += varForChange;
                            Console.Clear();
                        }
                        break;
                    case 6://Перевод Евро в рубли
                        {
                            Console.WriteLine("Сколько Евро перевести в рубли? ");
                            varSummaForChange = Convert.ToSingle(Console.ReadLine());
                            if (myEuro < varSummaForChange) //алгоритм, если у пользователя не хватает текущей валюты для обмена 
                            {
                                do
                                {
                                    Console.WriteLine("У Вас недостаточно денег, введите суму меньше или ноль для выбора валюты");
                                    varSummaForChange = Convert.ToSingle(Console.ReadLine());
                                } while (myEuro < varSummaForChange);
                            }
                            varForChange = varSummaForChange * 90.79;
                            myEuro -= varSummaForChange;
                            myRub += varForChange;
                            Console.Clear();
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("Неправильный ввод");
                        }
                        break;

                }

            } while (inputChoice!=0);

            Console.ReadLine();
        }
    }
}

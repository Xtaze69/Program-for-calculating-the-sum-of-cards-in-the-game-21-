using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Программа_подсчёта_суммы_карт_в_игре__21_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberCards;
            int sum = 0;
            string cardValue;

            Console.WriteLine("Здравствуй, сколько карт у тебя на руках? ");
            numberCards = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberCards; i++)
            {
                Console.WriteLine("Введите номинал карты: ");
                cardValue = (Console.ReadLine());

                switch (cardValue)
                {
                    case "2":
                        sum += 2;
                        break;
                    case "3":
                        sum += 3;
                        break;
                    case "4":
                        sum += 4;
                        break;
                    case "5":
                        sum += 5;
                        break;
                    case "6":
                        sum += 6;
                        break;
                    case "7":
                        sum += 7;
                        break;
                    case "8":
                        sum += 8;
                        break;
                    case "9":
                        sum += 9;
                        break;
                    case "10":
                    case "J":
                    case "Q":
                    case "K":
                    case "T":
                        sum += 10;
                        break;
                    default:
                        Console.WriteLine("Такого номинала не существует");
                        break;


                }
            }
            Console.WriteLine($"Сумма карт на руках: {sum}");
            Console.ReadKey();
        }
    }
}

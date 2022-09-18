using System;

namespace Lessons
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть число початку дiапазону : ");
            int firstnum = int.Parse(Console.ReadLine());
            Console.WriteLine("Введiть число кiнця дiапазону : ");
            int secondnum = int.Parse(Console.ReadLine());

            int EvenNum = 0;
            int OddNum = 0;
            int SumEven = 0;
            int SumOdd = 0;
            while (firstnum < secondnum)
            {

                firstnum++;

                if (firstnum % 2 == 0)
                {
                    EvenNum += firstnum;
                    SumEven++;
                }

                else
                {
                    OddNum += firstnum;
                    SumOdd++;
                }

            }

            Console.WriteLine("Кiлькiсть парних чисел: " + SumEven);
            Console.WriteLine("Кiлькiсть не парних чисел : " + SumOdd);
            Console.WriteLine("Cумма парних : " + EvenNum);
            Console.WriteLine("Cумма не парних : " + OddNum);


        }
    }
}
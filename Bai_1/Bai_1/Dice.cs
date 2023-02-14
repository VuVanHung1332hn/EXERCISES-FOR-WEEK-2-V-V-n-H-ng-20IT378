using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_1
{
     class Dice
    {
        static void Main(string[] args)
        {
            int myRandomNum;
            int computerRandomNum;

            int myPoints = 0;
            int computerPoints = 0;

            Random random = new Random();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Nhan phim bat ki de tung xuc xac");
                Console.ReadKey();
                Console.WriteLine("Doi ti...");
                System.Threading.Thread.Sleep(1000);

                myRandomNum = random.Next(1, 7);
                Console.WriteLine("Ban tung duoc mat: " + myRandomNum);

                Console.WriteLine("Doi ti...");
                System.Threading.Thread.Sleep(1000);

                computerRandomNum = random.Next(1, 7);
                Console.WriteLine("May tinh tung duoc mat: " + computerRandomNum);

                if (myRandomNum > computerRandomNum)
                {
                    myPoints++;
                    Console.WriteLine("Ban da chien thang vong nay!!");
                }
                else if (myRandomNum < computerRandomNum)
                {
                    computerPoints++;
                    Console.WriteLine("May tinh da chien thang vong nay!!");
                }
                else
                {
                    Console.WriteLine("Vong nay hoa!!");
                }

                Console.WriteLine("The score is now - Ban: " + myPoints + ", May tinh: " + computerPoints + ".");
                Console.WriteLine();
            }

            if (myPoints > computerPoints)
            {
                Console.WriteLine("Ban da thang!!");
            }
            else if (computerPoints > myPoints)
            {
                Console.WriteLine("Ban da thua!!");
            }
            else
            {
                Console.WriteLine("Ban va may tinh da hoa!");
            }
            Console.ReadKey();
        }
    }
}

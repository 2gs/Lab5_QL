using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber5
{
    class Program
    {
        int side1,side2;

        Random r = new Random();

         
        
        public static void rollDice(int num)
        {
            int side1, side2;

            Random r= new Random();
            side1 = r.Next(1, num);
            side2 = r.Next(1, num);

            Console.WriteLine("Side 1:" + side1);
            Console.WriteLine("Side 2:" + side2);

            whatDidYouRoll(side1, side2);    


        }

        public static void whatDidYouRoll( int s1, int s2)
        {

            if (s1 == 1 && s2 == 1)
            {
                Console.WriteLine("You rolled that hot snake eyes, yeah you just crapped out. I wil be taking all of your money now :)");
            }
            else if (s1 == 1 && s2 == 2 || s2 == 1 && s1 == 2)
            {
                Console.WriteLine("You rolled that hot Acc duece");
            }
            else if (s1 == 6 && s2 == 6)
            {
                Console.WriteLine("You have rolled a 12, you crapped out. I will be taking all of your money now :)");
            }
            else if (s1 == 3 && s2 == 2 || s1 == 1 && s2 == 4 || s2 == 1 && s1 == 4 || s2 == 3 && s1 == 2)
            {
                Console.WriteLine("You have rolled a 5, you crapped out. I will be taking all of your money now :)");
            }
            else if (s1 == 1 && s2 == 6 || s2 == 1 && s1 == 6 || s1 == 3 && s2 == 4 || s2 == 3 && s1 == 4)
            {
                Console.WriteLine("You have rolled that hot 11 7, you crapped out. I will be taking all of your money now :)");
            }
            else if (s1 == 6 && s2 == 5 || s2 == 6 && s1 == 5)
            {
                Console.WriteLine("You have rolled that hot 11, you crapped out. I will be taking all of your money now :)");

            }
            else if (s1 == 6 && s2 == 6)
            {
                Console.WriteLine("You have rolled a 12, you crapped out. I will be taking all of your money now :)");
            }



        }
        static void Main(string[] args)
        {
            int sides, how_many;
            int xx, yy = 0;

            Console.WriteLine("Welcome to Grand Circus Crap Table, Ernest will be your dealer...crap dealer :)" + "/n");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("-------------------------------------------------------");
           /* Console.WriteLine("******" + );
            for (int i = 1; i <= 6; i++)
            {
                Console.Write("*" + "\n");
            }

            Console.WriteLine("******");*/

            Console.WriteLine("Enter in the number of sides for a pair of dice");
            sides = int.Parse(Console.ReadLine());

              rollDice(sides);
            
       }
    }
}

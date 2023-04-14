using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*for loop
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Junaid");
                Console.WriteLine(i);
            }
            */
            /*
            for (int i = 1;i <= 20; i++){
                if(i%2 == 0)
                {
                    Console.WriteLine(i + " is an even number");
                }
                else
                {
                    Console.WriteLine(i + " is an odd number");
                }
            }
            */
            /* infinite for loop
            int i=0;
            for (; ; )
            {
                //if(i == 5) 
                //{ 
                //break;
                //}
            Console.WriteLine(i);
            i++;
            }
            */

            /* for loop another example
            Console.WriteLine("Enter any number  : ");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", num, i,  num*i);
            }
            */

            /* //while loop :
            int i = 1;
            while(i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }
            */

            /* //While loop even & odd number:
            Console.WriteLine("Enter Number : ");
            int i = Convert.ToInt32(Console.ReadLine());
            while (i <= 10)  {
                if (i%2 == 0) {
                    Console.WriteLine(i + " is even number");
                }
                else
                {
                    Console.WriteLine(i + " is odd number");
                }
                i++;
            }
            */
            /* infinite while loop
            int x = 1;
            while (true)
            {
                //if (x == 5)
                //{
                //    break;
                //}

                Console.WriteLine(x);
                x++;
            }
            */
            /*
            Console.WriteLine("Enter any number  : ");
            int num = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine("{0} x {1} = {2}", num, i, num * i);
                i++;
            }
            */

            /*
            //Do-Whie _Loop :
            string name;
            char flag = 'y';
            do
            {
                Console.WriteLine("Enter Name : ");
                name = Console.ReadLine();

                Console.WriteLine("You entered " + name);

                Console.WriteLine("Do you want to take another name ?(y/n)");
                flag = Convert.ToChar(Console.ReadLine());
            } while (flag == 'y');
            */
            /* //Pattren Method
            Console.WriteLine("Enter range : ");
            int range = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= range; i++)
            {
                Console.WriteLine();      //for blank line
                for (int j =1; j <= i; j++)
                {
                    Console.Write("*");
                }
            }
            */


            Console.ReadLine();
        }
    }
}

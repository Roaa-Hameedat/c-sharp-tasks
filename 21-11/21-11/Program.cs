using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double number1 = Convert.ToDouble(Console.ReadLine());
            double number2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("the small number is:");

            if (number1 < number2)
            {
                Console.WriteLine(number1);

            }
            else
                Console.WriteLine(number2);


            ///////////////////////////////////////////////////////////////////////////////////////////

            double yourumb = Convert.ToDouble(Console.ReadLine());
            Console.Write("your number is:");
            Console.WriteLine(yourumb);
            if (yourumb < 0)
            {
                Console.Write("The sign is :\t");
                Console.WriteLine("-");
            }
            else
                Console.WriteLine("+");


            /////////////////////////////////////////////////////////////////////////////////////////////

            double numb1 = Convert.ToDouble(Console.ReadLine());
            double numb2 = Convert.ToDouble(Console.ReadLine());
            double numb3 = Convert.ToDouble(Console.ReadLine());

            if (numb1 > numb2 && numb1 > numb3)
            {
                Console.WriteLine(numb1);
                if (numb2 > numb3)
                {
                    Console.WriteLine(numb2);
                    Console.WriteLine(numb3);
                }
                else
                {
                    Console.WriteLine(numb3);
                    Console.WriteLine(numb2);
                }
            }

            if (numb2 > numb1 && numb2 > numb3)
            {
                Console.WriteLine(numb2);
                if (numb1 > numb3)
                {
                    Console.WriteLine(numb1);
                    Console.WriteLine(numb3);
                }
                else
                {
                    Console.WriteLine(numb3);
                    Console.WriteLine(numb1);
                }
            }


            if (numb3 > numb1 && numb3 > numb2)
            {
                Console.WriteLine(numb3);
                if (numb1 > numb2)
                {
                    Console.WriteLine(numb1);
                    Console.WriteLine(numb2);

                }
                else
                {
                    Console.WriteLine(numb2);
                    Console.WriteLine(numb1);
                }
            }


            ////////////////////////////////////////////////////////////////////////////////

            int n1 = 1;
            int n2 = 2;
            int n3 = 3;
            int n4 = 4;
            int n5 = 5;


            if (n1 > n2 && n1 > n3 && n1 > n4 && n1 > n5)
            {
                Console.WriteLine(n1);
            }

            if (n2 > n1 && n2 > n3 && n2 > n4 && n2 > n5)
            {
                Console.WriteLine(n2);
            }

            if (n3 > n1 && n3 > n2 && n3 > n4 && n3 > n5)
            {
                Console.WriteLine(n3);
            }

            if (n4 > n1 && n4 > n2 && n4 > n3 && n4 > n5)
            {
                Console.WriteLine(n4);
            }

            else
            {
                Console.WriteLine(n5);
            }

            ///////////////////////////////////////////////////////////////////////////////////////////////


            Console.Write("your number in kilometers per hour  is :  ");
            double k_h = 15;
            Console.WriteLine(k_h);
            Console.WriteLine("your number miles per hour is :  ");
            k_h = k_h / 1.609344;
            Console.Write(k_h);

            //////////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("inter hours:");
            int hour = Convert.ToInt32(Console.ReadLine());
            hour = hour * 60;
            int minutes = Convert.ToInt32(Console.ReadLine());
            int total = hour + minutes;
            Console.WriteLine("total in minutes :  ");
            Console.WriteLine(total);


            //////////////////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("inter minutes :");
            int mnt = Convert.ToInt32(Console.ReadLine());
            Console.Write("Hours :");
            int our = mnt / 60;
            Console.WriteLine(our);
            int ment = mnt % 60;
            Console.Write("Minutes :");
            Console.WriteLine(ment);



            ///////////////////////////////////////////////////////////////////////////////////////////

            string[] array = { "roaa", "bushra", "joody", "yasameen" };
            string index1 = array[0];
            Console.WriteLine(index1.Substring(0, 3));
            string index2 = array[1];
            Console.WriteLine(index2.Substring(0, 3));
            string index3 = array[2];
            Console.WriteLine(index3.Substring(0, 3));
            string index4 = array[3];
            Console.WriteLine(index4.Substring(0, 3));
            string index5 = array[4];
            Console.WriteLine(index5.Substring(0, 3));



        }
    }
}

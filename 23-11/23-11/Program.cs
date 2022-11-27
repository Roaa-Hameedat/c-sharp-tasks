using Microsoft.Win32;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Methods
{
    internal class Program
    {
        //method task1
        static double [] task1(double[] array)
        {
           double sum = 0;
            double avareg = 0; 
            for(int i=0;i<10;i++)
            {
              sum+= array[i];
            }

            
            
            avareg=sum/10;
            double[] result = { sum, avareg };
            return result;
        }
        //method task2
        static int cube(int x)
        {
            int t = x*x*x;
            return t;
        }

        static void task3(int [] arrayOFyears)
        {
            for(int i=0;i< arrayOFyears.Length;i++)
            {
                int year = arrayOFyears[i]; 
                if (year > 1950)
                {
                    Console.WriteLine(year);
                }
            }
            
        }

        static int task4( int a)
        {
            int age = a * 360;
            return age;
        }

        static int task5(int a,int b,int c) {
            int totalCHickens = a * 2;
            int totalCow = b * 4;
            int totalPig = c * 4;
            int totalOFlegs=totalCHickens+ totalCow + totalPig;
            return totalOFlegs ;
        }
        static void  task6(string username,int password)
        {
            string[] use1 = { "roaa", "omar", "hmaidat" };
            int[] pas1 = { 12345, 246810, 13579 };
            if (use1[0] ==username && pas1[0]==password) {
                Console.WriteLine("sucsses login ");

            }
            else
            {
                Console.WriteLine("faild login");
            }
        }


        static double task7(double a,double b)
        {
            double power = Math.Pow(a, b);
            Console.WriteLine($"the number is {a} power of {b}=  {power}");
            return power ;
        }
        static void task8(int a)
        {
            if (a == 1900)
            {
                Console.WriteLine("its not leap year");
            }
            else if (a % 4 == 0)
            {
                Console.WriteLine("its a leap year");
            }
            else
            {
                Console.WriteLine("its not leap year");
            }
        }

        static string task9(int a)
        {
            for (int i=2;i<a;i++)
            {
                if (a%i == 0)
                {
                    return "not prime ";
                }
               
            }
            return "its prime ";
        }


        static void task10()
        {
            Console.WriteLine("write a sentance");
            string sentance = Console.ReadLine();
            string[] arri = sentance.Split(' ');
            Console.WriteLine(arri.Length);
        }

        static void Main(string[] args)
        {


            Console.WriteLine("inter 10 numbers seperated whit (,) ");
            string[] arra = Console.ReadLine().Split(',');
            double[] ints = Array.ConvertAll(arra, s => Convert.ToDouble(s));
            double[] rslt = task1(ints);
            double sum = rslt[0];
            double avarage = rslt[1];
            Console.WriteLine($"the sum is {sum} and the avarage is {avarage}");

            Console.WriteLine("inter your number ");
            int numbere = Convert.ToInt32(Console.ReadLine());
            Console.Write("cube of the " + numbere + " is :");
            Console.WriteLine(cube(numbere));


            int[] years = { 1763, 1972, 1925, 1916, 1984, 1124, 1950, 2020 };
            task3(years);

            Console.WriteLine("inter how old ar you in years ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("your age in days is :");
            Console.WriteLine(task4(age) + "  days ");
            Console.WriteLine(" ");


            Console.WriteLine("=================task 5==================");
            Console.WriteLine("inter how many chickens  you have ");
            int chicken = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("inter how many cows  you have ");
            int cow = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("inter how many pigs   you have ");
            int pig = Convert.ToInt32(Console.ReadLine());
            Console.Write("Total of animals legs is:   ");
            Console.WriteLine(task5(chicken, cow, pig));
            Console.WriteLine("");



            Console.WriteLine("=================task 6====================");

            task6("roaa", 12345);


            Console.WriteLine("=================task 7====================");
            Console.WriteLine("inter the number :");
            int preparation = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("inter the power :");
            int power = Convert.ToInt32(Console.ReadLine());
            task7(preparation, power);
            Console.WriteLine(" ");



            Console.WriteLine("=================task 8====================");
            Console.WriteLine("inter year  from range 1900-2024 to know if it leap or not");
            int year = Convert.ToInt32(Console.ReadLine());
            task8(year);
            Console.WriteLine("");


            Console.WriteLine("=================task 9====================");
            int adad = Convert.ToInt32(Console.ReadLine());
            task9(adad);
            Console.WriteLine("");



            Console.WriteLine("=================task 10====================");

            task10();





        }   }    

}

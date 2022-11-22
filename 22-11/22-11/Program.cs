using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace _22_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //   	string[] ARR = [1, 7  9  45, ]
            //     arr2 =["Str" "alex", "moh"
            // string arr3 = 'the', 'fox' 'over' lazy, 'dog',  ]


            //string[] ARR = { "1", "7", "9", "45" };
            //OR mack it int [] ARR= {1,2,3,4};

            //string[] arr2 = { "str", "alex", "moh" };
            //string[] arr3 = { "the", "fox", "over", "lazy ", "dog" };


            ////////////////////////////////////////////////////////////////////////////////////////////////////


            //String[] fruits = { "Tomato", "Banana", "Watermelon" };
            //Console.Write("the index of tomato is :");
            //Console.WriteLine( Array.IndexOf(fruits,"Tomato"));

            //Console.Write("the index of Banana is :");
            //Console.WriteLine(Array.IndexOf(fruits, "Banana"));

            //////////////////////////////////////////////////////////////////////////////////////////////////////

            //Console.WriteLine("\"Favorite Food\" ");

            //string[] food = { "mansaf", "pizza", "shawerma", "burger", "msakhan" };
            //foreach(string foods in food)
            //       {
            //    Console.WriteLine(foods); 
            //        };
            //Console.WriteLine("\"Favorite Sport\" ");

            //string[] sport = { "football", "tinss", "basketball" };
            //for(int i = 0; i < sport.Length;i++)
            //{
            //    Console.WriteLine(sport[i]);
            //}

            //Console.WriteLine("\"Favorite Movie \" ");

            //string[] movie = {"malefecent","croualla","frozen" };
            //foreach(string movies in movie)
            //{
            //    Console.WriteLine(movies);
            //}

            /////////////////////////////////////////////////////////////////////////////////////////////////
            // Console.WriteLine("inter three number as :num1 , num2 ,num3 ");
            // string number = Console.ReadLine();
            // string[] arrai = number.Split(',');
            // int sum = 0;
            // for (int i = 0; i < arrai.Length;i++)
            // {

            //     sum = sum + Convert.ToInt32(arrai[i]);  
            //}
            // Console.WriteLine("the sum of numbes is :");
            // Console.WriteLine(sum);

            ////////////////////////////////////////////////////////////////////////////////////////////////////


            //int total = 0;
            //for(int i=1; i<100; i++)
            //{

            //    if (i%2 !=0)
            //    {
            //        total = total + i;
            //        Console.WriteLine(i);
            //    }
            //}
            //    Console.WriteLine(total);


            ////////////////////////////////////////////////////////////////////////////////////////////////////////

            //string star = "*";
            //for (int i = 1; i < 5; i++)
            //{
            //    Console.WriteLine(star);
            //    star = star + "*";
            //}

            //////////////////////////////////////////////////////////////////////////////////////////////////


            //for (int i = 4; i > 0; i--)
            //{
            //    string star = "*";
            //    string str = new string(' ',i);
            //    for (int x=5;x<i;) 
            //    {
            //        Console.WriteLine(star);
            //        star = star + "*";
            //        x--;
            //    }

            //}

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////

            int num = 0;
            for(int i=1;i<5;i++)
            {
                for(int x=1;x<=i ;x++) {
                    num++;
                    Console.Write(num);
                   
                }
                Console.WriteLine();
            }
        }
    }
}

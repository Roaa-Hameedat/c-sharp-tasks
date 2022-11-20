using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace project_1
{
    internal class Program
    {
        static void Main(string[] args)
            
        {
            Console.WriteLine("inter your mame :");
            string y = Console.ReadLine();
            Console.WriteLine(y);



            
            string name = "roaa";
            int myNum = 24;
            double mySalary = 1000000.9;
            char myLetter = 'R';
            bool myBool = true;
            const double pie =3.14;

            Console.WriteLine(name);
            Console.WriteLine(myNum);
            Console.WriteLine(mySalary);
            Console.WriteLine(myLetter);
            Console.WriteLine(myBool);
            Console.WriteLine(pie);



            string[] cars = { "kia", "Hyundai", "Audi" };
            Console.WriteLine(cars[0]);
            Console.WriteLine(cars[1]);
            Console.WriteLine(cars[2]);

            Console.WriteLine("inter your first name :");
            string f1= Console.ReadLine();
            Console.WriteLine("inter your last name :");
            string f2 = Console.ReadLine();
            Console.WriteLine("Input your year of birth:");
            string f3 = Console.ReadLine();
            Console.Write(f1);
            Console.Write("  ");
            Console.Write(f2);
            Console.Write("  ");
            Console.Write(f3);


            int [] arr = { 1, 1, 2,3,4,5,6,7,8,9 };
            Console.Write("Elements in array are");
            Console.Write(arr[0]);
            Console.Write("  ");
            Console.Write(arr[1]);
            Console.Write("  ");
            Console.Write(arr[2]);
            Console.Write("  ");
            Console.Write(arr[3]);
            Console.Write("  ");
            Console.Write(arr[4]);
            Console.Write("  ");
            Console.Write(arr[5]);
            Console.Write("  ");
            Console.Write(arr[6]);
            Console.Write("  ");
            Console.Write(arr[7]);
            Console.Write("  ");
            Console.Write(arr[8]);

            int A = arr[0] + arr[1] + arr[2] + arr[3] + arr[4] + arr[5] + arr[6] + arr[7] + arr[8];

            Console.Write("the sum of the array is:");
            Console.Write(A);

        }
       
    }
}

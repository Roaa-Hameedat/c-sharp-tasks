using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _28_11
{
    class car {
        public string maker { get; set; }
        public int year { get; set; }
        public string type { get; set; }
        public int price { get; set; }
        public string model { get; set; }
        public int pallet { get; set; }
        public string color { get; set; }

        public car (){
                  }
      static  void start()
        {
            Console.WriteLine("your car is starting ..........");
        }
        static void off()
        {
            Console.WriteLine("goodbye..........");
        }

        static void lter(int l)
        {
            int km = l * 2;
            Console.WriteLine($"you have {l} litter It will probably suffice you to drive about {km} km ");
        }
        public car(string maker1, int year1, string type1, int price1, string model1, int pallet1, string color1) 
        {
            maker= maker1;
            year= year1;
            type= type1;
            price= price1;
            model= model1;
            pallet= pallet1;
            color = color1;

        
        }
        class car1 : car {

            public car1(string maker1, int year1, string type1, int price1, string model1, int pallet1, string color1)
            {
                maker = maker1;
                year = year1;
                type = type1;
                price = price1;
                model = model1;
                pallet = pallet1;
                color = color1;


            }

        }
        public void all_info()
        {
            Console.WriteLine("Your Car's Make in : " + maker);
            Console.WriteLine("Your Car's from : " + year + " Year");
            Console.WriteLine("Your Car's Type  : " + type);
            Console.WriteLine("Price The Car : " + price);
            Console.WriteLine("Your Car's Model : " + model);
            Console.WriteLine("Your Car's Pallet : " + pallet);
            Console.WriteLine("Your Car's Color : " + color);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            car Car = new car("japan", 2023, "Fusion", 50000, "Fusion", 12345, "black");
         
           Car.all_info();

        }
    }
}

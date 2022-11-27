using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using using_multiple_classes;

namespace using_multiple_classes
{
    class PersonalInformation
    {
        private string name;
        private double age;
        private string gender;
        private int id;
        private string email;
        private string number;


        public PersonalInformation(string name1, double age1, string gender1, int id1, string email1, string number1)
        {
            age = age1;
            if (age1 < 18 || age1 > 60)
            {
                Console.WriteLine("age is not accepted");
            }

            gender = gender1;
            name = name1;
            email = email1;
            id = id1;

            if (number1.Substring(0, 3) == "077" || number1.Substring(0, 3) == "079" || number1.Substring(0, 3) == "078")
            {
                number = number1;

            }
            else
            {
                Console.WriteLine("please inter jordanian number ");
            }
        }

            internal class Program
        {
            static void Main(string[] args)
            {
                PersonalInformation roaa = new PersonalInformation("roaa", 24, "femail", 55555, "roaa@gmail.com", "0776120376");
                Console.WriteLine(roaa.name);
            }
        }

    }

    }

   


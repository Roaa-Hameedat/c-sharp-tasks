using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _29_11
{
    class Employe
    {
        public string name { get; set; }
        public int id { get; set; }
        public DateTime birth { get; set; }
        public Employe(string name, int id, int day, int month, int year)
        {
            this.name = name;
            this.id = id;
            birth = new DateTime(year, month, day);

        }

        public void age()
        {
            DateTime now = DateTime.Now; TimeSpan value = now.Subtract(birth);

            Console.WriteLine("AGE : "+(int)value.TotalDays / 365);

        }
        public virtual void print() { Console.WriteLine(name + " " + id + " " + birth); }

    }
    class Manager : Employe
    {
        public Manager(string name, int id, int day, int month, int year) : base(name, id, day, month, year)
        {
        }
        public override void print()
        {
            Console.WriteLine ($"NAME: {name}  \n ID : {id} "  );
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Manager myInfo = new Manager("roaa", 5, 4, 5, 1998);
            myInfo.print();
            myInfo.age();


        }
    }
}

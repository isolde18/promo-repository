using System;

namespace ConsoleAppUI
{
    class Program
    {
        string name, city;
        int age;

        public void acceptdetails()
        {
            Console.Write("\nEnter your name:\t");
            name = Console.ReadLine();

            Console.Write("\nEnter your city:\t");
            city = Console.ReadLine();

            Console.Write("\nEnter your age:\t\t");
            age = int.Parse(Console.ReadLine());
        }

        public void printdetails()
        {
            Console.Write("\n\n================");
            Console.Write($"\nName:\t{name}");
            Console.Write($"\nCity:\t{city}");
            Console.Write($"\nAge:\t{age}");
            Console.Write("\n================\n");
        }

        static void Main(string[] args)
        {
            //creating object of class Program
            Program p = new Program();
            p.acceptdetails();//calling method
            p.printdetails();//calling method
            Console.ReadLine();
        }
    }
}

using System;
using Person;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee person1 = new Employee("Novak", "Artem", "Filipovytch", new DateTime(2018, 6, 17),
                new PlaceOfWork("ISM", new Address("Ukraine", "Zhytomyr", "Capitulny", 20, 10002), "0412 445 403", 
                "ism-ukraine.com"), "Software Developer", 2000);

            Employee person2 = new Employee("Gorbusheva", "Iryna", "Andriivna", new DateTime(2015, 12, 29),
                new PlaceOfWork("Salad", new Address("Ukraine", "Zhytomyr", "Ivana Kochergy", 3, 10002), "0800 508 110"), "HR", 750);

            Console.WriteLine($"\tPerson-1\n{person1.GetInfo()}\n");
            Console.WriteLine($"\tPerson-2\n{person2.GetInfo()}");
        }
    }
}

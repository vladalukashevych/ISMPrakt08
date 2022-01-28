using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public class Employee
    {
        public string LastName { set; get; }
        public string FirstName { set; get; }
        public string Patronymic { set; get; }
        public DateTime DateOfEmployment { set; get; }
        public string PlaceOfWork { set; get; }
        public string Position { set; get; }
        public int Salary { set; get; }

        public Employee(string lastName, string firstName, string patronymic, DateTime dateOfEmployment,
            string placeOfWork, string position, int salary)
        {
            LastName = lastName;
            FirstName = firstName;
            Patronymic = patronymic;
            DateOfEmployment = dateOfEmployment;
            PlaceOfWork = placeOfWork;
            Position = position;
            Salary = salary;
        }

        public Employee(Employee employee)
        {
            LastName = employee.LastName;
            FirstName = employee.FirstName;
            Patronymic = employee.Patronymic;
            DateOfEmployment = employee.DateOfEmployment;
            PlaceOfWork = employee.PlaceOfWork;
            Position = employee.Position;
            Salary = employee.Salary;
        }

        public string GetInfo()
        {
            return $"Full name: {LastName} {FirstName} {Patronymic}\nDate of employment: {DateOfEmployment.Date}\n" +
                $"Place of work: {PlaceOfWork}\nPosition: {Position}\nSalary: {Salary}$";
        }
    }
}

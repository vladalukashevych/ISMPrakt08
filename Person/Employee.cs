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

        public PlaceOfWork PlaceOfWork;
        public string Position { set; get; }
        public int Salary { set; get; }

        public Employee(string lastName, string firstName, string patronymic, DateTime dateOfEmployment,
           PlaceOfWork placeOfWork, string position, int salary)
        {
            LastName = lastName;
            FirstName = firstName;
            Patronymic = patronymic;
            DateOfEmployment = dateOfEmployment;
            PlaceOfWork = new PlaceOfWork(placeOfWork);
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
            return $"Full name: {LastName} {FirstName} {Patronymic}\nDate of employment: {DateOfEmployment.ToString("d")}\n" +
                $"Place of work: {PlaceOfWork.GetPlaceOfWorkInfo()}\nPosition: {Position}\nSalary: {Salary}$";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    public class Employee
    {
        private int id, salary;
        private string firstname, lastname;

        public Employee(int id,int salary,string firstname,string lastname)
        {
            this.id = id;
            this.salary = salary;
            this.firstname = firstname;
            this.lastname = lastname;
        }
        public int getID()
        {
            return id;
        }
        public string getFirstName()
        {
            return firstname;
        }
        public string getLastName()
        {
            return lastname;
        }
        public int getSalary()
        {
            return salary;
        }
        public void setSalary(int Salary)
        {
            salary = Salary;
        }
        public int getAnnualSalary()
        {
            return salary * 12;
        }
        //public int raiseSalary(int percent)
        //{

        //}
        public override string ToString()
        {
            return string.Format("Employee[id=?,name={0}{1},salary={2}]",getFirstName(),getLastName(),getSalary());

        }
    }
}

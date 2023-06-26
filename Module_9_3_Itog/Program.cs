using System.Xml.Linq;
using System.Collections.Generic;
using static Module_9_3_Itog.Program;

namespace Module_9_3_Itog
{
    public class Program
    {
        public delegate bool EligibleToPromotion(Employee EmployeeToPromotion);
        static void Main(string[] args) 
        {
            Employee empl1 = new Employee()
            {
                ID = 55,
                Name = "Алексей",
                Experience = 5,
                Salary = 20000

            };
            Employee empl2 = new Employee()
            {
                ID = 56,
                Name = "Коля",
                Experience = 6,
                Salary = 10000
            };
            Employee empl3 = new Employee()
            {
                ID = 56,
                Name = "Миша",
                Experience = 2,
                Salary = 12000
            };
            List<Employee> listEmployees = new List<Employee>();
            listEmployees.Add(empl1);
            listEmployees.Add(empl2);
            listEmployees.Add(empl3);

            EligibleToPromotion eligible = Promote;
            Employee.PromoteEmployee(listEmployees, eligible);
        }
        public static bool Promote(Employee employee) 
        { 
            if (employee.Salary > 10000) 
            {
                return true;
            }
            else 
            {
                return false;
            }
                
        }
    }
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Experience { get; set; }
        public int Salary { get; set; }

        public static void PromoteEmployee(List<Employee> listEmployees, Program.EligibleToPromotion IsEmployeeEligible)
        {
            foreach(Employee employee in listEmployees)
            {
                if (IsEmployeeEligible(employee)) 
                { 
                    Console.WriteLine($"{employee.Name}, Уходит на повышение");
                }
            }
        }
    }

}
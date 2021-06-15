using System;
using SampleCompany.Employee_information;


namespace SampleCompany
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee firstEmployee = new Employee(1001, "John Doe", "12/12/2020");
            Employee secondEmployee = new Employee(1002, "Jane Doe", "13/12/2020");
            Employee thirdEmployee = new Employee(1003, "John Thomas", "14/12/2020");
            Employee fourthEmployee = new Employee(1004, "outOf Names", "15/12/2020");
            Employee fifthEmployee = new Employee(1005, "outOf Names2", "16/12/2020");


            firstEmployee.JobTitle = "Frontend Developer";
            secondEmployee.JobTitle = "Backend Developer";
            thirdEmployee.JobTitle = "Head HR";
            fourthEmployee.JobTitle = "Business Analyst";
            fifthEmployee.JobTitle = "DevOps Engineer";

            firstEmployee.Department = "Engineering";
            secondEmployee.Department = "Engineering";
            thirdEmployee.Department = "Human Resiurces";
            fourthEmployee.Department = "Business Development";
            fifthEmployee.Department = "Engineering";

            Employee[] employeeArray = new Employee[5] { firstEmployee, secondEmployee, thirdEmployee, fourthEmployee, fifthEmployee };



            foreach (Employee i in employeeArray)
            {
                Console.WriteLine(i.staffId + "\t\t" + i.fullName + "\t" + i.employmentDate + "\t" + i.Department + "\t\t" + i.JobTitle + "\n");
                
            }
        }
    }
}

            

        




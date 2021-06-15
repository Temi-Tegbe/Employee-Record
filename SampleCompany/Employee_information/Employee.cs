using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCompany.Employee_information
{
    class Employee
    {
        private readonly int _staffId;
        private readonly string _fullName;
        private readonly string _employmentDate;
        private string _jobTitle;
        private string _department;
        public Employee(int staffId, string fullName, string employmentDate)
        {
            _staffId = staffId;
            _fullName = fullName;
            _employmentDate = employmentDate;
        }

        public int staffId
        {
            get => _staffId;
        }

        public string fullName
        {
            get => _fullName;
        }

        public string employmentDate
        {
            get => _employmentDate;
        }

        public string JobTitle

        {
            get => _jobTitle;

            set { _jobTitle = value; }
        }

        public string Department

        {
            get => _department;
            set { _department = value; }

        }

        public void ClockIn()
        {
            Console.WriteLine("I am clocking in");
        }

        public void ClockOut()
        {
            Console.WriteLine("I am clocking out");
        }

        public void Work()
        {
            Console.WriteLine("I am currently working");
        }
    }
}

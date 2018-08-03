﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Employee
    {
        public string Name { get; }
        public string Department { get; }
        public int WorkingHours { get; }
        public int SalaryPerHour { get; }
        public int Wage() => WorkingHours * SalaryPerHour;
        //public int Wage { get { return WorkingHours * SalaryPerHour; } }
        public DateTime DateOfEmployment { get; set; } = DateTime.Now;

        

        public Employee()
        {

        }

        public Employee(string name, int workingHours, int salaryPerHour, string department)
        {
            this.Name = name;
            this.WorkingHours = workingHours;
            this.SalaryPerHour = salaryPerHour;
            this.Department = department;
        }

        public string ShowEmployeeData()
        {
            return $"Name: {Name}, Wage: {Wage()}, Department {Department}";
        }
        
    }
}

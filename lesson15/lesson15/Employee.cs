﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson15
{
    class Employee
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public int WorkingHours { get; set; }
        public int SalaryPerHour { get; set; }
        public int Wage() => WorkingHours * SalaryPerHour;
        //public int Wage { get { return WorkingHours * SalaryPerHour; } }
        public DateTime DateOfEmployment { get; set; } = DateTime.Now;



        public Employee(string name, int workingHours, int salaryPerHour, string department)
        {
            this.Name = name;
            this.WorkingHours = workingHours;
            this.SalaryPerHour = salaryPerHour;
            this.Department = department;
        }
    }
}

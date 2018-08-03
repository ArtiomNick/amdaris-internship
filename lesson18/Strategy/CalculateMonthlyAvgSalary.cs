﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class CalculateMonthlyAvgSalary : ICalculateAvgSalary
    {
        public double CalculateAvgSalary(List<Employee> employees)
        {
            double sum = 0;
            foreach(Employee employee in employees)
            {
                sum += employee.SalaryPerHour * employee.WorkingHours;
            }
            return sum * 4 / employees.Count;
        }
    }
}
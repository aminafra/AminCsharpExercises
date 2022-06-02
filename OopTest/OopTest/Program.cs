using System;
using System.Collections.Generic;
using ClassLibrary1;

namespace OopTest
{
    
    class Program
    {
        static void Main(string[] args)
        {
            List<Salary> slryLst = new List<Salary>();

            slryLst.Add(new Salary("amin", 8, 1000));
            slryLst.Add(new Salary("ali", 10, 600));
            slryLst.Add(new Salary("samin", 6, 700));
            slryLst.Add(new Salary("farid", 11, 500));
            slryLst.Add(new Salary("paniz", 7, 750));
            Console.WriteLine("NAME --- WORKING HOURS -- SALARIES PER HOUR -- DAILY SALARY --- SALARY ");
            foreach (var item in slryLst)
            {
                Console.WriteLine($" {item.Name}  -----  {item.WorkingHours}  -----------  {item.SPH}  ------------  {item.Daily()}  --------  {item.Monthly()}");
            }
        }
    }
}
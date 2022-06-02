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

            //slryLst.Add(new Salary("amin", 8, 1000));
            //slryLst.Add(new Salary("ali", 10, 600));
            //slryLst.Add(new Salary("samin", 6, 700));
            //slryLst.Add(new Salary("farid", 11, 500));
            //slryLst.Add(new Salary("paniz", 7, 750));
            Console.WriteLine("how many people do you want to enter?");
            int k = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < k; i++)
            {
                Console.WriteLine("enter name:");
                var name = Console.ReadLine();
                Console.WriteLine("enter working hours:");
                int wHD = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter SALARIES PER HOUR:");
                int sPH = Convert.ToInt32(Console.ReadLine());

                slryLst.Add(new Salary(name, wHD, sPH));
            }
            Console.WriteLine("NAME --- WORKING HOURS -- SALARIES PER HOUR -- DAILY SALARY --- SALARY ");
            foreach (var item in slryLst)
            {
                Console.WriteLine($" {item.Name}  -----  {item.WorkingHours}  -----------  {item.SPH}  ------------  {item.Daily()}  --------  {item.Monthly()}");
            }
        }
    }
}
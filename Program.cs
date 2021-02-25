using System;
using Tarea1.Models;
using System.Linq;

namespace Tarea1
{
    class Program
    {
        public static void exercise()
        {
            NorthwindContext dataContext = new NorthwindContext();

            var employeeQuery = dataContext.Employees.Select(s => s).AsQueryable();

            var output = employeeQuery.ToList();
        }

        static void Main(string[] args)
        {
            exercise();
        }
    }
}

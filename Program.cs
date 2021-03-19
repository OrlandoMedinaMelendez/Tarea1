using System;
using Tarea1.Models;
using Tarea1.Back_End;
using System.Linq;

namespace Tarea1
{
    class Program
    {
        public static EmployeeSC employeeService = new EmployeeSC();
        public static OrderSC orderService = new OrderSC();
        public static ProductSC productService = new ProductSC();

        #region Functions

        public static void AddEmployee()
        {
            var newEmployeeAdd = new Employee();

            newEmployeeAdd.FirstName = "Nimani";
            newEmployeeAdd.LastName = "Bravo";

            employeeService.AddEmployee(newEmployeeAdd);
        }

        public static void UpdateEmployee()
        {
            employeeService.UpdateNameEmployeeById(1, "Jorge");
        }

        #endregion

        
        static void Main(string[] args)
        {
            //AddEmployee();
            //UpdateEmployee();
        }
    }
}

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

        #region EmployeeFunctions

        public static void AddEmployee()
        {
            var newEmployeeAdd = new Employee();

            Console.WriteLine("\nEscribe el nombre del nuevo empleado: ");
            newEmployeeAdd.FirstName = Console.ReadLine();
            Console.WriteLine("\nEscribe el apellido del nuevo empleado: ");
            newEmployeeAdd.LastName = Console.ReadLine();

            employeeService.AddEmployee(newEmployeeAdd);
        }

        public static void UpdateEmployee()
        {
            employeeService.UpdateNameEmployeeById(1, "Jorge", "Martinez");
        }

        #endregion

        #region OrderFunctions

        public static void AddOrder()
        {
            var newOrderAdd = new Order();

            Console.WriteLine("\nEscribe el nombre de la ruta de la nueva orden: ");
            newOrderAdd.ShipName = Console.ReadLine();
            Console.WriteLine("\nEscribe la ciudad de la nueva orden: ");
            newOrderAdd.ShipCountry = Console.ReadLine();

            orderService.AddOrder(newOrderAdd);
        }

        public static void UpdateOrder()
        {
            orderService.UpdateShipNameOrderById(10248, "Rio Bravo");
        }

        #endregion

        #region ProductFunctions

        public static void AddProduct()
        {

        }

        public static void UpdateProduct()
        {

        }

        #endregion

        static void Main(string[] args)
        {
            AddEmployee();
            UpdateEmployee();
        }
    }
}

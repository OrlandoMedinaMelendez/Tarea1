using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea1.Models;

namespace Tarea1.Back_End
{
    public class EmployeeSC : BaseSC, IWrite, IRead
    {

        public IQueryable<Employee> GetEmployees()
        {    
            return dataContext.Employees.AsQueryable(); 
        }
        
        public Employee GetEmployeeById(int id)
        {
            return GetEmployees().Where(x => x.EmployeeId == id).First();
        }

        public void AddEmployee(Employee newEmployee)
        {

            var newEmployeeReg = new Employee();
            newEmployeeReg.FirstName = newEmployee.FirstName;
            newEmployeeReg.LastName = newEmployee.LastName;

            dataContext.Employees.Add(newEmployeeReg);
            dataContext.SaveChanges();

        }

        public void UpdateNameEmployeeById(int id, String name, String lastName)
        {
            var currentEmployee = new EmployeeSC().GetEmployeeById(id);
            currentEmployee.FirstName = name;
            currentEmployee.LastName = lastName;
            dataContext.Employees.Update(currentEmployee);
            dataContext.SaveChanges();
        }

        // Funcion que obtiene todos los empleados en la ciudad de Londres
        public void Query1()
        {
            var employeeQuery = dataContext.Employees.Select(s => s).Where(w => w.City == "London").AsQueryable();
            var output = employeeQuery.ToList();
        }

        // Funcion para asignar la región 'North' a todos los empleados que dependen del empleado del ID dado
        public void Query2(int id)
        {
            List<Employee> reportsToEmployee = GetEmployeeReportsTo(id);

            if (reportsToEmployee == null)
                throw new Exception("No se encontró el empleado con el ID proporcionado");

            foreach (var employee in reportsToEmployee)
            {
                employee.Region = "North";
            }

            dataContext.SaveChanges();
        }

        // Funcion para obterner una lista de empleados que se reportan con el empleado del ID dado
        private List<Employee> GetEmployeeReportsTo(int id)
        {
            return dataContext.Employees.Select(s => s).Where(w => w.ReportsTo == id).ToList();
        }

        // Funcion para cambiar el nombre del empleado con el ID dado
        public void Query3(int id)
        {
            Employee currentEmployee = GetEmployeeById(id);

            if (currentEmployee == null)
                throw new Exception("No se encontró el empleado con el ID proporcionado");

            Console.WriteLine("Introduzca el nuevo nombre del empleado");
            String nombre;
            nombre = Console.ReadLine();

            currentEmployee.FirstName = nombre;
            dataContext.SaveChanges();
        }

        
        public object GetAll()
        {
            return dataContext.Employees.AsQueryable();
        }

        public object GetById(int id)
        {
            return GetEmployees().Where(x => x.EmployeeId == id).First();
        }

        public void Create(int id)
        {
            throw new NotImplementedException();
        }
    }
}

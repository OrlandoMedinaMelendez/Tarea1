using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea1.Models;

namespace Tarea1.Back_End
{
    public class EmployeeSC : BaseSC
    {
        public IQueryable<Employee> GetEmployees()
        {    
            return dataContext.Employees.AsQueryable(); 
        }

        public Employee GetEmployeeByName(String name)
        {
            return GetEmployees().Where(x => x.FirstName == name).First();
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

        public void UpdateNameEmployeeById(int id, String name)
        {
            var currentEmployee = new EmployeeSC().GetEmployeeById(id);
            currentEmployee.FirstName = name;
            dataContext.Employees.Update(currentEmployee);
            dataContext.SaveChanges();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private List<Employee> employees;
        public EmployeeRepository()
        {
            employees  = new List<Employee>()
            {
                new Employee(){Id=1, Name="Bob",Department="Finance",EmailId="bob@org.com"},
                new Employee(){Id=2, Name="Jamy",Department="HR",EmailId="jamy@org.com"},
                new Employee(){Id=3, Name="Thomas",Department="Finance",EmailId="thomas@org.com"}
            };
        }

        public Employee AddOrUpdateEmployee(Employee employee)
        {
            Employee existingEmployee = employees.FirstOrDefault( e => e.Id == employee.Id);
            if(existingEmployee != null )
            {
                existingEmployee.Name = employee.Name;
                existingEmployee.Id = employee.Id;
                existingEmployee.Department = employee.Department;
                existingEmployee.EmailId = employee.EmailId;
            }
            return existingEmployee;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return employees;
        }

        public Employee GetEmployee(int Id)
        {
            return employees.FirstOrDefault(x => x.Id == Id);
        }

        public Employee DeleteEmployee(Employee employee)
        {
            Employee existingEmployee = employees.FirstOrDefault(e => e.Id == employee.Id);
            if (existingEmployee != null)
            {
                employees.Remove(existingEmployee);
            }
            return existingEmployee;
        }
    }
}

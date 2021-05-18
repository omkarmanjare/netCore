using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class SQLEmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext appDbContext;

        public SQLEmployeeRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public Employee AddOrUpdateEmployee(Employee employee)
        {
            appDbContext.Employees.Add(employee);
            appDbContext.SaveChanges();
            return employee;
        }

        public Employee DeleteEmployee(Employee employee)
        {
            Employee existingEmployee = appDbContext.Employees.Find(employee.Id);
            if(existingEmployee != null)
            {
                appDbContext.Employees.Remove(existingEmployee);
                appDbContext.SaveChanges();
                
            }
            return existingEmployee;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return appDbContext.Employees; 
        }

        public Employee GetEmployee(int Id)
        {
            return appDbContext.Employees.Find(Id);
        }
    }
}

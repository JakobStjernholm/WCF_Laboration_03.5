using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace NwnService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EmployeeService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select EmployeeService.svc or EmployeeService.svc.cs at the Solution Explorer and start debugging.
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class EmployeeService : IEmployeeService
    {
        public void AddEmployee(Employee employee)
        {
            try
            {
                using (var context = new NORTHWNDEntities())
                {
                    Employees newEmployee = new Employees
                    {
                        Address = employee.Address,
                        BirthDate = employee.BirthDate,
                        City = employee.City,
                        Country = employee.Country,
                        FirstName = employee.FirstName,
                        HireDate = employee.HireDate,
                        HomePhone = employee.HomePhone,
                        LastName = employee.LastName,
                        PostalCode = employee.PostalCode,
                        Region = employee.Region,
                        Title = employee.Title,
                        TitleOfCourtesy = employee.TitleOfCourtesy

                    };
                    context.Employees.Add(newEmployee);
                    context.SaveChanges();
                }
            }
            catch(FaultException)
            {
                throw new FaultException("Could not add employee at this moment!");
            }
        }
        public Employee GetEmployee(int id)
        {
            try
            {
                using (var context = new NORTHWNDEntities())
                {
                    var employee = context.Employees.Where(x => x.EmployeeID == id).Select(x => new Employee
                    {
                        BirthDate = x.BirthDate,
                        HireDate = x.HireDate,
                        Title = x.Title,
                        TitleOfCourtesy = x.TitleOfCourtesy,
                        Region = x.Region,
                        FirstName = x.FirstName,
                        HomePhone = x.HomePhone,
                        Address = x.Address,
                        LastName = x.LastName,
                        City = x.City,
                        Country = x.Country,
                        PostalCode = x.PostalCode,
                        EmployeeID = x.EmployeeID
                    }).FirstOrDefault();
                    if (employee == null)
                        throw new FaultException("Employee doesn't exists!");
                    return employee;
                }
            }
            catch (Exception ex)
            {
                throw new FaultException($"Exception in service, try again later! {ex.Message}");
            }
            
        }
    }
}

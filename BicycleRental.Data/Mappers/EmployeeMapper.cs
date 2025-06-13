using BicycleRental.Domain.Entities;
using BicycleRental.WebAPI.Models;

namespace BicycleRental.WebAPI.Mapping;

public static class EmployeeMapper
{
    public static Employee ToDomain(this EmployeeDb db)
    {
        return new Employee
        {
            IdEmployee = db.IdEmployee,
            First_Name = db.First_Name,
            Last_Name = db.Last_Name,
            Surname = db.Surname,
            DateOfBirth = db.DateOfBirth
        };
    }

    public static EmployeeDb ToDb(this Employee employee)
    {
        return new EmployeeDb
        {
            IdEmployee = employee.IdEmployee,
            First_Name = employee.First_Name,
            Last_Name = employee.Last_Name,
            Surname = employee.Surname,
            DateOfBirth = employee.DateOfBirth
        };
    }
}
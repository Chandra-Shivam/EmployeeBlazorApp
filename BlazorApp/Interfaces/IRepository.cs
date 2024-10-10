using System;
using BlazorApp.Models;

namespace BlazorApp.Interfaces;

public interface IRepository
{
    Task<List<Employee>> FetchEmployeeList();
    Task<Employee?> EmployeeDetails(int employeeId);
    Task RemoveEmployee(int employeeId);
    Task<int> AddEmployee(Employee employee);
    Task UpdateDetails(Employee employee);
}

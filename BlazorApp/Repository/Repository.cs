using System;
using BlazorApp.Data;
using BlazorApp.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp.Models;

public class Repository : IRepository
{
    private readonly AppDbContext _context;
    public Repository(AppDbContext context)
    {
        _context = context;
    }
    public async Task<int> AddEmployee(Employee employee)
    {
        await _context.Employees.AddAsync(employee);
        return await _context.SaveChangesAsync();
    }

    public async Task<Employee?> EmployeeDetails(int employeeId)
    {
        var employeeDetails = await _context.Employees.FindAsync(employeeId);
        if (employeeDetails != null)
        {
            return employeeDetails;
        }
        else
            return null;

    }

    public async Task<List<Employee>> FetchEmployeeList()
    {
        var employeeList = await _context.Employees.ToListAsync();
        if (employeeList != null)
        {
            return employeeList;
        }
        else
        {
            return null;
        }
    }

    public async Task RemoveEmployee(int employeeId)
    {
        var employee = await _context.Employees.FindAsync(employeeId);
        if (employee != null)
        {
            _context.Employees.Remove(employee);
            await _context.SaveChangesAsync();
        }
    }
    public async Task UpdateDetails(Employee employee)
    {
        var entity = await _context.Employees.FindAsync(employee.EmployeeId);
        if (entity != null)
        {
            entity.FullName = employee.FullName;
            entity.Department = employee.Department;
            entity.EmailAddress = employee.EmailAddress;
            entity.Position = employee.Position;
            entity.DateOfJoining = employee.DateOfJoining;

            _context.Employees.Update(employee);
            await _context.SaveChangesAsync();
        }
    }

}

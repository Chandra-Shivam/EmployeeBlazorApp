using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace BlazorApp.Models;

public class Employee
{
    [Key]
    public int EmployeeId { get; set; }

    [Required(ErrorMessage = "Full Name is required.")]
    [StringLength(30, ErrorMessage = "Name cannot exceed 30 characters.")]
    public string FullName { get; set; }

    [Required(ErrorMessage = "Position is required.")]
    [StringLength(20, ErrorMessage = "Position cannot exceed 20 characters")]
    public string Position { get; set; }

    [Required(ErrorMessage = "Department is required")]
    [StringLength(20, ErrorMessage = "Position cannot exceed 20 characters")]
    public string Department { get; set; }

    [Required(ErrorMessage = "Email Address is required.")]
    // [EmailAddress(ErrorMessage = "Invalid email address.")]
    [RegularExpression(RegexPatterns.Email, ErrorMessage = "Invalid email address")]
    [StringLength(70, ErrorMessage = "Position cannot exceed 70 characters")]
    public string EmailAddress { get; set; }

    [Required(ErrorMessage = "Date is required.")]
    public DateTime DateOfJoining { get; set; } = DateTime.Now;
}

public static class RegexPatterns
{
    public const string Email = @"^[a-zA-Z0-9._\\-]+@[a-zA-Z0-9]+(([\\-]*[a-zA-Z0-9]+)*[.][a-zA-Z0-9]+)+(;[ ]*[a-zA-Z0-9._\\-]+@[a-zA-Z0-9]+(([\\-]*[a-zA-Z0-9]+)*[.][a-zA-Z0-9]+)+)*$";
}
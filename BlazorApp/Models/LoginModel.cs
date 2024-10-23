using System;

namespace BlazorApp.Models;

public class LoginModel : RegisterModel
{
    public string? ReturnUrl { get; set; }
}

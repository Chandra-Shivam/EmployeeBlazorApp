using BlazorApp.Components;
using BlazorApp.Data;
using BlazorApp.Interfaces;
using BlazorApp.Models;
using BlazorApp.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddDbContextFactory<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("SQLConnectionString")));

builder.Services.AddDbContextFactory<AccountDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("AccountConnectionString")));

builder.Services.AddServerSideBlazor()
    .AddCircuitOptions(options => { options.DetailedErrors = true; });

builder.Services.AddCascadingAuthenticationState();
builder.Services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<AccountDbContext>();

builder.Services.AddScoped<IRepository, Repository>();


builder.Services.AddSingleton<MessageService>();

builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/login";  // Ensure this is set to your desired login path
    options.AccessDeniedPath = "/access-denied";  // Optional
    options.ExpireTimeSpan = TimeSpan.FromMinutes(60);
    options.SlidingExpiration = true;
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SklepInternetowy.Data;
using SklepInternetowy.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<SklepInternetowyContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("SklepInternetowyContext") ?? throw new InvalidOperationException("Connection string 'SklepInternetowyContext' not found.")));

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    SeedData.Initialize(services);
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();

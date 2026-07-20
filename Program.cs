using Microsoft.EntityFrameworkCore;
// using Microsoft.Extensions.Options;
using ProductManagement.Data;
//
using Microsoft.AspNetCore.Authentication.Cookies;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
//SSM Server
builder.Services.AddDbContext<ProductDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("Default")) );
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.LoginPath = "/api/account/login";
        options.AccessDeniedPath = "/api/account/accessdenied";
    });

builder.Services.AddAuthorization();

var app = builder.Build();
// using (var scope = app.Services.CreateScope())
// {
//     var context = scope.ServiceProvider.GetRequiredService<ProductDbContext>();

//     if (!context.Users.Any())
//     {
//         context.Users.AddRange(
//             new ProductManagement.Models.User
//             {
//                 Username = "admin",
//                 Password = "admin123",
//                 Role = "Admin"
//             },
//             new ProductManagement.Models.User
//             {
//                 Username = "superadmin",
//                 Password = "super123",
//                 Role = "SuperAdmin"
//             });

//         context.SaveChanges();
//     }
// }

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.MapGet("/", context =>
{
    context.Response.Redirect("/Login.html");
    return Task.CompletedTask;
});

app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();





app.Run();



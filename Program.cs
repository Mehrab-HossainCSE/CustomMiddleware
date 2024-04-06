using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using MyCustomMiddleware.NewFolder;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<FirstMiddleware>();
builder.Services.AddTransient<SecondMiddleware>();
builder.Services.AddTransient<ThirdMiddleware>();
var app = builder.Build();

app.UseMiddleware<FirstMiddleware>();
app.UseMiddleware<SecondMiddleware>();
app.UseMiddleware<ThirdMiddleware>();

app.Run(async context =>
{
    await context.Response.WriteAsync("Hello from the terminal middleware.");
});
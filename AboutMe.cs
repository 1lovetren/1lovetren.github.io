using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Serve HTML file
app.UseDefaultFiles();
app.UseStaticFiles();

// API endpoint
app.MapGet("/api/about", () => new {
    name = "1lovetren :)",
    bio = "I'm a passionate front-end developer who loves creating clean, modern web experiences.",
    email = "alex@example.com"
});

app.Run();

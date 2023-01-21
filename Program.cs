var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World! Welcome! Happy Coding - Subscribe -->> https://www.youtube.com/TrickSoLogic/ ");

app.Run();

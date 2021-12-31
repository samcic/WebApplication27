var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
var app = builder.Build();

// Option 1: "Slow"
app.MapControllerRoute("default", "{controller}/{action}");

// Option 2: "Fast"
// app.MapGet("/home/content", () => "Hello World!");

app.Run();
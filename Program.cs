var builder = WebApplication.CreateBuilder(args);
// builder.WebHost.UseUrls("http://0.0.0.0:5000"); // replit
builder.WebHost.UseUrls("http://localhost:5000/"); // local host
var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

app.MapGet("/convert-miles", (double miles) =>
{
    double kilometers = miles * 1.60934;
    return Results.Ok(new { kilometers });
});

app.MapGet("/convert-fahrenheit", (double fahrenheit) =>
{
    double celsius = (fahrenheit - 32) * 5/9;
    return Results.Ok(new { celsius });
});

app.MapFallbackToFile("index.html");

app.Run();
    
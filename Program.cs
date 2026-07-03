var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

app.MapGet("/convert", (double miles) =>
{
    double kilometers = miles * 1.60934;
    return Results.Ok(new { kilometers });
});

app.MapFallbackToFile("index.html");

app.Run();

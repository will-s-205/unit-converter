var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseStaticFiles();
app.UseDefaultFiles();

app.MapGet("/convert", (double miles) =>
{
    double kilometers = miles * 1.60934;
    return Results.Ok(new { kilometers });
});

app.Run();

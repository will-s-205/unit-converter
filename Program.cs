var builder = WebApplication.CreateBuilder(args); // Create a new instance of the WebApplicationBuilder class, which is used to configure and build the web application
var app = builder.Build(); // Build the web application using the configuration specified in the builder

app.UseDefaultFiles(); // Enable serving of default files (like index.html) when a request is made to the root URL
app.UseStaticFiles(); // Enable serving of static files (like CSS, JavaScript, images) from the wwwroot folder

app.MapGet("/convert", (double miles) => // Define a GET endpoint at the path "/convert" that takes a query parameter "miles" of type double
{
    double kilometers = miles * 1.60934; // Convert miles to kilometers using the conversion factor (1 mile = 1.60934 kilometers)
    return Results.Ok(new { kilometers }); // Return an HTTP 200 OK response with a JSON object containing the calculated kilometers
});

app.MapFallbackToFile("index.html"); // Define a fallback route that serves the index.html file for any requests that do not match the defined endpoints, allowing for client-side routing in single-page applications

app.Run(); // Start the web application and begin listening for incoming HTTP requests, which in this case is "convert"

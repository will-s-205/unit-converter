var builder = WebApplication.CreateBuilder(args); // This line initializes a new instance of the WebApplicationBuilder class, which is used to configure and build the web application. It takes command-line arguments (args) as input, allowing for configuration based on those arguments. The builder object provides access to various services and settings needed to set up the application.
builder.WebHost.UseUrls("http://0.0.0.0:5000"); // replit // comment this line if want to run locally
var app = builder.Build(); // application builder is used to configure the HTTP request pipeline and define how the application will respond to incoming requests.

app.UseDefaultFiles(); // This middleware serves default files (like index.html) when a request is made to the root URL of the application. It looks for files like index.html, default.html, etc., in the wwwroot folder and serves them if found. If no default file is found, it will continue to the next middleware in the pipeline.
app.UseStaticFiles(); // This middleware serves static files (like CSS, JavaScript, images) from the wwwroot folder.

app.MapGet("/convert-miles", (double miles) => // This line defines a GET endpoint at the URL path "/convert-miles". When a GET request is made to this endpoint with a query parameter for miles, the provided lambda function will be executed.
{
    double kilometers = miles * 1.60934; // This line performs the conversion from miles to kilometers using the conversion factor (1 mile = 1.60934 kilometers).
    return Results.Ok(new { kilometers }); // This line returns an HTTP 200 OK response with a JSON object containing the converted kilometers value. The Results.Ok method is used to create the response, and the new { kilometers } syntax creates an anonymous object with a property named kilometers.
});

app.MapGet("/convert-fahrenheit", (double fahrenheit) =>
{
    double celsius = (fahrenheit - 32) * 5 / 9;
    return Results.Ok(new { celsius });
});

app.MapFallbackToFile("index.html"); // This line defines a fallback route for the application. If a request is made to a URL that doesn't match any of the defined endpoints, the application will serve the "index.html" file from the wwwroot folder. This is useful for single-page applications (SPAs) where the client-side routing is handled by JavaScript, and all unknown routes should be directed to the main HTML file.

app.Run(); // This line starts the application and begins listening for incoming HTTP requests. The app.Run() method blocks the calling thread and keeps the application running until it is stopped or terminated.
    
# Unit Converter
### Click project live below:
[![Unit Converter](https://github.com/will-s-205/will-s-205.github.io/blob/main/fcc-portfolio/img/2026-07-03%20unit%20converter%20cover.png)](https://unit-converter--rigo205.replit.app)
Unit Converter is a simple web application built with C# and Minimal API that converts miles to kilometers and Fahrenheit to Celsius. The application uses an HTML interface with JavaScript to send user input to C# API endpoints, where the calculations are performed on the server. The results are returned as JSON and displayed on the webpage. This project demonstrates the basics of creating endpoints, handling HTTP requests, and connecting a frontend with a C# backend.
## Goal
Build a simple web application that performs unit conversions by connecting an HTML frontend with a C# backend using Minimal APIs.
## Learned and practiced
* Serving static HTML and CSS files.
* Creating GET API endpoints in C#.
* Sending HTTP requests using the JavaScript fetch() API.
* Processing user input and returning JSON responses.
* Performing server-side calculations in C#.
* Displaying API results dynamically in the browser.
* Connecting a frontend interface with a backend application.

===

## How to run:
Win11
* Make sure to install dotnet8 SDK https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-8.0.422-windows-x64-installer
* open your terminal and find folder with project
* make sure to comment line of code "builder.WebHost.UseUrls("http://0.0.0.0:5000");" in Programm.cs
* run "dotnet clean; dotnet build; dotnet run;"
* run "start http://localhost:5000" or manualy copy in your browser "http://localhost:5000"

===

NOTE for Replit:
https://hamy.xyz/blog/2024-04_replit-fsharp-8

---

The replit.nix file is where we can configure which dependencies to install on the system - kinda like a package.json or .fsproj. To upgrade from F# 7 to 8 we needed to update to the dotnet 8 SDK which we did by changing pkgs.deps to pkgs.dotnet-sdk_8.

<!-- { pkgs }: {
    deps = [
        pkgs.dotnet-sdk_8
    ];
} -->

---

The .replit file configures how the instance will run - the main file, the run command, environment variables, etc. To upgrade from F# 7 to 8 we needed to update to the dotnet 8 SDK which required updating the nix.channel field to stable-23_11 because dotnet 8 wasn't available on previous versions.

<!-- run = ["dotnet", "run"]
entrypoint = "main.fs"
hidden = ["bin", "obj"]

[nix]
channel = "stable-23_11"

[env]
DOTNET_SKIP_FIRST_TIME_EXPERIENCE = "true"

[gitHubImport]
requiredFiles = [".replit", "replit.nix"] -->

===

In a C# project, a .gitattributes file is essential for maintaining consistent line endings across different operating systems and improving Git diffs for your code.Because C# developers often collaborate across Windows (which uses CRLF) and macOS or Linux (which use LF), omitting this file can cause phantom modifications in your Git history, failing builds, or formatting issues.

===

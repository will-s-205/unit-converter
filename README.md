
===

How to run:
Win11
1 Make sure to install dotnet8 SDK https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-8.0.422-windows-x64-installer
2 open your terminal and find folder with project
3 run "dotnet clean; dotnet build; dotnet run;"
4 run "start http://localhost:5000" or manualy copy in your browser "http://localhost:5000"

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

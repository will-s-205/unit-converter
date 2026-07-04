# Step 1: Use the official Microsoft .NET SDK image to build the app
FROM ://microsoft.com AS build-env
WORKDIR /app

# Copy the project files and restore dependencies
COPY *.csproj ./
RUN dotnet restore

# Copy the remaining source code and build the application
COPY . ./
RUN dotnet publish -c Release -o out

# Step 2: Use the runtime-only image to keep the final container small
FROM ://microsoft.com
WORKDIR /app
COPY --from=build-env /app/out .

# Expose the port Render uses and start the app
EXPOSE 8080
ENTRYPOINT ["dotnet", "UnitConverter.dll"]
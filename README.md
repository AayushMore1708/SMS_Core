# .NET Core Project Commands

# Watch for file changes, automatically rebuilds/restarts on changes. Suppresses warnings.
dotnet watch --property WarningLevel=0 -m

# Run the application from source, building if necessary. Suppresses warnings.
dotnet run --property WarningLevel=0

# Build the project into binaries without running it. Suppresses warnings.
dotnet build --property WarningLevel=0

# Auto-generate a controller:
# - Creates 'MainController' based on the 'AspNetUser' model.
# - Uses 'SMSDbContext' as database context, places in 'Controllers' folder.
# - Includes default layout and script libraries.
dotnet aspnet-codegenerator controller -name MainController -m AspNetUser -dc SMSDbContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries

# Publish a self-contained deployment for Windows 64-bit systems:
# - Includes .NET runtime, ideal for environments without .NET pre-installed.
dotnet publish -c Release -r win-x64 --self-contained

# Publish a framework-dependent deployment, relying on .NET being pre-installed on the target system:
# - Smaller deployment package, suitable for environments with compatible .NET runtime.
dotnet publish -c Release

# Run the application in the "Production" environment, loading production-specific configurations.
dotnet run --environment "Production"

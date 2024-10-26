dotnet watch --property WarningLevel=0

dotnet run --property WarningLevel=0

To auto generate contoller
dotnet aspnet-codegenerator controller -name MainController -m AspNetUser  -dc SMSDbContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries
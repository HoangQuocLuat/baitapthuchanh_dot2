dotnet ef migrations add Create_table_Person
dotnet ef database update

code tu dong
dotnet aspnet-codegenerator controller -name YourController -m YourModel -dc YourNamespce.ApplicationDbContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries --databaseProvider sqlite

dotnet aspnet-codegenerator controller -name HeThongPPController -m HeThongPP -dc MvcProject.Data.ApplicationDbContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries --databaseProvider sqlite

dotnet aspnet-codegenerator controller -name HeThongPPController -m HeThongPP -dc MvcProject.Data.ApplicationDbContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries --useSqlite




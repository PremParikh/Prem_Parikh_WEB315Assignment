# Prem_Parikh_WEB315Assignment

dotnet new webapp -o RazorPagesbook
 
 code -r RazorPagesbook

dotnet dev-certs https --trust

dotnet tool uninstall --global dotnet-aspnet-codegenerator

dotnet tool install --global dotnet-aspnet-codegenerator

dotnet tool uninstall --global dotnet-ef

dotnet tool install --global dotnet-ef

dotnet add package Microsoft.EntityFrameworkCore.Design

dotnet add package Microsoft.EntityFrameworkCore.SQLite

dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design

dotnet add package Microsoft.EntityFrameworkCore.SqlServer

dotnet tool install --global dotnet-ef

dotnet ef migrations add InitialCreate

dotnet ef database update

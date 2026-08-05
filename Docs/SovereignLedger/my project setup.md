to get Ef core set up for a project from the template, im going to use this batch of commands
reminder that i am using .Net 8 so i need to adjust versions

dotnet add package Microsoft.EntityFrameworkCore.Sqlite -v 8.0.12
dotnet add package Microsoft.EntityFrameworkCore.Design -v 8.0.12
dotnet add package Microsoft.EntityFrameworkCore.Tools -v 8.0.12

then run this to install ef core
`dotnet tool install --global dotnet-ef`

Create an initial database migration based on your C# models 
`dotnet ef migrations add InitialCreate`

Create/update the local SQLite database file on disk 
`dotnet ef database update`
# NETConfWebAPI
```shell
dotnet new webapi -o NETConfWebAPI
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
dotnet retore

dotnet ef migrations add InitialCreate
dotnet ef database update
```
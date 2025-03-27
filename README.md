dotnet ef migrations remove --context AppDbContext
dotnet ef migrations add Resources --context AppDbContext
dotnet ef database update --context AppDbContext


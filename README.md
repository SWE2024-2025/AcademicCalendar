dotnet ef migrations remove --context AppDbContext
dotnet ef migrations add up1 --context AppDbContext
dotnet ef database update --context AppDbContext


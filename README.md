dotnet ef migrations remove --context AppDbContext
dotnet ef migrations add Resources --context AppDbContext
dotnet ef database update --context AppDbContext

dotnet ef migrations add add-user-fullname2 --context AppIdentityDbContext
dotnet ef database update --context AppIdentityDbContext
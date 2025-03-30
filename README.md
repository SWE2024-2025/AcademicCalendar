dotnet ef migrations remove --context AppDbContext
dotnet ef migrations add Resources --context AppDbContext
dotnet ef database update --context AppDbContext

dotnet ef migrations add add-user-fullname2 --context AppIdentityDbContext
dotnet ef database update --context AppIdentityDbContext




docker build -t academic-year-calendar:v1 .
docker run -p 7000:8000 academic-year-calendar:v1
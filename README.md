dotnet ef migrations remove --context AppDbContext
dotnet ef migrations add Resources --context AppDbContext
dotnet ef database update --context AppDbContext

dotnet ef migrations add add-user-fullname2 --context AppIdentityDbContext
dotnet ef database update --context AppIdentityDbContext




docker build -t academic-year-calendar:v1 .
docker run -d -p 7000:8080 academic-year-calendar:v1


SQL Server (192.168.100.40) (SWE2025\\SQLEXPRESS)
user : sa
pass : P@ssw0rd
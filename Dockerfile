# Base runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

# Copy published output from host into image
COPY bin/Release/net8.0/publish/ .

ENTRYPOINT ["dotnet", "AcademicYearCalendar.dll"]

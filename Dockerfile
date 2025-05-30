# Base runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
EXPOSE 8080
EXPOSE 8081

# Set working directory in container
WORKDIR /app

# Copy published output from local folder into image
COPY / .

# Expose port (optional: match what your app uses)
EXPOSE 8080

# Run the app
ENTRYPOINT ["dotnet", "AcademicYearCalendar.dll"]

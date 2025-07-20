# Stage 1: Build the app
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy everything
COPY . .  

# Restore dependencies and publish
RUN dotnet restore ./AI4ALL.csproj
RUN dotnet publish ./AI4ALL.csproj -c Release -o /app/publish

# Stage 2: Run the app
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/publish .

# Expose HTTP port
EXPOSE 80

# Start the app
ENTRYPOINT ["dotnet", "AI4ALL.dll"]

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build-env
WORKDIR /app

# Copy csproj and restore as distinct layers

# Copy everything else and build
COPY . .
RUN dotnet publish -c Release -o out Destinity/Destinity.Api/Destinity.Api.csproj

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /app
COPY --from=build-env /app/out .

# Run the app on container startup
# Use your project name for the second parameter
# e.g. MyProject.dll
# ENTRYPOINT [ "dotnet", "Destinity.Api.dll" ]
CMD ASPNETCORE_URLS="http://*:$PORT" dotnet Destinity.Api.dll

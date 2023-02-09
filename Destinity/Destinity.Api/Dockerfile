FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Destinity.Api/Destinity.Api.csproj", "Destinity.Api/"]
RUN dotnet restore "Destinity.Api/Destinity.Api.csproj"
COPY . .
WORKDIR "/src/Destinity.Api"
RUN dotnet build "Destinity.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Destinity.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Destinity.Api.dll"]

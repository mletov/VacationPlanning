#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/ApplicationTier/ApplicationTier.API.Staffing/ApplicationTier.API.Staffing.csproj", "src/ApplicationTier/ApplicationTier.API.Staffing/"]
RUN dotnet restore "src/ApplicationTier/ApplicationTier.API.Staffing/ApplicationTier.API.Staffing.csproj"
COPY . .
WORKDIR "/src/src/ApplicationTier/ApplicationTier.API.Staffing"
RUN dotnet build "ApplicationTier.API.Staffing.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ApplicationTier.API.Staffing.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ApplicationTier.API.Staffing.dll"]
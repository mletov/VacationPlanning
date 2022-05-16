#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/PresentationTier/PresentationTier.BlazorUI/Server/PresentationTier.BlazorUI.Server.csproj", "src/PresentationTier/PresentationTier.BlazorUI/Server/"]
COPY ["src/PresentationTier/PresentationTier.BlazorUI/Client/PresentationTier.BlazorUI.Client.csproj", "src/PresentationTier/PresentationTier.BlazorUI/Client/"]
COPY ["src/PresentationTier/PresentationTier.BlazorUI/Shared/PresentationTier.BlazorUI.Shared.csproj", "src/PresentationTier/PresentationTier.BlazorUI/Shared/"]
RUN dotnet restore "src/PresentationTier/PresentationTier.BlazorUI/Server/PresentationTier.BlazorUI.Server.csproj"
COPY . .
WORKDIR "/src/src/PresentationTier/PresentationTier.BlazorUI/Server"
RUN dotnet build "PresentationTier.BlazorUI.Server.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PresentationTier.BlazorUI.Server.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PresentationTier.BlazorUI.Server.dll"]
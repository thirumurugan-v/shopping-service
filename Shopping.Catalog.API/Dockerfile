#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Shopping.Catalogue.API/Shopping.Catalogue.API.csproj", "Shopping.Catalogue.API/"]
RUN dotnet restore "Shopping.Catalogue.API/Shopping.Catalogue.API.csproj"
COPY . .
WORKDIR "/src/Shopping.Catalogue.API"
RUN dotnet build "Shopping.Catalogue.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Shopping.Catalogue.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Shopping.Catalogue.API.dll"]
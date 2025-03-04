# Base image olarak resmi .NET SDK kullan
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80

# Build aşaması
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Proje dosyalarını kopyala ve derle
COPY ["Update.Mapper.csproj", "./"]
RUN dotnet restore "./Update.Mapper.csproj"

COPY . .
RUN dotnet publish "./Update.Mapper.csproj" -c Release -o /app/publish

# Runtime image
FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "Update.Mapper.dll"]

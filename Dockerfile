# Base image olarak resmi .NET SDK kullan
# .NET 7.0 SDK ile Build Aşaması
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /app
COPY . .
RUN dotnet publish -c Release -o out

# .NET 7.0 Runtime ile Çalıştırma Aşaması
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS runtime
WORKDIR /app
COPY --from=build /app/out ./
ENTRYPOINT ["dotnet", "Update.Mapper.dll"]

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

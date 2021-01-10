FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
COPY *.sln .
COPY . .
RUN dotnet restore
RUN dotnet publish -c release  -o /app  src/WeatherBot.Api/WeatherBot.Api.csproj

# final stage/image
#FROM mcr.microsoft.com/dotnet/aspnet:5.0
#WORKDIR /app
#COPY --from=build /app ./
#ENTRYPOINT ["dotnet", "WeatherBot.Api.dll"]
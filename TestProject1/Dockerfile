FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["TestProject1/TestProject1.csproj", "TestProject1/"]
COPY ["ConsoleApp1/ConsoleApp1.csproj", "ConsoleApp1/"]
RUN dotnet restore "TestProject1/TestProject1.csproj"
COPY . .
WORKDIR "/src/TestProject1"
RUN dotnet build "TestProject1.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TestProject1.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TestProject1.dll"]

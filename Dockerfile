FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["src/WordleSolver.Api/WordleSolver.Api.csproj", "WordleSolver.Api/"]
RUN dotnet restore "WordleSolver/WordleSolver.csproj"
COPY . .
WORKDIR "/src"
RUN dotnet build "WordleSolver.Api/WordleSolver.Api.csproj" -c Release -o /app/build
RUN dotnet build "WordleSolver.Application/WorldSolver.Application.csproj" -c Release -o /app/build
RUN dotnet build "WordleSolver.Domain/WordleSolver.Domain.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WordleSolver.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false
# UserAppHost=false is to make MSBuild generates a DLL instead of an executable

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WordleSolver.dll"]

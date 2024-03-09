FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 5000

ENV ASPNETCORE_URLS=http://*:5000
# ENV ASPNETCORE_URLS=""

USER app
FROM --platform=$BUILDPLATFORM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG configuration=Release
WORKDIR /src
COPY ["Server ASP NET Core.csproj", "./"]
RUN dotnet restore "Server ASP NET Core.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "Server ASP NET Core.csproj" -c $configuration -o /app/build

FROM build AS publish
ARG configuration=Release
RUN dotnet publish "Server ASP NET Core.csproj" -c $configuration -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Server ASP NET Core.dll"]

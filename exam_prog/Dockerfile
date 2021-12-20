# First stage
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app

# Copy csproj and restore as distinct layers
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY . .
RUN dotnet restore "./exam_prog.csproj"
RUN dotnet build "exam_prog.csproj" -c Release -o /app/build

# Copy everything else and build website
FROM build AS publish
RUN dotnet publish "exam_prog.csproj" -c Release -o /app/publish

# Final stage
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "exam_prog.dll"]
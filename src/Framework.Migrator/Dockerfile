﻿#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["src/Framework.Migrator/Framework.Migrator.csproj", "src/Framework.Migrator/"]
COPY ["src/Framework.EntityFrameworkCore/Framework.EntityFrameworkCore.csproj", "src/Framework.EntityFrameworkCore/"]
COPY ["src/Framework.Core/Framework.Core.csproj", "src/Framework.Core/"]
COPY ["src/Framework.Core.Shared/Framework.Core.Shared.csproj", "src/Framework.Core.Shared/"]
RUN dotnet restore "src/Framework.Migrator/Framework.Migrator.csproj"
COPY . .
WORKDIR "/src/src/Framework.Migrator"
RUN dotnet build "Framework.Migrator.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Framework.Migrator.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Framework.Migrator.dll"]

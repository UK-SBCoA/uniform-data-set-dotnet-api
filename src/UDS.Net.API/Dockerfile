#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["UDS.Net.API/UDS.Net.API.csproj", "UDS.Net.API/"]
COPY ["UDS.Net.Dto/UDS.Net.Dto.csproj", "UDS.Net.Dto/"]
COPY ["UDS.Net.API.Client/UDS.Net.API.Client.csproj", "UDS.Net.API.Client/"]
RUN dotnet restore "UDS.Net.API/UDS.Net.API.csproj"
COPY . .
WORKDIR "/src/UDS.Net.API"
RUN dotnet build "UDS.Net.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "UDS.Net.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "UDS.Net.API.dll"]

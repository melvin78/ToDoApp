FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY "ToDoApp.sln" "ToDoApp.sln"

COPY ["ToDoApp/ToDoApp.csproj", "ToDoApp/"]

RUN dotnet restore "ToDoApp/ToDoApp.csproj"
COPY . .
RUN dotnet build "ToDoApp/ToDoApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ToDoApp/ToDoApp.csproj" -c Release -o /app/publish

FROM nginx:alpine AS final
WORKDIR /usr/share/nginx/html
COPY --from=publish /app/publish/wwwroot .
COPY ["ToDoApp/nginx.conf","/etc/nginx/nginx.conf"]
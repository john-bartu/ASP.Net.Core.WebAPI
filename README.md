## Migrtations

### New Migration
```
    dotnet ef migrations add NAME --project Libraries/Data/Data.csproj --context Data.Contexts.ApplicationDbContext -v -s .\WebApi\WebApi.csproj
```

### Update Database
```
    dotnet ef database update --project Libraries/Data/Data.csproj --context Data.Contexts.ApplicationDbContext -v -s .\WebApi\WebApi.csproj
```
# photo-core

## Add Database Migration

Add Migration: 
--------------------------------------------------------
dotnet ef migrations add <NameOfYourMigration> --project "PhotoCore.DataAccess" --startup-project "PhotoCore.Mvc"



Remove Most Recent Migration (i.e. "oops"):
-------------------------------------------------------
dotnet ef migrations remove --project "PhotoCore.DataAccess" --startup-project "PhotoCore.Mvc"



Update Database with Latest Migrations:
-------------------------------------------------------
dotnet ef database update --project "PhotoCore.DataAccess" --startup-project "PhotoCore.Mvc"


Revert to a previous migration:
-------------------------------------------------------
dotnet ef database update <previous-migration-name> --project "PhotoCore.DataAccess" --startup-project "PhotoCore.Mvc"


Create a SQL Migration Script:
-------------------------------------------------------
Log into target database and find what latest migration applied is (__EFMigrationsHistory table)
Use that as the "FROM"

dotnet ef migrations script <FromMigration> -o "update.sql" --project "PhotoCore.DataAccess" --startup-project "PhotoCore.Mvc"
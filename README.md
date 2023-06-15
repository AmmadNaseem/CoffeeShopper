# CoffeeShopper

1. identityserver4
2. identityserver4.EntityFramework
3.entityframework.tool
4.entityframework.sql server
5.entityframework.design
6.IdentityServer4.AspNetIdentity
7.Microsoft.AspNetCore.Identity.EntityFrame


add-migration InitialIdentityServerMigration -c PersistedGrantDbContext
add-migration InitialIdentityServerMigration -c ConfigurationDbContext
Remove-Migration -c ConfigurationDbContext

 update-database -Context PersistedGrantDbContext
 update-database -Context ConfigurationDbContext


-> add asp.net identity to the server project

-> add asp.net identity migrations
add-migration InitialAspNetIdentityMigration -Context AspNetIdentityDbContext
update-database -Context AspNetIdentityDbContext


-> ADD IDENTITYSERVER4 CONFIGURATION AND SEETDATA:
1. WE CREATE COUPLE OF CLASSES IN SERVER SOLUTION FOLDER
 a.Config.cs and SeedData.cs

2. Setup the identityServer Seeeding Process: 
 a. add in progra,.cs file:var seed = args.Contains("/seed");
 b. dotnet run Server/bin/Debug/net6.0/Server /seed --project Server
 c.https://localhost:5443/.well-known/openid-configuration

2. Setup the IdentityServer authentication flow
	a.https://github.com/IdentityServer/IdentityServer4.Quickstart.UI

3. Setup Program.cs for integration with the QuickStart Code.

4. Setting up the Blazor Server Project(called client).

5. Secure the Client app with IdentityServer4.

3.

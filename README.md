# .netCore-Clean-Architecture
.net Core project with clean architecture which will be used as an example in future projects

In onion clean arhitecture, target is to accomplish that outer layers depend on inner, not vice versa.
There are four layers, so four folders in solution:
1. Application
2. Domain
3. Data
4. IoC
5. Some kind of User Interface
Folders are not necessary, and there could be only projects.

Steps to create API with this architecture are:
1. Create API poject, and add database default connection to appsettings.json ConnectionStrings segment.

2. Update the database with Identitty model classes using a migration. Open Package manager console and type:
add-migration "InitialMigration" -Context ApplicationDbContext
  - There is DbContext class here, beacuse there will be another DbContext in the future for other entitites.

3. Update the database after creating the migration using command:
update-database

Domain

1. Add class library to domain layer which will hold the core entities.
2. Add models(entities) inside newly created Models/Entities folder.
3. Add properties which are needed for entitites.

Infrastructure
1. Add class library to Infrastructure layer inside Data/Context folder.
2. Install next packages for project:
- Microsoft.EntityFrameworkCore
- Microsoft.EntityFrameworkCore.Design
- Microsoft.EntityFrameworkCore.SqlServer
- Microsoft.EntityFrameworkCore.Tools
3. Add context class for entity which will extend DbContext and will have constructor with DbContextOptions argument.
4. Add DbContext in Startup.cs of main application project. This needs to be added to ConfigureServices method like services.AddDbContext.
5. If domain entities need to be in diferent db, then add another connection to appsettings.json and use options  when adding context.
6. Add new migration with add-migration "InitialMigration" -Context NewContextClass. This will create migration under infrastructure.
7. Update database using: update-database -Context LibraryDbContext

Application Core
1. All Interfaces, Services and ViewModels go here, so create new class library.
2. Add folders for segments above.
3. Create Model that will know about domain models so the services don't need to know about them.
4. Create Service interface with needed method that will return this model.

Domain(Again)
1. Under Domain add new folder IRepositories or Interfaces, and add Repository interface that will know about domain model
2. BookService uses injected BookRepository which uses injected context

- Under infrastructure data implement Repository interface

IoC - Inversion of Control
1. This part is for dependency injection, so Microsoft.Extensions.DependencyInjection needs to be installed to this project.
2. Add class DependencyContainer
3. Add static method RegisterServices where dependencies for each project will be added (using IServiceCollection.AddScoped<Interface, Implementation>())
4. In startup of main project, after Configure method, add RegisterServices method, which will call DependencyContainer.RegisterServices.
5. Call this method inside ConfigureServices

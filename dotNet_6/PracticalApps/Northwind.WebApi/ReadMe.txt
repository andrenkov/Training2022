In new project properties, set "launchBrowser": false, //was true

1. Add reference to Northwind.Common.DataContext.Sqlite
2. Add proper Using into the Program.cs
3. Add builder.Services.AddNorthwindContext() before builder.Services.AddControllers(). Add connections into the applacation.json and 
   change the builder.Services.AddDbContext() fo rMsSql or Sqlite accordingly.
4. Modify default AddControllers() adding lanbda for supporting media types.
5. Create data repositories for CRUD (Create-Read-Update-Delete).
This will copy the entire table into memory. In real life, you should use the distrubuted cache lie Redis
 5.1 Create foder Repoesitories
 5.2 Add new classes ICustomerRepository and CustomerRepository
 5.3 ICustomerRepository defines 5 methods where CustomerRepository implements these 5 methods
6. Add builder.Services.AddScoped(ICustomerRepository, CustomerRepository) for the DI injection. Because the Repository uses DbContect registered as Scoped dependency, 
   we can only use scoped dependency inside another scoped dependency.
7. Add new CustomersController
8. For logs, add or modify builder.Services.AddHttpLogging() and add Options (not working as expected???).
9. Configure swagger in program.cs

#################################
Add HttpClient

See Northwind.Mvc.Sqlite project


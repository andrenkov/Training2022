Prerequiresite:
- install dotnet-sdk-2.2.207-win-x64 for reverse engineering to work to generate DBContext from existing database (sqlite?)

Init database (sqlite):
1. Copy Northwind4SQLite.sql into the project folder.
2. Run cmd: c:\sqlite\sqlite3 northwind.db -init data/Northwind4SQLite.sql to create tables

#####################################################################
Step 1 : Generate Db context
#####################################################################
1. Add new type lib project for Models only (Northwind.Common.EntityModels.Sqlite) 
2. Install NuGet Microsoft.EntityFrameworkCore.Sqlite
3. Install NuGet Microsoft.EntityFrameworkCore.Design
4. Generate DbContext from the Sqlite database file:
	dotnet ef dbcontext scaffold "Filename=northwind.db" Microsoft.EntityFrameworkCore.Sqlite --namespace Packt.Shared --data-annotations -o Models --schema --context-dir Data
	dotnet ef dbcontext scaffold "Filename=data/northwind.db" Microsoft.EntityFrameworkCore.Sqlite --namespace Packt.Shared --data-annotations -o Models --context-dir DbSchema
working!!!:
	dotnet ef dbcontext scaffold "Filename=data/northwind.db" Microsoft.EntityFrameworkCore.Sqlite --namespace Packt.Shared --data-annotations -o Models --context-dir DataContext

Not workig for Sqlite:
		"--schema" for all tables

#####################################################################
Step 2 : modify auto generated files for sqlite and some for mssql
#####################################################################
1. Open Models files 
2. Add [Key] attribute manually if not present in a models, but is present in teh Db table
3. Add [Required] for Models where needed. 
4. Add validation if needed like [RegularExpression("[A-Z]{5}")]. For example, upper case chars only.
5. Use VS replace All for Sqlite:

\[Column\(TypeName = "(nchar|nvarchar) \((.*)\)"\)\]
to 
$&\n    [StringLength($2)]

DteTime as byte[] --> DateTime?

money as byte[] --> decimal?
"bit" as byte[] --> bool

see p558 for more manual data types fixes (long --> int etc.)

#####################################################################
Step 3 : Create DbContext project
#####################################################################
1. Add/Create new type lib project Northwind.Common.DataContext.Sqlite and move northwindContext from Models project this new one.
2. Remove all entity.Property(e => e.SupplierId).ValueGeneratedNever(); Otherwise, the Inserts will be returning 0 as Auto Incremental Ids.
3. Add      modelBuilder.Entity<Product>(entity =>
			{
				entity.Property(e => e.UnitPrice)
				.HasConversion<double>();
			});
4. Add class NorthwindContextExtensions.cs for DI using IServiceCollection. See MsSql specifics on p.562

#####################################################################
Step 4 : Create Asp.Net Core project
#####################################################################
1. Create new project of type Asp.net Core Empty. The project shows the list of Supplies from the database.
2. Add the following into the Program.cs file for ssl support:
	if (!app.Environment.IsDevelopment())
	{
		app.UseHsts();
	}
	app.UseHttpsRedirection();

3. For more complex projects, add startup.cs manually for configuring the DI conteiner and HTTP pipeline.
	- ConfigureServices() - add DI into services container
	- Configure() - Http requests pipeline
	3.1. Add using Northwind.Web to the Program //startup
	3.2. Add Host.CreateDefaultBuilder(args) into the Program
	3.3 Add app.UseDefaultFiles(); for links to index, default.html etc.
4. Add wwwroot folder for web files (index.html, ccs etc.). (see https://getbootstrap.com/docs/5.0/getting-started/introduction/#starfter-template)
5. Add new index.html with the samle context.
6. For Razor Pages, add /Pages folder and copy index.html into it and rename it to cshtml
	6.1 Add services.AddRazorPages() into ConfigureServices().
	6.2.Change app.UseEndpoints() in the Configure() and add endpoints.MapRazorPages() into it.
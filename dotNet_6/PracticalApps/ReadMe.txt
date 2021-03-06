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
	6.3 Add code to Razor page (add @page, @functions{} to index.cshtml etc.).
	6.4 For a multi page site, add the _Layout.cshtml and _ViewStart.cshtml
	6.5 Add JavaScript and context into _Layout.cshtml.
	6.6 Remove html code from index.cshtml that is duplicating the  one added into _Layout.cshtml.
	6.7 Add new Razor page Suppliers.cshtml and code the OnGet() method. Ad table into Suppliers.cshtml to show the list.
7. Add EF as a service
	7.1 Add refference to Northwind.Common.DataContext. Add "using Packt.Shared" into Startup.cs.
	7.2 Add services.AddNorthwindContext(); into ConfigureServices(). 
	7.3 Modify the Suppliers.cshtml.cs and add the constructor. Change OnGet() to read from DbContext instead of hardcoded IENum
	7.4 Add @using Packt.Shared; into the Suppliers.cshtml. And extent columns in the table
	7.5 Make sure that the Db file is in the proper lacation where  ""public static IServiceCollection AddNorthwindContex()" loads it from". Forexample, in Northwind.Web project in the Data folder.
		Check if the services.AddNorthwindContext("data") has the right param passing to the constructor.
	7.6 Add OnPost() code and new block of HTML for the Insert to work.
		7.6.1. Add @addTagHelper *, Microsoft.AspNetCore.Mvc.TagHelpers
		7.6.1 Add simple row for data entry with the Form and Submit.
	7.7 You can use direct inject into the page without the code. see the Orders page as an example.
8. Razor class libraries. This is to re-use it in multiple projects.
	8.1. Add new project of the type Razor Class Library. Check "Support pages views".
	8.2. Add Razor pages using patrialview. For example, _Employee.cshtml.
	8.3. Add reference to this lib into the Northwind.Web project.
	8.4. Add button onto the Index page with ref href="packtfeatures/employee". 
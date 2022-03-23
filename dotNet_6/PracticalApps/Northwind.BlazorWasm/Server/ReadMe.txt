1. Create new project Blazor WebAssembly App
2. Check Use HTTPS, ASP.NET Hosted and Prograssive Web App
3. It will create three projects: Client, Server and Shared (lib with models etc.) 
4. Run the Server project to test.

Get the Northwind.db data:

1. In the prevoiusly created Nothwind.BlazorServer (not the BlazorWasm one), add new page Customers.razor into the Pages  (New --> Razor Component)
2. Add new [Paremeter] Country into the @code section and update the Header just for testing to show the Country
3. In the Pages Index.razor add use of the new Customers component such as:	
	<Customers Country="Germany"></Customers>
4. To make this component routable to the service, in Customers.razor add: @page "/customer/{country}"
5. In the NavMenu.razor, add two list ietm elements to shwi customer in Germany and Worldwide:
 <NavLink class="nav-link" href="customers" Match="NavLinkMatch.All....
 <NavLink class="nav-link" href="customers/Germany">....

 Adding Entities to read from Db:

 1. Add ref to Northwind.Common.DataContext.Sqlite
 2. Add using Packt.Shared; into Program.cs
 3. Add builder.Services.AddNorthwindContext();
 4. Open _Imports.razor and add @using Packt.Shared
 5. Customer.razor : add using EntityFramework, inject NorthwindContext, Hrml elements and @code  (see samplel project) p.740
 6. Make Db connection
   6.1 Copy Northwind.db into root of the project
   6.2 In program file, add Db connection and sql conn string into appsettings.json

Abstructing Service (use interface instead of the direct service call):

1. Add new "public interface INorthwindService" class into teh Data
2. Add new class implementing the interface: NorthwindService.cs
3. In the Program.cs, add builder.Services.AddTransient<INorthwindService, NorthwindService>();
3. Add @inject INorthwindService service into the Customers.

Building Web Component ()

Northwind.BlazorWasm.Server:
	1. Add ref to Northwind.Mvc.Sqlite
	2. Program.cs 
		- Add using Packt.Shared;
		- Add builder.Services.AddNorthwindContext(relativePath : Path.Combine("..", "..")); (one level up)
	3. Add CustomerController

Northwind.BlazorWasm.Client:
	1. Add ref to Models in Northwind.Common.EntityModels.Sqlite
	2. Add ref to Packt.Shared in _Imports.razor
	3. Add Nav menu to Customer in NavMenu.razor
	4. Copy CustomerDetails.razor from Northwind.BlazorServer to Client Shared folder 
	5. Copy razor Customerxxx components from Northwind.BlazorServer to Client.Pages folder.
	6. Create Data folder and copy INorthwindService.cs. 
	   Create new class NorthwindService in it, but context of the class to implement interface using HttpClient.
	7. Add to Program.cs builder.Services.AddTransient<INorthwindService, NorthwindService>();


Improving Blazor

1. install tool : >dotnet workload install wasm-tools
2. Enable AOT in the Project file: <RunAOTCompilation>true</RunAOTCompilation>
3. Publish Northwind.BlazorWasm.Client project cmd: dotnet publish -c Release
4. This will encrease the "publish" folder size 10x times.

Progressive Web App support

The apps can be installed into teh startup menu (any OS) and run offline. 
It automatically updates.
For such apps, the Install icon appears in the address bar of the Browser.
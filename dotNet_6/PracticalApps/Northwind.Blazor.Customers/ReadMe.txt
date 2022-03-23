Sharing Blazor Components in a Class Library

1. Create new project Razor Class Library with MVC enabled
2. Add ref to Northwind.Common.EntityModels.Sqlite project.
3. Add <SupportedPlatform Include="browser" /> into the Project.
4. In the Northwind.BlazorServer projects add reference to this Northwind.Blazor.Customers project.
5. in Northwind.Blazor.Customers delete Areas folder.
6. Copy _Imports.razor from Northwind.BlazorServer project to the root of Northwind.Blazor.Customers project.
7. Delete Northwind intries from the _Imports. Add @using Northwind.Blazor.Customers.Shared.
8. Add Data, Pages and Shared folders. 
9. Move INorthwindService.cs from the Server to Customers project.
10. Move all components from Server Shared to Customers Shared.
11. Move all Customers razor pages from Server to Customers.
12. From Server _Imports.razor remove @using Northwind.BlazorServer.Shared and add 
	@using Northwind.Blazor.Customers.Shared
	@using Northwind.Customers.Pages
13. In Server app.razor add the route for the class library as below:
	 AdditionalAssemblies="new[] { typeof(Customers).Assembly }"
14. Run Server and it supposed to work as before.

You cannot reuse components in Balzor Web Assemply project because of the dependency on the full Asp.Net Core workload.

Inerop with Js

To get access to browser capatibilities like local storage etc, use JavaScripts:

1. Add new wwwroot Scripts folder to the BlazorServer project
2. Add file Interop.js with some functions in it.
3. In the _Layout.cshtml, add a script element: <script src="scripts/interop.js"></script>
4. Modify Index.razor to add some codes to Set and Read data from teh Local Storage. See code for the example.
	sample : await JSRuntime.InvokeVoidAsync("setColorInStorage");

General Design guidelines see at https://docs.microsoft.com/en-us/dotnet/standard/design-guidelines/
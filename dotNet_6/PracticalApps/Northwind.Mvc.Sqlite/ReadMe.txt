Mvc app

For Sqlite run 
dotnet new mvc -n "Northwind.Mvc.Sqlite" -au individual -f net6.0

1. Create Asp.Net Core Web App (Model-View-Controller)
2. Check "Auth Type : Individual Accounts
3. Init auth database (local Db):\
	3.1  Use the Package Manager Console to apply pending migrations to the database:
	PM> Update-Database
	3.2 Apply pending migrations from a command prompt at your project directory: 
	cmd> dotnet ef database update
	Default Db connection is set to the foloowing file created in:
	C:\Users\Vladimir\aspnet-Northwind.Mvc-63676AFA-9698-4FF9-9AA6-5A45ED2069AD.mdf
	This Db is for both Auth and Data. Could be separated into two.
	You can use sqlite instead, but the project should be created via the console as:
	cmd> dotnet new mvc -au -uid -rrc -f
	-ua or --auth - use to set the auth type as: 
		-Individual (Individual auth storing usersa nd passwords in database (sqlite by default))
		-IndividualB2C (Azure Ad) or 
		-SingleOrg (organization auth for a single tenant)
		-Windows (Windows Auth)
	see p.617 for all options including sqlite
4. You can change ports in Properties --> launchSettings.json
5. Register user. I use andrenkov@gmail.com/Pa$$w0rd

//A base class for an MVC controller without view support (APIs?).
public abstract class ControllerBase
//A base class for an MVC controller with view support.
public abstract class Controller

6. Add reference to Northwind.Common.DataContext project for access to Models.
7. Add sql string and builder.Services.AddNorthwindContext(sqlSErverConnection) into the Program.cs
8. Add new Model referencing Packt.Shared which returns a "record" (not a class).
9. Add DbContext readonly to the HomeController and into its constructor
10. Change the Index endpoint to to create an instance of teh View model simulating the VisitorsCount and getting the lists of categories and products.
11. To generate a View, Mvc looks for the subfolder in the Views with the same name as the Controller. Then it looks for the cshtml file with 
name as the current Action. It also seachs the Shared folder for Razor pages. 
12. View _ViewStart.cshtml is used for defaults for all Views.
13. Add reference to into _Layout.cshtml


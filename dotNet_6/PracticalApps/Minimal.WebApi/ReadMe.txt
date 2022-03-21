Minimal Api

Api for simple services without a controller where all is one Program.cs file

Create new lib:
1. Add new Class Library project Northwind.Common.
2. Class name is Weatherforecast.cs and desinged for Weather Deatails.

Create new Srv:
1. Add new project Asp.Net.Core Empty "Minimal.WebApi"
2. Add builder.WebHost.UseUrls("https://localhost:5003/") etc.
3. Update launchSettings to specify: "applicationUrl": "https://localhost:5003//"https://localhost:5003/api/weather" not working

Client:
1. Add reference to Northwind.Common into the Northwind.Mvc.Sqlite project
2. Add into the Northwind.Mvc.Sqlite.Program the statement to call teh service on port 5003
	builder.Services.AddHttpClient( name : "Minimal.Api",.....
3. In HomeController, add code to call the weather service into the Index();
3. Modify Index.cshtml to show teh forecast

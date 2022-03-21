Mvc app

Use HttpClientfactory which is the effecient way of working with underlying sockets.

#region Added for HttpClientFactory
#endregion

1. Add builder.WebHost.UseUrls("https://localhost:5002/") into the API project.
1.1 Update applicationUrl for Api to leastern the desired port (5002 only???)
2. Add "using System.Net.Http.Headers;" into the Mvc project
	2.1 Add builder.Services.AddHttpClient(...);into the Mvc project
3. Add IHttpClientFactory clientFactory into the HomeController
4. Add new endpoint into the HomeController
	public async Task<IActionResult> Customers(string country)
5. Add new View Customers.cshtml
6. Enable the CORS (Cross-Origin Resource Sharing). Host website is on port 5000, but the web service is on port 5002.
	- Add into the Api project's Program.cs
		builder.Services.AddCors()
		app.UseCors( options ...);
7. Change Solution run options to run Multiple Project. Api Run first and then the Mvc app.

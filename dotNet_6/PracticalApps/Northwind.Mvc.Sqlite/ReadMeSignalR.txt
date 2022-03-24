Mvc app

ASP.NET Core SignalR is an open source library that simplifies adding real-time web
functionality to apps by being an abstraction over multiple underlying communication
technologies, which allows you to add real-time communication capabilities using C# code.

1. Northwind.Common project, add a class file named RegisterModel.cs and MessageModel.cs
2. Northwind.Mvc project, add a reference to the Northwind.Common (if not yet added)
3. Northwind.Mvc project, add a Hubs folder with ChatHub.cs
4. Program.cs, import using Northwind.Mvc.Hubs; // ChatHub
5. Add builder.Services.AddSignalR();
6. Add app.MapHub<ChatHub>("/chat") to map the relative URL path /chat to your SignalR hub
7. Add the SignalR client-side JavaScript library:
	cmd> dotnet tool install -g Microsoft.Web.LibraryManager.Cli
8. Add the signalr.js and signalr.min.js libraries
	cmd> libman install @microsoft/signalr@latest -p unpkg -d wwwroot/js/signalr --files dist/browser/signalr.js --files dist/browser/signalr.min.js
9. Add public IActionResult Chat(){}  into the HomeController
10. Views/Shared, in _Layout.cshtml, add a new nav item after the Services nav item that goes to a chat page:
	<li class="nav-item">
		<a class="nav-link text-dark" asp-area="" asp-controller="Home" asp-action="Chat">Chat</a>
	</li>
11. Views/Home, add view named Chat.cshtml. There are three sections on the page: Register, Message, and Messages received.
12. wwwroot/js, add a new JavaScript file named chat.js

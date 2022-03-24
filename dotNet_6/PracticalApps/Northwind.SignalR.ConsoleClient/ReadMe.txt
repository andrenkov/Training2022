Building a console app chat client

1. Create new consolw app.
2. Add ref to "Microsoft.AspNetCore.SignalR.Client"and Northwind.Common
3. In Program.cs, import namespaces for working with SignalR
	using Microsoft.AspNetCore.SignalR.Client; // HubConnection
	using Northwind.Chat.Models; // RegisterModel, MessageModel
4. Add code to Program.cs aa per the example.
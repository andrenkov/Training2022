Chapter 18

OData is the standard for NOT .Net client communicating with .Net services using OData queries syntex. 
Ref to Microsoft.AspNetCore.OData

More modern technology for exposing your data as a service, then use an alternative to OData - GraphQL. Like OData, GraphQL is a standard for describing your data and then querying it that gives the client control over exactly what they need. GraphQL is transportagnostic and doesn't require the HTTP. You can use WebSockets, for example.

[36]
gRPC is a modern open source high-performance RPC framework. A gRPC client can call methods in a gRPC service on a different server as if it was a local object. The developer defines a service interface with methods that can be called remotely including their parameters and return types. The server implements this interface and runs a gRPC server to handle client calls. On the client, a strongly typed gRPC client provides the same methods as on the server.
The main limitation of gRPC is that it cannot be used in web browsers because no browser provides the level of control required to support a gRPC client.
Project template: ASP.NET Core gRPC Service

##############################################

1. Create new project gRPC Care.
2. Look at greet.proto. Proto file reference present int the csproj file.
3. Look at the Services.GreeterService.cs. It implements the service contract.
4. In Program.cs, add an extension method call to UseUrls to specify port 5006
5. Open launchSettings.json and modify the
5. launchSettings.json : applicationUrl setting to use port 5006

Building a gRPC client

We will add gRPC client packages to the Northwind MVC website project to enable it to call
the gRPC service:
1. Add package references for Google's Protobuf format, the gRPC client, and tools,
2. Copy the Protos folder from the Northwind.gRPC project/folder to the Northwind.Mvc
project/folder.
3. In the Northwind.Mvc project, in greet.proto, modify the namespace to match the
	namespace for the current project. PrivateAssets=all to ensure that
	the tools are not published with the production website.
4. Northwind.Mvc project file, add an item group to register the .proto file
5. In HomeController.cs, import namespaces to work with gRPC as a client.
6. In the Services action method, add statements to create a gRPC client and call the Greet method
7. ADD Services.cshtml to display result.
8. Change solution start projects to both above. Run and havigate to  https://localhost:5001/Home/Services

####################################

Working with EF Core Data

Server:

1. In the Northwind.gRPC project, add a project reference to the Northwind database context project
2. In the Northwind.gRPC project, in the Protos folder, add a new file (the item template is named Protocol Buffer File in Visual Studio) named shipper.proto
3. Project file add an entry to include the shipper.proto file.
4. In the Services folder, add a new class file named ShipperService.cs.
5. In Program.cs, import the namespace using Packt.Shared; // AddNorthwindContext extension method
6. Add builder.Services.AddNorthwindContext();
7. In configure the HTTP pipeline, after the call to register the Greeter service, add a statement to register the shipper service app.MapGrpcService<ShipperService>();

Client (Mvc project):

1. Copy the shipper.proto file from the Protos folder in the Northwind.gRPC
2. option csharp_namespace = "Northwind.Mvc.Sqlite";
3. Northwind.Mvc project file, add an entry to register the .proto file
4. HomeController.cs, in the Services action method to use ShiprClient
5. Views/Home, in Services.cshtml, add code to render the shipper details
6. Run and go to https://localhost:5001/home/services
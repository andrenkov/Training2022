1 Blazor Server Project

1. Create new project Blazor Server App
2. Check:
	- In Pages : _Host.cshtml and _Layout.cshtml
	- In Shared : MainLayout.razor and MainLayout.razor.css, NavMenu.razor
	- The pages folder has the "Components"  like Count.razor, FetchData.razor and Index.razor 
	- Data folder has the WeatherForecastService.cs service (just a class, not a Comtroller) file that is injected into the FetchData.razor component.
3. Blazor support style css files defined for a page. The name of the css file should match the Page name. 
4. Routing to components uses html tag where the name of the is the component's name. Example, < Rating Stars="5"/> where rating is the name of the component. !!!!!!
5. Routable page components have to have the @page on the top of the .razor file. Example, '@page "customers"'. This would be an equivalent to the MVC '[Route("customers")]'.
6. One file might have multiple @page directives for different routes.
7. <NavLink> is the class for navigation to the pages. In html it's equal to the ancor <a /> tag.
8. A route can have named parameters. Example, '@page "/customers/{country}"'. The param binding to the property by name such as: 
@code{
[Parameter]
public string Country (get;set;)
}

Good practice is to set a default for param using the event OnParametersSet() of the @page.

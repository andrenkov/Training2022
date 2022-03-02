//https://www.nuget.org/packages/Fritz.InstantAPIs/

//var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddSqlite<MyContext>(
//  "Data Source=contacts.db"
//);

//var app = builder.Build();

//app.MapGet("/api/Contacts", async (MyContext db) =>
//  await db.Contacts.ToArrayAsync()
//);
//app.MapGet("/api/Contacts/{id:int}", async (MyContext db, int id) => {
//    var contact = db.Contacts.FirstOrDefaultAsync(x => x.Id == id);
//    if (contact == null) return Results.NotFound();
//    return Results.Ok(contact);
//});

//app.Run();

//var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddSqlite<MyContext>(
//  "Data Source=contacts.db"
//);

//var app = builder.Build();

//app.MapInstantAPIs<MyContext>();

//app.Run();



/*

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
{
    var forecast = Enumerable.Range(1, 5).Select(index =>
       new WeatherForecast
       (
           DateTime.Now.AddDays(index),
           Random.Shared.Next(-20, 55),
           summaries[Random.Shared.Next(summaries.Length)]
       ))
        .ToArray();
    return forecast;
});

app.Run();

internal record WeatherForecast(DateTime Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
*/
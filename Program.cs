var builder = WebApplication.CreateBuilder(args);


builder.WebHost.UseUrls("http://localhost:5214");


builder.Services.AddAuthorization();
builder.Services.AddControllersWithViews();

var app = builder.Build();


app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();


app.MapGet("/api/hello-world", () =>
{
    return Results.Ok("Hello World");
});


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
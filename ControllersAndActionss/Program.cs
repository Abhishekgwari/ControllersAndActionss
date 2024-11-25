var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();           // provides routing 
var app = builder.Build();

app.MapControllerRoute(
    name:"default",
    pattern:"{controller=Home}/{action=Index}/{id?}");        // routing

//app.MapGet("/", () => "Hello World!");



app.Run();

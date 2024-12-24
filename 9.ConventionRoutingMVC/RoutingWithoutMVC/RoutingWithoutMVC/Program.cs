var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

//app.MapDefaultControllerRoute();  // this middleware will call only home controler or it's index method

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=PrashantController1}/{action=PrashantMethod}/{id?}"
    );

app.Run();

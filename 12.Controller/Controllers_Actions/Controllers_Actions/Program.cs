var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
var app = builder.Build();


app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
});


//app.UseRouting();
//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{ Action = Index}/{ Id?}");
//app.MapGet("/", () => "Hello World!");



app.Run();

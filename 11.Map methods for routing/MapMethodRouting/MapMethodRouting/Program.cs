var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseRouting();

app.UseEndpoints(Endpoint =>
{
    Endpoint.MapGet("/Home", async (context) =>
    {
       await context.Response.WriteAsync("this is home page .. GET");
    });

    Endpoint.MapPost("/Home", async (context) =>
    {
        await context.Response.WriteAsync("this is home page .. POST");
    });

    Endpoint.MapPut("/Home", async (context) =>
    {
        await context.Response.WriteAsync("this is home page .. PUT");
    });

    Endpoint.MapDelete("/Home", async (context) =>
    {
        await context.Response.WriteAsync("this is home page .. Delete");
    });

});

app.Run(async (HttpContext context) =>
{
    await context.Response.WriteAsync("Page Not Found");
});
//app.Map("/Home", () => "Hello World!");

//app.MapGet("/Home", () => "Hello World! - GET");

//app.MapPost("/Home", () => "Hello World! - post");

//app.MapPut("/Home", () => "Hello World! - put");

//app.MapDelete("/Home", () => "Hello World! - delet");


app.Run();

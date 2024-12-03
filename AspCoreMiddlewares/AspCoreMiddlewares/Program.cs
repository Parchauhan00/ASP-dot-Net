var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");
//app.Run(async (context) =>
//{
//    await context.Response.WriteAsync("Welcom to Your App Prashant");
//}
//);


app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("Welcom to Your App Prashant \n");
    await next(context);
}
);

app.Run(async (context) =>
{
    await context.Response.WriteAsync("Welcom to Prime's APP");
}
);



app.Run();

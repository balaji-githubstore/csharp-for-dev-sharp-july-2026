var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//middleware 1 -- logging
app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("Middleware 1 before\n");
    await next();
    await context.Response.WriteAsync("Middleware 1 after\n");
});

//middleware 2 -- auth
app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("Middleware 2 before\n");
    await next();
    await context.Response.WriteAsync("Middleware 2 after\n");
});

//middleware 3 -- auth
app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("Middleware 3 before\n");
    await next();
    await context.Response.WriteAsync("Middleware 3 after\n");
});

// app.MapWhen()
// app.UseWhen()

app.Run();

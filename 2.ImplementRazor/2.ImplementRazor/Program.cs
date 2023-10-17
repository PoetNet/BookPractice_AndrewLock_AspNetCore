var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
var app = builder.Build();

app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapRazorPages();
    // endpoints.MapHealthChecks("/healthz");
    endpoints.MapGet("/test", async context =>
    {
        await context.Response.WriteAsync("<h1>Hello everybody from tests!</h1>");
    });
});

app.Run();

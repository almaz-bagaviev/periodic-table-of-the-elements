var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
/*public void ConfigureServices(IServiceCollection services)*/
builder.Services.AddRazorPages();
builder.Services.AddMvc();

/*public void Configure(IApplicationBuilder app)*/
var app = builder.Build();
//app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting(); // Необходимо использовать для endpoints.MapControllerRoute

//app.UseAuthorization();
//app.MapRazorPages();


app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
    name: "Default",
    pattern: "{Controller=Home}/{Action=Index}");
});

app.Run();
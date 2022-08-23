namespace PeriodicTable;

public class Startup
{
    public IConfiguration Configuration { get; }
    
    public Startup(IConfiguration configuration)
    {
        this.Configuration = configuration;
    }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddRazorPages();
        services.AddMvc();

        services.AddDbContext<ChemicalElementsContext>(options =>
                 options.UseSqlServer(Configuration.GetConnectionString("ChemicalElementsConnection")));
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        app.UseStaticFiles();
        app.UseRouting();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllerRoute(
            name: "Default",
            pattern: "{Controller=Home}/{Action=Index}");
        });
    }
}

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
        //services.AddTransient<IElement, ChemicalElement>();
        services.AddMvc();

        services.AddDbContext<ChemicalElementsContext>(options =>
                 options.UseSqlServer(Configuration.GetConnectionString("ChemicalElementsConnection")));

        services.AddIdentity<ApplicationUser, IdentityRole>()
            .AddEntityFrameworkStores<ChemicalElementsContext>()
            .AddDefaultTokenProviders();

        services.Configure<IdentityOptions>(options =>
        {
            options.Password.RequiredLength = 6; //минимальное кол-во знаков в пароле
            options.Lockout.MaxFailedAccessAttempts = 5; //кол-во попыток, после чего => блокировка
            options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(10);
            options.Lockout.AllowedForNewUsers = true;
        });

        services.ConfigureApplicationCookie(options =>
        {
            // конфигурация Cookie с целью использования их для хранения авторизации
            options.Cookie.HttpOnly = true;
            options.ExpireTimeSpan = TimeSpan.FromMinutes(20);
            options.LoginPath = "/Account/Login";
            options.LogoutPath = "/Account/Logout";
            options.SlidingExpiration = true;
        });

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

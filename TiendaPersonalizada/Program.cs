using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TiendaPersonalizada.Data;

namespace TiendaPersonalizada
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Configure application services
            ConfigureServices(builder);

            var app = builder.Build();

            // Configure the HTTP request pipeline
            ConfigurePipeline(app);

            app.Run();
        }

        /// <summary>
        /// Configures services required for the application.
        /// </summary>
        /// <param name="builder">The web application builder.</param>
        private static void ConfigureServices(WebApplicationBuilder builder)
        {
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection")
                ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

            // Configure Entity Framework and database context
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connectionString));

            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            // Configure Identity for authentication and authorization
            builder.Services.AddDefaultIdentity<IdentityUser>(options =>
                options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>();

            // Configure MVC and controllers with views
            builder.Services.AddControllersWithViews();
        }

        /// <summary>
        /// Configures the HTTP request pipeline for the application.
        /// </summary>
        /// <param name="app">The web application instance.</param>
        private static void ConfigurePipeline(WebApplication app)
        {
            // Handle environment-specific configurations
            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage(); // Detailed errors for development
                app.UseMigrationsEndPoint(); // Enable migrations endpoint
            }
            else
            {
                // Configure exception handling
                app.UseExceptionHandler("/Home/Error"); // Handle general exceptions
                app.UseStatusCodePagesWithReExecute("/Home/Error404", "?statusCode={0}"); // Handle specific status codes
                app.UseHsts(); // Enforce HSTS for production
            }

            app.UseHttpsRedirection(); // Redirect HTTP to HTTPS
            app.UseStaticFiles(); // Serve static files

            // Enable routing
            app.UseRouting();

            // Enable authorization middleware
            app.UseAuthorization();

            // Configure default route for MVC
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            // Map Razor Pages
            app.MapRazorPages();
        }
    }
}

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using YachtClub.Models;

namespace YachtClub
{
    public class Startup
    {
        // Startup class receives the configuration data loaded from the appsettings.json file,
        // which is presented through an object that implements the IConfiguration interface.
        // The constructor assigns the IConfiguration object to a property called Configuration
        // so that it can be used by the rest of the Startup class.
        public Startup(IConfiguration configuration) => Configuration = configuration;
        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        { 
            // The method is an extension method that sets up the shared
            // objects used in MVC applications.

            // This extension method enables ASP.NET Core MVC.
            services.AddMvc();

            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(Configuration["Data:YachtClub:Connectionstring"]));


            // MVC emphasizes the use of loosely coupled components, which means you can make a change
            // in one part of the application without having to make corresponding changes elsewhere.
            // This approach categorizes parts of the application as services, which provide features
            // that other parts of the application use.

            // A component, such as a controller, needs an implementation of the IYachtRepository interface,
            // it should receive an instance of the FakeYachtRepository class.
            // The AddTransient method specifies that a new FakeYachtRepository object should be created
            // each time the IYachtRepository interface is needed.
            services.AddTransient<IYachtRepository, FakeYachtRepository>();
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {   // The method is used to set up the features that receive and
            // process HTTP requests.

            // This extension method displays details of exceptions that occur in the
            // application, which is useful during the development process.
            app.UseDeveloperExceptionPage();

            // This extension method adds a simple message to HTTP responses
            // that would not otherwise have a body, such as 404 - Not Found
            // responses. 
            app.UseStatusCodePages();

            // This extension method enables support for serving static
            // content from the wwwroot folder.
            app.UseStaticFiles();

            // Routing is responsible for matching incoming HTTP requests and
            // dispatching those requests to the app's executable endpoints.
            // Endpoints are the app's units of executable request-handling code. 
            app.UseRouting();

            // The EnsurePopulated method obtains an ApplicationDbContext object through the IApplicationBuilder
            // interface and calls the Database. Migrate method to ensure that the migration has been applied,
            // which means that the database will be created and prepared so that it can store Yacht
            // objects.Next, the number of Yacht objects in the database is checked. If there are no objects
            // in the  database, then the database is populated using a collection of Yacht objects using
            // the AddRange method and then written to the database using the SaveChanges method.
            SeedData.EnsurePopulated(app);

            app.UseEndpoints(endpoints =>
            { // Setting the Default Route URL
                endpoints.MapControllerRoute(name: "default", pattern: "{controller=Yacht}/{action=List}/{id?}");
            }
            );
        }
    }
}

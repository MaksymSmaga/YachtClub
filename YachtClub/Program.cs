using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace YachtClub
{
    public class Program
    {
        // The Program class is responsible for starting and configuring ASP.NET Core before
        // handing control to the Startup class.
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) => WebHost.CreateDefaultBuilder(args)
                        .UseStartup<Startup>()
                        .UseDefaultServiceProvider(options => options.ValidateScopes = false)
                        .Build();
    }
}

using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace AspNetCorePostgreSQLDockerApp
{
    public class Program
    {
        /*public static void Main(string[] args)
        {
            var config = new ConfigurationBuilder()
                .AddCommandLine(args)
                .AddEnvironmentVariables(prefix: "ASPNETCORE_")
                .Build();
                            
            var host = new WebHostBuilder()
                .UseConfiguration(config)
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }*/
        public static void Main(string[] args)
        {            
            var host = new WebHostBuilder()
                .UseKestrel()                
                .UseContentRoot(Directory.GetCurrentDirectory())
                //.UseUrls("http://*:9000") // listen on port 9000 on all network interfaces
                .UseIISIntegration()
                .UseStartup<Startup>()                
                .Build();
            host.Run();
        }
    }
}
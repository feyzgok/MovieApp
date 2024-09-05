
namespace MovieApp.Web
{
    public class Program
    {

        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        // CreateHostBuilder method is used to configure the web host

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(WebBuilder =>
            {
                WebBuilder.UseStartup<StartUp>();
            });

    }


}
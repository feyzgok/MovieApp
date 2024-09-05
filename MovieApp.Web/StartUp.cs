using System;

public class StartUp
{

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllersWithViews();
        services.AddRazorPages();
    }


    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        app.UseStaticFiles();//wwwroot klasörünü uygulamaya açar

        app.UseRouting();

        app.UseAuthorization();

        app.UseEndpoints(endpoints =>
        {

            //endpoints.MapGet("/", async context =>
            //{
            //    await context.Response.WriteAsync("Hello World!");
            //});

            //endpoints.MapGet("/home", async context =>
            //{
            //    await context.Response.WriteAsync("Hello Home");
            //});


            endpoints.MapControllerRoute(
                name: "home",
                pattern: "home/index",
                defaults: new { controller = "Home", action = "Index" }
            );

            endpoints.MapControllerRoute(
                name: "home",
                pattern: "home/about",
                defaults: new { controller = "Home", action = "About" }
            );

            endpoints.MapGet("/movies", async context =>
            {
                await context.Response.WriteAsync("Hello Movie");
            });

            endpoints.MapControllerRoute(
                name: "HelloWorld",
                pattern: "/",
                defaults: new { controller = "Home", action = "Index" }
            );
            endpoints.MapControllerRoute(
                name: "home",
                pattern: "/home",
                defaults: new { controller = "Home", action = "About" }
            );
            //initial -> homeindex, home page -> homeabout 
            endpoints.MapControllerRoute(
                name: "movieList",
                pattern: "movies/list",
                defaults: new { controller = "Movies", action = "List" }
            );

            endpoints.MapControllerRoute(
                name: "movieDetail",
                pattern: "movies/detail/{MovieId?}",
                defaults: new { controller = "Movies", action = "Detail" }
            );

            endpoints.MapControllerRoute(
                name: "movieIndex",
                pattern: "movies/index",
                defaults: new { controller = "Movies", action = "Index" }
            );

            endpoints.MapControllerRoute(
            name: "movieContent",
            pattern: "movies/list/{genreId?}",  // Use {genreId?} as part of the route
            defaults: new { controller = "Movies", action = "List" });

        });
    }
}


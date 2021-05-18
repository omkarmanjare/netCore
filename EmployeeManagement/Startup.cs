using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement
{
    public class Startup
    {
        private IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContextPool<AppDbContext>(optionsAction =>
            optionsAction.UseSqlServer(_configuration.GetConnectionString("EmployeeDBConnectnion"))); // Every time a new instance of 'AppDbContext' is needed, get it from pool insted of creating new

            //This is dependency injecction container. Here by adding services, we inject dependencies.
            services.AddMvc(); //this adds mvc  16.1
            services.AddSingleton<IEmployeeRepository, EmployeeRepository>(); //Registered dependency
            //HEre we have registerd IEmployeeRepository with EmployeeRepository. Hence when we try to get Employee data, it will go to in memory data i.e. EmployeeRepository
            //If we want to get data from SQL provider, we have to register dependency with SQLEmployeeRepository
            //like   services.AddSingleton<IEmployeeRepository, SQLEmployeeRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILogger<Startup> logger)

        {


            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            if(env.IsProduction() || env.IsStaging() || env.IsEnvironment("UAT"))
            {
                app.UseExceptionHandler("/Error");
            }

            //to add additinal middleware components app.Use is used
            //app.Use(async (context,next) => {
            //    logger.LogInformation("MW1 Request");
            //    await next();  //this will pass control to next available mw in pipeleine .i.e. next MS.Hence from this place, now control will go to "MW2 Request". 
            //    //Then it will go to next mw and so on.It will end where it find app.run. Then , from there onwards it will traverse back to "MW2 Response" and then back to "MW1 Response"
            //    logger.LogInformation("MW1 Response");
            //});

            //app.Use(async (context, next) => {
            //    logger.LogInformation("MW2 Request");
            //    await next();
            //    logger.LogInformation("MW2 Response");
            //});

             //app.UseDefaultFiles();// this is used for displaying any default pages like degault.html or index.html
            //incase if we want to add a user defined page to set as degault e.g. Home.html , that is also possible by using an instance of class DefaultFileOptions and pass it to 
            //app.UseDefaultFiles(); with required file name 

            app.UseStaticFiles(); // this is used for using any static files like css/js/html etc.
            
            //app.UseMvcWithDefaultRoute();//16.2 .After adding dependency above, we now use mvc middleware.When is gets defaust matching values like {controller=Home}/{action=Index}/{id?}' , it becomes treminal middleware here and ignores  next middleware
            // If we try to access other controller or other view in controller that does not exists, middleware wiont be able to find and it will pass to next treminal .i.e. app.Run in this case
            //this app.Run is a terminal middleware
            //there is also mw : app.UseFileServer() that serves purpose of app.UseDefaultFiles and app.UseStaticFiles. shown below. Either use app.UseDefaultFiles and app.UseStaticFiles or  app.UseFileServer

            //above mentioned mw app.UseMvcWithDefaultRoute(); is default route mapping that .net core idenitifes. We can also add own routing defination as below using app.UseMvc.
            //When using app.UseMvc, app.UseMvcWithDefaultRoute() is commented .Below mentioned is conventionalrouting
            //app.UseMvc(routes =>
            //            {
            //                routes.MapRoute("default", "{controller=Home}/{action=Details}/{id?}");
            //                //1. if nothing matches with this format, it wont work {controller}/{action}/{id}
            //                //2. we can give default values as well like {controller=Home}/{action=Details}/{id?} where we define id as optional character
            //            }
            //      );


            //below mentioned is for attribute routing.Commented above module app.UseMvac( routes > ......
            app.UseMvc();

            //FileServerOptions fs = new FileServerOptions();
            //fs.DefaultFilesOptions.DefaultFileNames.Clear();
            //fs.DefaultFilesOptions.DefaultFileNames.Add("foo.html");
            //app.UseFileServer(fs);





            //app.Run(async (context) =>
            //{
            //   // throw new System.Exception("Some Manual exception");
            //    await context.Response.WriteAsync("Hosting Environment " + env.EnvironmentName);  //this will give value of environment variable we set in launchsettings.json
            //});


            //app.Run(async (context) =>
            //{
            //    // throw new System.Exception("Some Manual exception");
            //    await context.Response.WriteAsync("Hello " + env.EnvironmentName);  //this will give value of environment variable we set in launchsettings.json
            //});
        }
    }
}

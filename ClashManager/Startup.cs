using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ClashManager.Domain.Services.Configuration;
using ClashManager.Domain.Services.ClashHttp;
using ClashManager.Domain.Services.ClashApiGateway;
using ClashManager.Domain.Db;
using ClashManager.Domain.Db.Abstractions;
using Microsoft.AspNetCore.Authentication;
using Microsoft.IdentityModel.Logging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.Identity.Web;
using Microsoft.Identity.Web.UI;

namespace ClashManager
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAuthentication(OpenIdConnectDefaults.AuthenticationScheme)
            .AddMicrosoftIdentityWebApp(Configuration.GetSection("AzureAdB2C"));

            services.AddAuthorization(options =>
            {
                // By default, all incoming requests will be authorized according to 
                // the default policy
                options.FallbackPolicy = options.DefaultPolicy;
            });
            services.AddRazorPages(options => {
                options.Conventions.AllowAnonymousToPage("/Index");
            })
                .AddMvcOptions(options => { })
                .AddMicrosoftIdentityUI();
            services.AddRazorPages();

            services.AddSingleton<IConfigurationService, ConfigurationService>();
            services.AddSingleton<IClashApiGatewayService, ClashApiGatewayService>();
            services.AddSingleton<IClashHttpService, ClashHttpService>();

            services.AddSingleton<IAccountDb, AccountDb>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}

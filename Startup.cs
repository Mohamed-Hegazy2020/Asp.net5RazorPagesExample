using Asp.net5RazorPagesExample.Data;
using Asp.net5RazorPagesExample.Resources;
using Asp.net5RazorPagesExample.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.net5RazorPagesExample
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
            //services.AddRazorPages().AddRazorRuntimeCompilation();

            services.AddRazorPages(options =>
            {

                options.RootDirectory = "/Pages/User";
                //options.Conventions.AddPageRoute("/Index", "/User/Index");
            }).AddRazorRuntimeCompilation();

            services.AddDbContext<DBContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddMvc().AddViewLocalization();

            services.AddLocalization(options => options.ResourcesPath = "Resources");

            services.AddMvc()
                .AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix)
                .AddDataAnnotationsLocalization();

        //    services.AddMvc().AddDataAnnotationsLocalization(options => {options.DataAnnotationLocalizerProvider = (type, factory) =>
        //        factory.Create(typeof(CommonResources));
        //});
            services.AddSingleton<CommonLocalizationService>();
            services.Configure<RequestLocalizationOptions>(options =>
            {
                var supportedCultures = new[]
                 {
                    new CultureInfo("en"),
                    new CultureInfo("ar"),
      
                 };
                options.DefaultRequestCulture = new RequestCulture("ar-EG");
                options.SupportedCultures = supportedCultures;
                options.SupportedUICultures = supportedCultures;
            });
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

            app.UseRouting();
            var localizationOptions = app.ApplicationServices.GetService<IOptions<RequestLocalizationOptions>>().Value;
            app.UseRequestLocalization(localizationOptions);
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapDefaultControllerRoute();
                endpoints.MapRazorPages();
            });
        }
    }
}

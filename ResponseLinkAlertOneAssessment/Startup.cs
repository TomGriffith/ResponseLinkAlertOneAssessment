using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.SpaServices.AngularCli;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using ResponseLinkAlertOneAssessment.Data;
using System.Text;

namespace ResponseLinkAlertOneAssessment
{
    public class Startup
    {
        // this key would be stored elsewhere in a non-demo application
        private const string SECRET_KEY = "tUsCcTSddc8GTfdtsyWNZhkbF5r87J4JLeXTLdDyanFp9wtTxnh2Z3xwhy53VGMHNawFMZftt2JEaMUK2P36NHqq9yZJg26peZGhUzyuwhrmN2TmNpuUvSBKjsUcx8h2keM5SHWqhhFaHqDm4LQ2ffvsVASnrHPmqFheQYp5jxh4nk2fC5eK28sV2Mzpj6rG6FcQU8ELz7eCyj7Z8DgfqC8J4K8Dp4MmKbpDr8ybkJPYrsxBTBBVVqrkEhZawWYd";
        public static readonly SymmetricSecurityKey SIGNING_KEY =
            new SymmetricSecurityKey(Encoding.UTF8.GetBytes(SECRET_KEY));

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            // In production, the Angular files will be served from this directory
            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "ClientApp/dist";
            });
            services.AddDbContext<StoreContext>();

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = "JwtBearer";
                options.DefaultChallengeScheme = "JwtBearer";
            })
            .AddJwtBearer("JwtBearer", jwtOptions =>
            {
                jwtOptions.TokenValidationParameters = new TokenValidationParameters()
                {
                    IssuerSigningKey = SIGNING_KEY,
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidIssuer = "https://localhost:44321",
                    ValidAudience = "https://localhost:44321",
                    ValidateLifetime = true
                };
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
            if (!env.IsDevelopment())
            {
                app.UseSpaStaticFiles();
            }

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller}/{action=Index}/{id?}");
            });

            app.UseSpa(spa =>
            {
                // To learn more about options for serving an Angular SPA from ASP.NET Core,
                // see https://go.microsoft.com/fwlink/?linkid=864501

                spa.Options.SourcePath = "ClientApp";

                if (env.IsDevelopment())
                {
                    spa.UseAngularCliServer(npmScript: "start");
                }
            });


        }
    }
}

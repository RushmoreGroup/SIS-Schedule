using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Text;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.Extensions.Options;
using SISSchedule_BusinessServices;
using SISSchedule_DTO;
using SISSchedule_Entities;
using SISSchedule_Repository;
using SISSchedule_Utilities;
using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.PlatformAbstractions;
using System.Reflection;
using System.IO;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Authentication.JwtBearer;
namespace SISSchedule_API
{
    /// <summary>
    /// Startup class - SISSchedule
    /// </summary>
    public class Startup
    {
        public Startup(IConfiguration configuration, IWebHostEnvironment env)
        {
            Configuration = configuration;
            Environment = env;
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                  .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                  .AddEnvironmentVariables();

            Configuration = builder.Build();
        }

        public IWebHostEnvironment Environment { get; }
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            #region DBContext
            services.AddControllers();
            services.AddDbContext<SISScheduleContext>(options =>
     options.UseSqlServer(Configuration["ConnectionString:SISScheduleDB"]));
            #endregion

            #region Bind Repository

            services.AddScoped<IProviderDataRepository<Providers, ProviderDTO>, ProviderBusinessService>();
            #endregion
            #region Swagger
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "SISScheduleReportAPI", Version = "v1" });
            });
            #endregion

            #region Logging

            services.AddLogging();

            #endregion

            #region Setting .Net Core Version
            services.AddMvc()
                //.AddJsonOptions(
                // options => options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
                //)
                .SetCompatibilityVersion(CompatibilityVersion.Latest);

            // configure strongly typed settings objects
            var appSettingsSection = Configuration.GetSection("AppSettings");
            services.Configure<AppSettings>(appSettingsSection);

            // configure jwt authentication
            var appSettings = appSettingsSection.Get<AppSettings>();
            var key = Encoding.ASCII.GetBytes(appSettings.Secret);
            #endregion

            #region Singleton
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            #endregion

            #region Authentication
            services.AddMvc(x =>
            {
                if (!Environment.IsDevelopment())
                {
                    var authenticatedUserPolicy = new AuthorizationPolicyBuilder()
                    .RequireAuthenticatedUser()
                    .Build();
                    x.Filters.Add(new AllowAnonymousFilter());
                    // x.Filters.Add(new AuthorizeFilter());
                }
                else
                {
                    // x.Filters.Add(new AuthorizeFilter());
                    x.Filters.Add(new AllowAnonymousFilter());
                }
            });

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;

            })
            .AddJwtBearer(options =>
            {
                options.SecurityTokenValidators.Clear();
                //options.SecurityTokenValidators.Add(new CustomSecurityTokenValidator());
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    NameClaimType = Convert.ToString("upn")


                };

            });
            #endregion

            #region APIBehaviourOptions
            services.Configure<ApiBehaviorOptions>(options =>
            {
                options.SuppressConsumesConstraintForFormFileParameters = true;
                options.SuppressInferBindingSourcesForParameters = true;
                options.SuppressModelStateInvalidFilter = true;
            });
            #endregion

            #region CORS
            //services.AddCors(options =>
            //{
            //    //options.AddPolicy("CorsPolicy",
            //    //builder => builder.AllowAnyOrigin()
            //    //.AllowAnyMethod()
            //    //.AllowAnyHeader()
            //    //.AllowCredentials());
            //});
            services.AddMvc();
            #endregion

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            #region Environment and Swagger setting
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "SISScheduleReportAPI v1"));
            }
            #endregion

            #region CORS
            app.UseCors("CorsPolicy");
            // global cors policy
            app.UseCors(x => x
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());
            #endregion

            #region Global Exception Handler

            // configure strongly typed settings objects
            var appSettingsSection = Configuration.GetSection("AppSettings");


            // // configure jwt authentication
            var appSettings = appSettingsSection.Get<AppSettings>();


            app.ConfigureExceptionHandler(appSettings.ErrorFilePath);
            #endregion

            app.UseStaticFiles();

            #region Authentication
            app.UseAuthentication();
            #endregion

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

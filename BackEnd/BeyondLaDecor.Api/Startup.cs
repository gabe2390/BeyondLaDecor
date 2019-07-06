using BeyondLaDecor.Beyond.Api.Constants;
using BeyondLaDecor.Beyond.Business;
using BeyondLaDecor.Beyond.Data;
using BeyondLaDecor.Beyond.Data.Repositories;
using BeyondLaDecor.Beyond.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;

namespace BeyondLaDecor.Beyond.Api
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1)
                .AddJsonOptions(e => e.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
            services.AddCors();
            ConfigureSqlServer(services);
            ConfigureIdentity(services);
            MapDependencies(services);
        }

        private void ConfigureIdentity(IServiceCollection services)
        {
            services.AddIdentity<User, Role>()
                .AddEntityFrameworkStores<BeyondDbContext>()
                .AddDefaultTokenProviders();
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = IdentityConstants.ApplicationScheme;
                options.DefaultChallengeScheme = IdentityConstants.ApplicationScheme;
            });
            services.Configure<IdentityOptions>(options =>
            {
                // Password settings
                options.Password.RequireDigit = true;
                options.Password.RequiredLength = 7;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = true;
                options.Password.RequireLowercase = true;

                // Lockout settings
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(30);
                options.Lockout.MaxFailedAccessAttempts = 10;
                options.Lockout.AllowedForNewUsers = true;

                // User settings
                options.User.RequireUniqueEmail = true;
            });

            services.ConfigureApplicationCookie(options =>
            {
                // Cookie settings
                options.Cookie.HttpOnly = true;
                options.Cookie.Expiration = TimeSpan.FromDays(150);
                // If the LoginPath isn't set, ASP.NET Core defaults 
                // the path to /Account/Login.
                options.LoginPath = "/Account/Login";
                // If the AccessDeniedPath isn't set, ASP.NET Core defaults 
                // the path to /Account/AccessDenied.
                options.AccessDeniedPath = "/Account/AccessDenied";
                options.SlidingExpiration = true;
            });
            AddUserManagementDependencies(services);
        }

        private void AddUserManagementDependencies(IServiceCollection services)
        {
            services.TryAddScoped<SignInManager<User>, SignInManager<User>>();
            services.TryAddScoped<UserManager<User>, AspNetUserManager<User>>();
            services.TryAddScoped<RoleManager<User>, AspNetRoleManager<User>>();
        }

        private void ConfigureSqlServer(IServiceCollection services)
        {
            var connectionString = Configuration.GetValue<string>(ConfigurationConstants.BeyondLaDecorConnectionString);
            services.AddEntityFrameworkSqlServer()
                .AddDbContext<BeyondDbContext>(options => options.UseSqlServer(connectionString));
        }

        private void MapDependencies(IServiceCollection services)
        {
            //Logic
            services.AddScoped<IProductLogic, ProductLogic>();
            services.AddScoped<IServiceLogic, ServiceLogic>();
            services.AddScoped<IUserLogic, UserLogic>();
            services.AddScoped<IEventLogic, EventLogic>();
            services.AddScoped<IEventTypeLogic, EventTypeLogic>();
            services.AddScoped<IPackageLogic, PackageLogic>();
            services.AddScoped<IPackageProductLogic, PackageProductLogic>();
            services.AddScoped<IPackageServiceLogic, PackageServiceLogic>();
            services.AddScoped<IProductTypeLogic, ProductTypeLogic>();
            services.AddScoped<IServiceTypeLogic, ServiceTypeLogic>();
            services.AddScoped<IServiceVendorLogic, ServiceVendorLogic>();
            services.AddScoped<IVendorLogic, VendorLogic>();
            services.AddScoped<ISettingLogic, SettingLogic>();
            services.AddScoped<IUserSettingLogic, UserSettingLogic>();
            //Repositories
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IProductTypeRepository, ProductTypeRepository>();
            services.AddScoped<IServiceRepository, ServiceRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IEventRepository, EventRepository>();
            services.AddScoped<IEventTypeRepository, EventTypeRepository>();
            services.AddScoped<IProductServiceTypeRepository, ProductServiceTypeRepository>();
            services.AddScoped<IPackageRepository, PackageRepository>();
            services.AddScoped<IPackageProductRepository, PackageProductRepository>();
            services.AddScoped<IPackageServiceRepository, PackageServiceRepository>();
            services.AddScoped<IProductTypeRepository, ProductTypeRepository>();
            services.AddScoped<IServiceTypeRepository, ServiceTypeRepository>();
            services.AddScoped<IServiceVendorRepository, ServiceVendorRepository>();
            services.AddScoped<IVendorRepository, VendorRepository>();
            services.AddScoped<ISettingRepository, SettingRepository>();
            services.AddScoped<IUserSettingRepository, UserSettingRepository>();
            services.AddScoped<ILocationRepository, LocationRepository>();
            services.AddScoped<IEventLocationRepository, EventLocationRepository>();

            services.AddScoped(typeof(BeyondDbContext),
                       (c) => new BeyondDbContextFactory(Configuration.GetValue<string>(ConfigurationConstants.BeyondLaDecorConnectionString))
                       .CreateDbContext(null));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                //app.UseHsts();
            }
            app.UseCors(options => options.WithOrigins("https://localhost:44331/").AllowAnyMethod());
            app.UseMvc();
            app.UseAuthentication();
        }
    }
}

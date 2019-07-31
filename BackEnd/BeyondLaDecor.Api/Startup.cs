using AutoMapper;
using BeyondLaDecor.Api;
using BeyondLaDecor.Beyond.Api.Constants;
using BeyondLaDecor.Beyond.Business;
using BeyondLaDecor.Beyond.Data;
using BeyondLaDecor.Beyond.Data.Models;
using BeyondLaDecor.Beyond.Data.Repositories;
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
            services.AddHttpContextAccessor();
            AddAutoMapperConfig(services);
            ConfigureSqlServer(services);
            ConfigureIdentity(services);
            MapDependencies(services);
        }

        private void AddAutoMapperConfig(IServiceCollection services)
        {
            services.AddAutoMapper(typeof(Startup));
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new AutoMapperProfile());
            });
            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
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
            services.TryAddTransient<SignInManager<User>, SignInManager<User>>();
            services.TryAddTransient<UserManager<User>, AspNetUserManager<User>>();
            services.TryAddTransient<RoleManager<User>, AspNetRoleManager<User>>();
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
            services.AddTransient<IProductLogic, ProductLogic>();
            services.AddTransient<IServiceLogic, ServiceLogic>();
            services.AddTransient<IUserLogic, UserLogic>();
            services.AddTransient<IEventLogic, EventLogic>();
            services.AddTransient<IEventTypeLogic, EventTypeLogic>();
            services.AddTransient<IPackageLogic, PackageLogic>();
            services.AddTransient<IPackageProductLogic, PackageProductLogic>();
            services.AddTransient<IPackageServiceLogic, PackageServiceLogic>();
            services.AddTransient<IProductTypeLogic, ProductTypeLogic>();
            services.AddTransient<IServiceTypeLogic, ServiceTypeLogic>();
            services.AddTransient<IServiceVendorLogic, ServiceVendorLogic>();
            services.AddTransient<IVendorLogic, VendorLogic>();
            services.AddTransient<ISettingLogic, SettingLogic>();
            services.AddTransient<IUserSettingLogic, UserSettingLogic>();
            services.AddTransient<IInventoryLogic, InventoryLogic>();
            services.AddTransient<IInventoryRecordLogic, InventoryRecordLogic>();
            services.AddTransient<ILaDecorUserManager, LaDecorUserManager>();
            //Repositories
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<IProductTypeRepository, ProductTypeRepository>();
            services.AddTransient<IServiceRepository, ServiceRepository>();
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IEventRepository, EventRepository>();
            services.AddTransient<IEventTypeRepository, EventTypeRepository>();
            services.AddTransient<IProductServiceTypeRepository, ProductServiceTypeRepository>();
            services.AddTransient<IPackageRepository, PackageRepository>();
            services.AddTransient<IPackageProductRepository, PackageProductRepository>();
            services.AddTransient<IPackageServiceRepository, PackageServiceRepository>();
            services.AddTransient<IProductTypeRepository, ProductTypeRepository>();
            services.AddTransient<IServiceTypeRepository, ServiceTypeRepository>();
            services.AddTransient<IServiceVendorRepository, ServiceVendorRepository>();
            services.AddTransient<IVendorRepository, VendorRepository>();
            services.AddTransient<ISettingRepository, SettingRepository>();
            services.AddTransient<IUserSettingRepository, UserSettingRepository>();
            services.AddTransient<ILocationRepository, LocationRepository>();
            services.AddTransient<IEventLocationRepository, EventLocationRepository>();
            services.AddTransient<IInventoryRecordRepository, InventoryRecordRepository>();
            services.AddTransient<IInventoryRepository, InventoryRepository>();

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
            app.UseCors(options => options.AllowAnyOrigin().AllowAnyMethod().AllowCredentials().AllowAnyMethod());
            app.UseMvc();
            app.UseAuthentication();
        }
    }
}

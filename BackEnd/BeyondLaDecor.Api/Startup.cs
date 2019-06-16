using BeyondLaDecor.Beyond.Api.Constants;
using BeyondLaDecor.Beyond.Api.Controllers;
using BeyondLaDecor.Beyond.Business;
using BeyondLaDecor.Beyond.Data;
using BeyondLaDecor.Beyond.Data.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddCors();
            MapDependencies(services);
            ConfigureSqlServer(services);
        }

        private void ConfigureSqlServer(IServiceCollection services)
        {
            var connectionString = Configuration.GetValue<string>(ConfigurationConstants.BeyondLaDecorConnectionString);
            services.AddEntityFrameworkSqlServer()
                .AddDbContext<BeyondDbContext>(options => options.UseSqlServer(connectionString));
        }

        private void MapDependencies(IServiceCollection services)
        {
            //Controller
            services.AddTransient(typeof(IBaseController<>), typeof(BaseController<>));
            //Repositories
            services.AddTransient(typeof(IBaseModelRepository<>), typeof(BaseModelRepository<>));
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

            //Logic
            services.AddTransient(typeof(IBusinessLogicBase<>), typeof(BusinessLogicBase<>));
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

            services.AddTransient(typeof(BeyondDbContext),
                       (c) => new BeyondDbContextFactory(
                           Configuration.GetValue<string>(ConfigurationConstants.BeyondLaDecorConnectionString))
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
        }
    }
}

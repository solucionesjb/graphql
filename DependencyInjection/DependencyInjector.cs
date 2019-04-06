using Business.Contamination;
using Business.GetInfo;
using CdmxContamination;
using CdmxContamination.GraphQL;
using CdmxContamination.Types;
using DatabaseAccess.Contamination;
using GraphQL;
using GraphQL.Http;
using GraphQL.Types;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DependencyInjection
{
    public static class DependencyInjector
    {
        static IServiceProvider ServiceProvider { get; set; }

        private static IServiceCollection Services { get; set; }

        public static void AddDbContext<T>(string connectionString) where T : DbContext
        {
            Services.AddDbContext<T>(options => options.UseSqlServer(connectionString), ServiceLifetime.Singleton);
            var context = GetService<T>();
            context.Database.EnsureCreated();
            context.Database.Migrate();
        }

        public static T GetService<T>()
        {
            Services = Services ?? RegisterServices();
            ServiceProvider = ServiceProvider ?? Services.BuildServiceProvider();
            return ServiceProvider.GetService<T>();
        }

        public static IServiceCollection RegisterServices()
        {
            return RegisterServices(new ServiceCollection());
        }

        public static IServiceCollection RegisterServices(IServiceCollection services)
        {
            Services = services;

            Services.AddSingleton<IContaminationBusiness, ContaminationBusiness>();
            Services.AddSingleton<IContaminationDatabaseAccess, ContaminationDatabaseAccess>();
            Services.AddSingleton<IExtractInfoJsonFile, ExtractInfoJsonFile>();

            services.AddSingleton<IDependencyResolver>(s => new FuncDependencyResolver(s.GetRequiredService));
            services.AddSingleton<IDocumentExecuter, DocumentExecuter>();
            services.AddSingleton<IDocumentWriter, DocumentWriter>();

            services.AddSingleton<CdmxContaminationQuery>();
            services.AddSingleton<ContaminationType>();
            services.AddSingleton<ZoneType>();
            services.AddSingleton<ISchema, CdmxContaminationSchema>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            return Services;
        }
    }
}

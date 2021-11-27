﻿using System;
using Ims.Case.Entities;
using Ims.Case.Repository;
using Ims.Case.Supervisor;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Filters;

namespace Ims.Case.Api
{
    internal static class ApplicationConfiguration
    {
        public static IServiceCollection AddMiddleware(this IServiceCollection services)
        {
            services.AddControllers()
                .AddNewtonsoftJson(options =>
                {
                    options.SerializerSettings.NullValueHandling = NullValueHandling.Include;
                    options.SerializerSettings.Formatting = Formatting.Indented;
                });
            return services;
        }

        public static IServiceCollection AddConnectionProvider(this IServiceCollection services, IConfiguration configuration)
        {
            var connection = configuration.GetConnectionString("DefaultConnection") ??
                     "Server=.;Database=Case-DB;Trusted_Connection=True;MultipleActiveResultSets=Trues";
            services.AddDbContextPool<CaseApiContext>(options => options.UseSqlServer(connection, o => o.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery)));
            return services;
        }
        public static IServiceCollection ConfigureSupervisor(this IServiceCollection services)
        {
            services.AddScoped<ICaseApiSupervisor, CaseApiSupervisor>();
            return services;
        }

        public static IServiceCollection ConfigureRepositories(this IServiceCollection services)
        {
            services.AddScoped<ICFAssociationRepository, CFAssociationRepository>()
                .AddScoped<ICFAssociationGroupingRepository, CFAssociationGroupingRepository>()
                .AddScoped<ICFConceptRepository, CFConceptRepository>()
                .AddScoped<ICFDocumentRepository, CFDocumentRepository>()
                .AddScoped<ICFItemRepository, CFItemRepository>()
                .AddScoped<ICFItemTypeRepository, CFItemTypeRepository>()
                .AddScoped<ICFLicenseRepository, CFLicenseRepository>()
                .AddScoped<ICFRubricRepository, CFRubricRepository>()
                .AddScoped<ICFRubricCriterionRepository, CFRubricCriterionRepository>()
                .AddScoped<ICFRubricCriterionLevelRepository, CFRubricCriterionLevelRepository>()
                .AddScoped<ICFSubjectRepository, CFSubjectRepository>();
            return services;
        }

        public static IServiceCollection ConfigureServices(this IServiceCollection services)
        {
            services.AddCaching();
            services.AddScoped<ILinkFactory, LinkFactory>();
            services.AddScoped<IUriGenerator, UriGenerator>();
            services.AddScoped<IApiModelFactory, ApiModelFactory>();
            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            return services;
        }

        public static IServiceCollection ConfigureSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.EnableAnnotations();
                
                //c.CustomOperationIds(GenerateOperationId);
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Competencies and Academic Standards Exchange API",
                    Description = "The Competencies and Academic Standards Exchange (CASE) Service enables the exchange of data between a " +
                        "Competency Records Service Provider and the consumers of the associated data. This service has been described using the " +
                        "IMS Model Driven Specification development approach this being the Platform Specific Model (PSM) of the service.",
                    TermsOfService = new Uri("http://www.opendefinition.org/licenses/odc-by"),
                    Contact = new OpenApiContact
                    {
                        Name = "Brad Marshall",
                        Email = "bmarshall@sped-tx.net"
                    },
                    License = new OpenApiLicense
                    {
                        Name = "Open Data Commons Attribution License (ODCAL)",
                        Url = new Uri("http://www.opendefinition.org/licenses/odc-by")
                    },
                    Version = "v1p0"
                });
            });
            services.AddSwaggerExamples();

            return services;
        }

        private static string GenerateOperationId(ApiDescription apiDescription)
        {
            if (apiDescription.ActionDescriptor is ControllerActionDescriptor controllerDescriptor)
            {
                return controllerDescriptor.ActionName;
            }

            return apiDescription.ActionDescriptor.DisplayName;
        }

        public static IServiceCollection AddAppSettings(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<AppSettings>(_ => configuration.GetSection("AppSettings").Bind(_));
            return services;
        }

        public static IServiceCollection AddCaching(this IServiceCollection services)
        {
            services.AddMemoryCache();
            services.AddResponseCaching();
            return services;
        }

        public static IServiceCollection AddLogging(this IServiceCollection services)
        {
            services.AddLogging(builder => builder
                .AddConsole()
                .AddFilter(level => level >= LogLevel.Information)
            );
            return services;
        }
    }

    public class AppSettings
    {
    }

}

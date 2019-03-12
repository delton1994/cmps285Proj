using System.Text;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StarterProject.Api.Common;
using StarterProject.Api.Data;
using StarterProject.Api.Features.Choices;
using StarterProject.Api.Features.Languages;
using StarterProject.Api.Features.Questions;
using StarterProject.Api.Features.Users;
using StarterProject.Api.Helpers;
using StarterProject.Api.Infrastructure;
using StarterProject.Api.Infrastructure.ServiceCollectionExtensions;
using StarterProject.Api.Security.Policies;
using StarterProject.Api.Services;

namespace StarterProject.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors();
            services.AddMvc(options =>
                {
                    options.Filters.Add(new ModelStateFilter());
                })
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
                .AddFluentValidation(options =>
                {
                    options.RegisterValidatorsFromAssemblyContaining<Startup>();
                });
             

            SetupDatabase(services);
            SetupAuthentication(services);
            SetupAuthorization(services);
            SetupCustomDependencies(services);
            services.AddScoped<IQuestionRepository, QuestionRepository>();
            services.AddScoped<ILanguageRepository, LanguageRepository>();
            services.AddScoped<IChoiceRepository, ChoiceRepository>();
        }

        private void SetupDatabase(IServiceCollection services)
        {
            services.AddDbContext<DataContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DataContext")));

            //services.AddDbContext<DataContext>(opt =>
            //    opt.UseInMemoryDatabase("StarterProjectInMemoryDb"));
        }

        private void SetupAuthentication(IServiceCollection services)
        {
            var appSettingsSection = Configuration.GetSection("AppSettings");
            services.Configure<AppSettings>(appSettingsSection);

            var appSettings = appSettingsSection.Get<AppSettings>();
            var key = Encoding.ASCII.GetBytes(appSettings.Secret);

            services.AddJwtAuthentication(key);
            services.AddSwaggerDocumentation();
        }

        private void SetupAuthorization(IServiceCollection services)
        {
            services.AddAuthorization(options =>
            {
                options.AddPolicy(Constants.Policies.CanChangeUserRole, policy =>
                    policy.Requirements.Add(new CanChangeUserRoleRequirement()));
            });

            services.AddSingleton<IAuthorizationHandler, CanChangeUserRoleHandler>();
        }

        private void SetupCustomDependencies(IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUserRepository, UserRepository>();
        }
        
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwaggerDocumentation();
            }
            else
            {
                app.UseHsts();
            }

            app.UseCors(x => x
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());

            app.UseAuthentication();
            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Text.Json;
using WaProject_API.Infra.Context;
using WaProject_API.Infra.Repository;
using WaProject_API.Infra.Repository.Interface;
using WaProject_API.Service;
using WaProject_API.Service.Authentication;
using WaProject_API.Service.Authentication.Authorization;
using WaProject_API.Service.Authentication.Swagger;
using WaProject_API.Service.Interface;

namespace WaProject_API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public static IConfiguration Configuration { get; private set; }

        
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = ApiKeyAuthenticationOptions.DefaultScheme;
                options.DefaultChallengeScheme = ApiKeyAuthenticationOptions.DefaultScheme;
            }).AddApiKeySupport(options => { });

            services.AddAuthorization(options =>
            {
               
                options.AddPolicy(Policies.OnlyManagers, policy => policy.Requirements.Add(new OnlyManagersRequirement()));
                
            });

            services.AddDbContext<DataContext>(options =>
                  options.UseMySQL(Configuration.GetConnectionString("DefaultMysql")));

            services.AddTransient<IEquipeRepository, EquipeRepository>();           
            services.AddTransient<IPedidoRepository, PedidoRepository>();           
            services.AddTransient<IProdutoRepository, ProdutoRepository>();           
            services.AddTransient<IPedidoAdoRepository, PedidoAdoRepository>();           
            services.AddTransient<IPedidoService, PedidoService>();

            services.AddSingleton<IAuthorizationHandler, OnlyManagersAuthorizationHandler>();

            services.AddSingleton<IGetApiKeyQuery, InMemoryGetApiKeyQuery>();

            services.AddRouting(x => x.LowercaseUrls = true);
            services.AddControllers()
                .AddJsonOptions(options =>
                {
                    options.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
                    options.JsonSerializerOptions.IgnoreNullValues = true;
                });

            services.ConfigureSwaggerFeature();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "TinsWeb");
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

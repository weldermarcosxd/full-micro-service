using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Pdi.Full.Micro.Service.Bus.RabbitMqImplementations.Extensions;
using Pdi.Full.Micro.Service.Repositories.Contexts;
using Pdi.Full.Micro.Service.Repositories.Extensions;
using Pdi.Full.Micro.Service.Services.Extensions;

namespace Pdi.Full.Micro.Service.WebApi
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
            services.AddControllers();
            services.AdicionarRepositorios();
            services.AdicionarServicos();
            services.AdicionarRabbitMq(Configuration);

            services.AdicionarDbContextPorProvider(Configuration);

            services.AddCors(options =>
            {
                options.AddDefaultPolicy(
                    policy  =>
                    {
                        policy.WithOrigins("https://localhost",
                            "http://localhost:3000")
                            .AllowAnyMethod()
                            .AllowAnyHeader()
                            .AllowCredentials();
                    });
            });
            
            services.Configure<RouteOptions>(options => options.LowercaseUrls = true); 
            
            services.AddSwaggerGen();
            services.AddSwaggerGen(c => {
                c.SwaggerDoc("v1", new OpenApiInfo {
                    Title = "Cadastro de Produtos e Vendas", Version = "v1"
                });
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseCors();

            app.UseSwagger();
            app.UseSwaggerUI(c =>{
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
            });
            

            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
    }
}
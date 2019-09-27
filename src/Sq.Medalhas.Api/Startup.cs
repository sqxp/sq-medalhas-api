using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
using Sq.Medalhas.Api.Extensions;
using Sq.Medalhas.GraphQl.Models;
using Sq.Medalhas.Services.Abstractions;

namespace Sq.Medalhas.Api
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSynchronousIO();
            services.AddQuadroMedalhasGraphQl();
            
            // TODO: criar uma implementação para ICalculoService.
            services.TryAddScoped<ICalculoService>(provider => null);
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();

            app.UseGraphQlWithPlayground(
                graphQlEndpoint:"/graphql",
                graphQlPlaygroundEndpoint:"/ui/playground"
            );
        }
    }
}
using GraphQL;
using GraphQL.Server;
using GraphQL.Server.Ui.Playground;
using GraphQL.Types;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Sq.Medalhas.GraphQl.Models.Queries;
using Sq.Medalhas.GraphQl.Models.Types;

namespace Sq.Medalhas.GraphQl.Models
{
    public static class Startup
    {
        public static void AddQuadroMedalhasGraphQl(this IServiceCollection services)
        {
            services.TryAddScoped<IDependencyResolver>(s => new FuncDependencyResolver(s.GetRequiredService));
            services.TryAddScoped<QuadroMedalhasQuery>();
            services.TryAddScoped<QuadroMedalhasType>();
            services.TryAddScoped<ISchema, QuadroMedalhasSchema>();
            services.AddGraphQL(options =>
            {
                options.EnableMetrics = true;
                options.ExposeExceptions = true;
            });
        }
        public static void UseGraphQlWithPlayground(this IApplicationBuilder app, string graphQlEndpoint, string graphQlPlaygroundEndpoint)
        {
            app.UseGraphQL<ISchema>(graphQlEndpoint);
            app.UseGraphQLPlayground(new GraphQLPlaygroundOptions
            {
                Path = graphQlPlaygroundEndpoint,
                GraphQLEndPoint = graphQlEndpoint
            });            
        }
        
    }
}
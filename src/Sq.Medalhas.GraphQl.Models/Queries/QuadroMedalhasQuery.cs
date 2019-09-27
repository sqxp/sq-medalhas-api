using GraphQL.Types;
using Sq.Medalhas.GraphQl.Models.Types;
using Sq.Medalhas.Services.Abstractions;

namespace Sq.Medalhas.GraphQl.Models.Queries
{
    public class QuadroMedalhasQuery : ObjectGraphType<object>
    {
        public QuadroMedalhasQuery(ICalculoService service)
        {
            Name = "Query";
            FieldAsync<QuadroMedalhasType>(
                "CalcularQuadroMedalhas",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<StringGraphType>> {Name = "id", Description = "id da pessoa"}
                ),
                resolve: async context => await service.CalcularQuadroMedalhasAsync(context.GetArgument<string>("id"))
            );
        }
    }
}
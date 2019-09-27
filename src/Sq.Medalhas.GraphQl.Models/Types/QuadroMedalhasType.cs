using GraphQL.Types;
using Sq.Medalhas.Models;

namespace Sq.Medalhas.GraphQl.Models.Types
{
    public class QuadroMedalhasType : ObjectGraphType<QuadroMedalhas>
    {
        public QuadroMedalhasType()
        {
            Name = "QuadroMedalhas";
            Description = "Quadro de medalhas";
            Field(p => p.Ouro).Description("Quantidade de medalhas de ouro");
            Field(p => p.Prata).Description("Quantidade de medalhas de prata");
            Field(p => p.Bronze).Description("Quantidade de medalhas de bronze");
        }
    }
}
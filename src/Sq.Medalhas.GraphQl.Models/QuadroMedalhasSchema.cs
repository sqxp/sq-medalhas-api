using GraphQL;
using GraphQL.Types;
using Sq.Medalhas.GraphQl.Models.Queries;

namespace Sq.Medalhas.GraphQl.Models
{
    public class QuadroMedalhasSchema : Schema
    {
        public QuadroMedalhasSchema(IDependencyResolver dependencyResolver)
            : base(dependencyResolver)
        {
            Query = dependencyResolver.Resolve<QuadroMedalhasQuery>();
        }
    }
}
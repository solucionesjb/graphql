using CdmxContamination.GraphQL;
using GraphQL;
using GraphQL.Types;

namespace CdmxContamination
{
    public class CdmxContaminationSchema : Schema
    {
        public CdmxContaminationSchema(IDependencyResolver resolver) : base(resolver)
        {
            Query = resolver.Resolve<CdmxContaminationQuery>();
        }
    }
}

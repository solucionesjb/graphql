using CdmxContamination.Dto;
using CdmxContamination.Types;
using GraphQL.Types;

namespace CdmxContamination
{
    public class ContaminationMutation : ObjectGraphType
    {
        public ContaminationMutation()
        {
            Name = "Mutation";

            Field<ContaminationType>(
                "createContamination",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<ContaminationInputType>> { Name = "contamination" }
                ),
                resolve: context =>
                {
                    var contamination = context.GetArgument<ContaminationDto>("contamination");
                    return AddHuman(contamination);
                });
        }

        public ContaminationDto AddHuman(ContaminationDto contamination)
        {
            return contamination;
        }
    }
}

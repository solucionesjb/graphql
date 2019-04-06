using CdmxContamination.Dto;
using GraphQL.Types;

namespace CdmxContamination
{
    public class ContaminationInputType : InputObjectGraphType<ContaminationDto>
    {
        public ContaminationInputType()
        {
            Name = "ContaminationInput";
            Field(x => x.Name);
            Field(x => x.HomePlanet, nullable: true);
        }
    }
}

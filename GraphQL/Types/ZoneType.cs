using Dtos;
using GraphQL.Types;

namespace CdmxContamination.Types
{
    public class ZoneType : ObjectGraphType<ZonaDto>
    {
        public ZoneType()
        {
            Name = "Zona";
            Description = "Contaminacion de la zona centro de la ciudad de mexico.";

            Field(h => h.Ozono).Description("Ozono.");
            Field(h => h.DioxidoAzufre).Description("Dioxido de Azufre.");
            Field(h => h.DioxidoNitrogeno).Description("Dioxido de Nitrogeno.");
            Field(h => h.MonoxidoCarbono).Description("Monoxido de Carbono.");
            Field(h => h.Pm10).Description("PM 10.");
        }
    }
}

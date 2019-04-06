using Dtos;
using GraphQL.Types;
using System.Linq;

namespace CdmxContamination.Types
{
    public class ContaminationType : ObjectGraphType<ContaminacionDto>
    {
        public ContaminationType()
        {
            Name = "Contaminacion";
            Description = "Contaminacion de la ciudad de mexico, por fecha y hora.";

            Field(h => h.FechaCorta).Description("Fecha en formato corto (yyyy-mm-dd).");
            Field(h => h.Hora).Description("Hora de la medición.");
            Field<ListGraphType<ZoneType>>("Centro",
                Description = "Contaminacion de la zona Centro de la CDMX.",
                resolve: context =>
                {
                    return context.Source.Centro;
                });
            Field<ListGraphType<ZoneType>>("Noreste",
                Description = "Contaminacion de la zona Noreste de la CDMX.",
                resolve: context =>
                {
                    return context.Source.Noreste;
                });
            Field<ListGraphType<ZoneType>>("Noroeste",
                Description = "Contaminacion de la zona Noroeste de la CDMX.",
                resolve: context =>
                {
                    return context.Source.Noroeste;
                });
            Field<ListGraphType<ZoneType>>("Sureste",
                Description = "Contaminacion de la zona Sureste de la CDMX.",
                resolve: context =>
                {
                    return context.Source.Sureste;
                });
            Field<ListGraphType<ZoneType>>("Suroeste",
                Description = "Contaminacion de la zona Suroeste de la CDMX.",
                resolve: context =>
                {
                    return context.Source.Suroeste;
                });
        }
    }
}
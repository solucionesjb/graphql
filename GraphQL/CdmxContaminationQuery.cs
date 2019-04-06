using Business.Contamination;
using CdmxContamination.Types;
using Dtos;
using GraphQL.Types;
using System.Collections.Generic;

namespace CdmxContamination.GraphQL
{
    public class CdmxContaminationQuery : ObjectGraphType<object>
    {
        private IContaminationBusiness ContaminationBusiness { get; }

        public CdmxContaminationQuery(IContaminationBusiness contaminationBusiness)
        {
            ContaminationBusiness = contaminationBusiness;

            Name = "Query";

            Field<ListGraphType<ContaminationType>>(
                "obtenerCalidadAirePorFechaCorta",
                Description = "Obtiene los niveles de calidad del aire de la CDMX por fecha.",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<StringGraphType>>
                    {
                        Name = "fechaCorta",
                        Description = "Fecha que se desea consultar en formato yyyy-mm-dd."
                    }
                ),
                resolve: context =>
                {
                    var result = ContaminationBusiness.GetContaminationByShortDate(context.GetArgument<string>("fechaCorta"));
                    return result.Success ? result.Result : new List<ContaminacionDto>();
                }
            );

            Field<ContaminationType>(
                "obtenerCalidadAirePorFechaCortaHora",
                Description = "Obtiene los niveles de calidad del aire de la CDMX por fecha y hora.",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<StringGraphType>>
                    {
                        Name = "fechaCorta",
                        Description = "Fecha que se desea consultar en formato yyyy-mm-dd."
                    },
                    new QueryArgument<NonNullGraphType<IntGraphType>>
                    {
                        Name = "hora",
                        Description = "Hora que se desea consultar de 1 -24 horas."
                    }
                ),
                resolve: context =>
                {
                    var result = ContaminationBusiness.GetContaminationByShortDateAndHour(context.GetArgument<string>("fechaCorta"), context.GetArgument<int>("hora"));
                    return result.Success ? result.Result : new ContaminacionDto();
                }
            );
        }
    }
}

using System.Collections.Generic;
using System.Threading.Tasks;
using Business.Contamination;
using Business.GetInfo;
using Dtos;
using Microsoft.AspNetCore.Mvc;

namespace CdmxContamination.Web.Controllers
{
    /// <summary>
    /// Servicios para obtener datos de la calidad del aire en la CDMX.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ContaminationController : ControllerBase
    {
        private IContaminationBusiness ContaminationBusiness { get; }
        private IExtractInfoJsonFile ExtractInfoJsonFile { get; set; }

        public ContaminationController(IContaminationBusiness contaminationBusiness, IExtractInfoJsonFile extractInfoJsonFile)
        {
            ContaminationBusiness = contaminationBusiness;
            ExtractInfoJsonFile = extractInfoJsonFile;
        }

        /// <summary>
        /// Obtiene los niveles de calidad del aire de la CDMX por fecha.
        /// </summary>
        /// <param name="fechaCorta">Fecha que se desea consultar en formato yyyy-mm-dd.</param>
        /// <returns>Lista con los niveles de la calidad del aire por fecha, hora y zona.</returns>
        [HttpGet("{fechaCorta}")]
        public OperationResultDto<List<ContaminacionDto>> ObtenerCalidadAirePorFechaCorta(string fechaCorta)
        {
            return ContaminationBusiness.GetContaminationByShortDate(fechaCorta);
        }


        /// <summary>
        /// Obtiene los niveles de calidad del aire de la CDMX por fecha y hora.
        /// </summary>
        /// <param name="fechaCorta">Fecha que se desea consultar en formato yyyy-mm-dd.</param>
        /// <param name="hora">Hora que se desea consultar de 1 -24 horas.</param>
        /// <returns>Información de la fecha y hora solicitada.</returns>
        [HttpGet("{fechaCorta}/{hora}")]
        public OperationResultDto<ContaminacionDto> ObtenerCalidadAirePorFechaCortaHora(string fechaCorta, int hora)
        {
            return ContaminationBusiness.GetContaminationByShortDateAndHour(fechaCorta, hora);
        }

        /// <summary>
        /// Obtiene infromacion de los archivos Json de la calidad del aire en CDMX descargados.
        /// </summary>
        /// <returns>True si el proceso fue exitoso, en caso contrario falso.</returns>
        [HttpGet]
        public async Task<OperationResultDto<List<int>>> ExtraerInformacionArchivoJson()
        {
            return await ExtractInfoJsonFile.ExtractInfo();
        }
    }
}

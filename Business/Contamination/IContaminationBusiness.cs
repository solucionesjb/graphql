using Dtos;
using System.Collections.Generic;

namespace Business.Contamination
{
    public interface IContaminationBusiness
    {
        OperationResultDto<List<ContaminacionDto>> GetContaminationByShortDate(string shortDate);
        OperationResultDto<ContaminacionDto> GetContaminationByShortDateAndHour(string shortDate, int hour);
    }
}

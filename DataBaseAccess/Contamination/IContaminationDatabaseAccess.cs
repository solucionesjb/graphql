using Dtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DatabaseAccess.Contamination
{
    public interface IContaminationDatabaseAccess
    {
        Task<OperationResultDto<int>> Save(List<ContaminacionDto> listData);
        OperationResultDto<List<ContaminacionDto>> GetContaminationByShortDate(DateTime datetime);
        OperationResultDto<ContaminacionDto> GetContaminationByShortDateAndHour(DateTime datetime, int hour);
    }
}

using DatabaseAccess.Contamination;
using Dtos;
using System;
using System.Collections.Generic;
using Utils;

namespace Business.Contamination
{
    public sealed class ContaminationBusiness : IContaminationBusiness
    {
        private IContaminationDatabaseAccess ContaminationDatabaseAccess { get; }

        public ContaminationBusiness(IContaminationDatabaseAccess contaminationDatabaseAccess)
        {
            ContaminationDatabaseAccess = contaminationDatabaseAccess;
        }

        public OperationResultDto<List<ContaminacionDto>> GetContaminationByShortDate(string shortDatetime)
        {
            OperationResultDto<List<ContaminacionDto>> result;
            try
            {
                var datetime = Convert.ToDateTime(shortDatetime);
                result = ContaminationDatabaseAccess.GetContaminationByShortDate(datetime);
            }
            catch (Exception ex)
            {
                result = new OperationResultDto<List<ContaminacionDto>> { Error = ex.ErrorMessage() };
            }

            return result;
        }

        public OperationResultDto<ContaminacionDto> GetContaminationByShortDateAndHour(string shortDatetime, int hour)
        {
            OperationResultDto<ContaminacionDto> result;
            try
            {
                var datetime = Convert.ToDateTime(shortDatetime);
                result = ContaminationDatabaseAccess.GetContaminationByShortDateAndHour(datetime, hour);
            }
            catch (Exception ex)
            {
                result = new OperationResultDto<ContaminacionDto> { Error = ex.ErrorMessage() };
            }

            return result;
        }
    }
}

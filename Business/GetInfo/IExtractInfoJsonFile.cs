using Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.GetInfo
{
    public interface IExtractInfoJsonFile
    {
        Task<OperationResultDto<List<int>>> ExtractInfo();
    }
}

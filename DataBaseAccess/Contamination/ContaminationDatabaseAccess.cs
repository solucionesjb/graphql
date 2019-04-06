using DatabaseAccess.Utils;
using Dtos;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Utils;

namespace DatabaseAccess.Contamination
{
    public sealed class ContaminationDatabaseAccess : IContaminationDatabaseAccess
    {
        private DatabaseContext Context { get; }

        public ContaminationDatabaseAccess(DatabaseContext context)
        {
            Context = context;
        }

        public async Task<OperationResultDto<int>> Save(List<ContaminacionDto> listData)
        {
            OperationResultDto<int> result;
            try
            {
                var dateTime = listData.First().FechaCorta;
                var contaminationDatetimeExist = await Context.Contaminacion.FirstOrDefaultAsync(p => p.Fecha.Equals(dateTime));
                if (contaminationDatetimeExist == null)
                {
                    foreach (var item in listData)
                    {
                        await Context.Contaminacion.AddAsync(item.ContaminationDtoToModelMapper());
                    }

                    var response = await Context.SaveChangesAsync();

                    result = new OperationResultDto<int> { Success = true, Result = response };
                }
                else
                {
                    result = new OperationResultDto<int> { Error = $"Ya existen registros de la fecha { dateTime.ToShortDateString() }." };
                }
            }
            catch (Exception ex)
            {
                result = new OperationResultDto<int> { Error = ex.Message };
            }

            return result;
        }

        public OperationResultDto<List<ContaminacionDto>> GetContaminationByShortDate(DateTime datetime)
        {
            OperationResultDto<List<ContaminacionDto>> result;
            try
            {
                result = new OperationResultDto<List<ContaminacionDto>>
                {
                    Success = true,
                    Result = Context.Contaminacion
                    .Where(p => p.Fecha.Equals(datetime))
                    .Include(p => p.Centro)
                    .Include(p => p.Noreste)
                    .Include(p => p.Noroeste)
                    .Include(p => p.Sureste)
                    .Include(p => p.Suroeste)
                    .Select(p => p.ContaminationModelToDtoMapper()).ToList()
                };
            }
            catch (Exception ex)
            {
                result = new OperationResultDto<List<ContaminacionDto>> { Error = ex.ErrorMessage() };
            }

            return result;
        }

        public OperationResultDto<ContaminacionDto> GetContaminationByShortDateAndHour(DateTime datetime, int hour)
        {
            OperationResultDto<ContaminacionDto> result;
            try
            {
                result = new OperationResultDto<ContaminacionDto>
                {
                    Success = true,
                    Result = Context.Contaminacion
                    .Where(p => p.Fecha.Equals(datetime) && p.Hora == hour)
                    .Include(p => p.Centro)
                    .Include(p => p.Noreste)
                    .Include(p => p.Noroeste)
                    .Include(p => p.Sureste)
                    .Include(p => p.Suroeste)
                    .FirstOrDefault()
                    .ContaminationModelToDtoMapper()
                };
            }
            catch (Exception ex)
            {
                result = new OperationResultDto<ContaminacionDto> { Error = ex.ErrorMessage() };
            }

            return result;
        }
    }
}

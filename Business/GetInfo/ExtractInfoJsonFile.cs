using DatabaseAccess.Contamination;
using Dtos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Utils;

namespace Business.GetInfo
{
    public class ExtractInfoJsonFile : IExtractInfoJsonFile
    {
        private IContaminationDatabaseAccess ContaminationDatabaseAccess { get; set; }
        public ExtractInfoJsonFile(IContaminationDatabaseAccess contaminationDatabaseAccess)
        {
            ContaminationDatabaseAccess = contaminationDatabaseAccess;
        }

        public async Task<OperationResultDto<List<int>>> ExtractInfo()
        {
            var result = new OperationResultDto<List<int>> { Result = new List<int>() };

            try
            {
                var path = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
                foreach (var item in Directory.GetFiles($@"{path}\Files"))
                {
                    using (var reader = new StreamReader(item))
                    {
                        var listaDatos = new List<ContaminacionDto>();
                        var banderaObtenerDatos = false;

                        while (!reader.EndOfStream)
                        {
                            var line = reader.ReadLine();
                            if (line.Contains("Fecha,Hora"))
                            {
                                banderaObtenerDatos = true;
                                continue;
                            }
                            if (banderaObtenerDatos)
                            {
                                var values = line.Split(',');

                                var row = new ContaminacionDto
                                {
                                    FechaCorta = values[0].TryParseDatetime(),
                                    Hora = values[1].TryParseInt(),
                                    Noroeste = new List<ZonaDto>
                                {
                                    new ZonaDto
                                    {
                                        Ozono = values[2].TryParseInt(),
                                        DioxidoAzufre = values[3].TryParseInt(),
                                        DioxidoNitrogeno = values[4].TryParseInt(),
                                        MonoxidoCarbono = values[5].TryParseInt(),
                                        Pm10 = values[6].TryParseInt()
                                    }
                                },
                                    Noreste = new List<ZonaDto>
                                {
                                    new ZonaDto
                                    {
                                        Ozono = values[7].TryParseInt(),
                                        DioxidoAzufre = values[8].TryParseInt(),
                                        DioxidoNitrogeno = values[9].TryParseInt(),
                                        MonoxidoCarbono = values[10].TryParseInt(),
                                        Pm10 = values[11].TryParseInt()
                                    }
                                },
                                    Centro = new List<ZonaDto>
                                {
                                    new ZonaDto
                                    {
                                        Ozono = values[12].TryParseInt(),
                                        DioxidoAzufre = values[13].TryParseInt(),
                                        DioxidoNitrogeno = values[14].TryParseInt(),
                                        MonoxidoCarbono = values[15].TryParseInt(),
                                        Pm10 = values[16].TryParseInt()
                                    }
                                },
                                    Suroeste = new List<ZonaDto>
                                {
                                    new ZonaDto
                                    {
                                        Ozono = values[17].TryParseInt(),
                                        DioxidoAzufre = values[18].TryParseInt(),
                                        DioxidoNitrogeno = values[19].TryParseInt(),
                                        MonoxidoCarbono = values[20].TryParseInt(),
                                        Pm10 = values[21].TryParseInt()
                                    }
                                },
                                    Sureste = new List<ZonaDto>
                                {
                                    new ZonaDto
                                    {
                                        Ozono = values[22].TryParseInt(),
                                        DioxidoAzufre = values[23].TryParseInt(),
                                        DioxidoNitrogeno = values[24].TryParseInt(),
                                        MonoxidoCarbono = values[25].TryParseInt(),
                                        Pm10 = values[26].TryParseInt()
                                    }
                                }
                                };

                                listaDatos.Add(row);
                            }
                        }

                        if (listaDatos.Any())
                        {
                            var response = await ContaminationDatabaseAccess.Save(listaDatos);
                            if(response.Success)
                            {
                                result.Result.Add(response.Result);
                            }
                            else
                            {
                                result.Error += response.Error;
                            }
                        }
                    }
                }

                result.Success = result.Result.Any();
            }
            catch (Exception ex)
            {
                result = new OperationResultDto<int> { Error = ex.ErrorMessage() };
            }

            return result;
        }
    }
}

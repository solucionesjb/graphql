using Dtos;
using Models;
using System.Collections.Generic;
using System.Linq;
using Utils;

namespace DatabaseAccess.Utils
{
    public static class Mapper
    {
        public static ContaminacionDto ContaminationModelToDtoMapper(this Contaminacion contamination)
        {
            if (contamination == null)
            {
                return new ContaminacionDto();
            }

            return new ContaminacionDto
            {
                FechaCorta = contamination.Fecha,
                Hora = contamination.Hora,
                Centro = contamination.Centro.ModelToDtoMapper(),
                Noreste = contamination.Noreste.ModelToDtoMapper(),
                Noroeste = contamination.Noroeste.ModelToDtoMapper(),
                Sureste = contamination.Sureste.ModelToDtoMapper(),
                Suroeste = contamination.Suroeste.ModelToDtoMapper()
            };
        }

        public static Contaminacion ContaminationDtoToModelMapper(this ContaminacionDto contamination)
        {
            if (contamination == null)
            {
                return new Contaminacion();
            }

            return new Contaminacion
            {
                Fecha = contamination.FechaCorta,
                Hora = (byte)contamination.Hora,
                Centro = contamination.Centro.CentroDtoToModelMapper(),
                Noreste = contamination.Noreste.NoresteDtoToModelMapper(),
                Noroeste = contamination.Noroeste.NoroesteDtoToModelMapper(),
                Sureste = contamination.Sureste.SuresteDtoToModelMapper(),
                Suroeste = contamination.Suroeste.SuroesteDtoToModelMapper()
            };
        }

        #region Model to Dto

        public static List<ZonaDto> ModelToDtoMapper(this List<CentroModel> zona)
        {
            if (zona == null)
            {
                return new List<ZonaDto>();
            }

            return zona.Select(p => new ZonaDto
            {
                Ozono = p.Ozono ?? 0,
                DioxidoAzufre = p.DioxidoAzufre ?? 0,
                DioxidoNitrogeno = p.DioxidoNitrogeno ?? 0,
                MonoxidoCarbono = p.MonoxidoCarbono ?? 0,
                Pm10 = p.Pm10 ?? 0
            }).ToList();
        }

        public static List<ZonaDto> ModelToDtoMapper(this List<NoresteModel> zona)
        {
            if (zona == null)
            {
                return new List<ZonaDto>();
            }

            return zona.Select(p => new ZonaDto
            {
                Ozono = p.Ozono ?? 0,
                DioxidoAzufre = p.DioxidoAzufre ?? 0,
                DioxidoNitrogeno = p.DioxidoNitrogeno ?? 0,
                MonoxidoCarbono = p.MonoxidoCarbono ?? 0,
                Pm10 = p.Pm10 ?? 0
            }).ToList();
        }

        public static List<ZonaDto> ModelToDtoMapper(this List<NoroesteModel> zona)
        {
            if (zona == null)
            {
                return new List<ZonaDto>();
            }

            return zona.Select(p => new ZonaDto
            {
                Ozono = p.Ozono ?? 0,
                DioxidoAzufre = p.DioxidoAzufre ?? 0,
                DioxidoNitrogeno = p.DioxidoNitrogeno ?? 0,
                MonoxidoCarbono = p.MonoxidoCarbono ?? 0,
                Pm10 = p.Pm10 ?? 0
            }).ToList();
        }

        public static List<ZonaDto> ModelToDtoMapper(this List<SuresteModel> zona)
        {
            if (zona == null)
            {
                return new List<ZonaDto>();
            }

            return zona.Select(p => new ZonaDto
            {
                Ozono = p.Ozono ?? 0,
                DioxidoAzufre = p.DioxidoAzufre ?? 0,
                DioxidoNitrogeno = p.DioxidoNitrogeno ?? 0,
                MonoxidoCarbono = p.MonoxidoCarbono ?? 0,
                Pm10 = p.Pm10 ?? 0
            }).ToList();
        }

        public static List<ZonaDto> ModelToDtoMapper(this List<SuroesteModel> zona)
        {
            if (zona == null)
            {
                return new List<ZonaDto>();
            }

            return zona.Select(p => new ZonaDto
            {
                Ozono = p.Ozono ?? 0,
                DioxidoAzufre = p.DioxidoAzufre ?? 0,
                DioxidoNitrogeno = p.DioxidoNitrogeno ?? 0,
                MonoxidoCarbono = p.MonoxidoCarbono ?? 0,
                Pm10 = p.Pm10 ?? 0
            }).ToList();
        }

        #endregion

        #region Dto to Model

        public static List<CentroModel> CentroDtoToModelMapper(this List<ZonaDto> zona)
        {
            if (zona == null)
            {
                return new List<CentroModel>();
            }

            return zona.Select(p => new CentroModel
            {
                Ozono = (byte)p.Ozono,
                DioxidoAzufre = (byte)p.DioxidoAzufre,
                DioxidoNitrogeno = (byte)p.DioxidoNitrogeno,
                MonoxidoCarbono = (byte)p.MonoxidoCarbono,
                Pm10 = (byte)p.Pm10
            }).ToList();
        }

        public static List<NoresteModel> NoresteDtoToModelMapper(this List<ZonaDto> zona)
        {
            if (zona == null)
            {
                return new List<NoresteModel>();
            }

            return zona.Select(p => new NoresteModel
            {
                Ozono = (byte)p.Ozono,
                DioxidoAzufre = (byte)p.DioxidoAzufre,
                DioxidoNitrogeno = (byte)p.DioxidoNitrogeno,
                MonoxidoCarbono = (byte)p.MonoxidoCarbono,
                Pm10 = (byte)p.Pm10
            }).ToList();
        }

        public static List<NoroesteModel> NoroesteDtoToModelMapper(this List<ZonaDto> zona)
        {
            if (zona == null)
            {
                return new List<NoroesteModel>();
            }

            return zona.Select(p => new NoroesteModel
            {
                Ozono = (byte)p.Ozono,
                DioxidoAzufre = (byte)p.DioxidoAzufre,
                DioxidoNitrogeno = (byte)p.DioxidoNitrogeno,
                MonoxidoCarbono = (byte)p.MonoxidoCarbono,
                Pm10 = (byte)p.Pm10
            }).ToList();
        }

        public static List<SuresteModel> SuresteDtoToModelMapper(this List<ZonaDto> zona)
        {
            if (zona == null)
            {
                return new List<SuresteModel>();
            }

            return zona.Select(p => new SuresteModel
            {
                Ozono = (byte)p.Ozono,
                DioxidoAzufre = (byte)p.DioxidoAzufre,
                DioxidoNitrogeno = (byte)p.DioxidoNitrogeno,
                MonoxidoCarbono = (byte)p.MonoxidoCarbono,
                Pm10 = (byte)p.Pm10
            }).ToList();
        }

        public static List<SuroesteModel> SuroesteDtoToModelMapper(this List<ZonaDto> zona)
        {
            if (zona == null)
            {
                return new List<SuroesteModel>();
            }

            return zona.Select(p => new SuroesteModel
            {
                Ozono = (byte)p.Ozono,
                DioxidoAzufre = (byte)p.DioxidoAzufre,
                DioxidoNitrogeno = (byte)p.DioxidoNitrogeno,
                MonoxidoCarbono = (byte)p.MonoxidoCarbono,
                Pm10 = (byte)p.Pm10
            }).ToList();
        }

        #endregion
    }
}

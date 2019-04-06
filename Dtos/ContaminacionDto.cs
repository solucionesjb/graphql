using System;
using System.Collections.Generic;

namespace Dtos
{
    public class ContaminacionDto
    {
        public DateTime FechaCorta { get; set; }
        public int Hora { get; set; }
        public List<ZonaDto> Centro { get; set; }
        public List<ZonaDto> Noreste { get; set; }
        public List<ZonaDto> Noroeste { get; set; }
        public List<ZonaDto> Sureste { get; set; }
        public List<ZonaDto> Suroeste { get; set; }
    }
}

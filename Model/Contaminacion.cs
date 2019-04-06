using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Contaminacion
    {
        [Key]
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public byte Hora { get; set; }

        public virtual List<CentroModel> Centro { get; set; }
        public virtual List<NoresteModel> Noreste { get; set; }
        public virtual List<NoroesteModel> Noroeste { get; set; }
        public virtual List<SuresteModel> Sureste { get; set; }
        public virtual List<SuroesteModel> Suroeste { get; set; }
    }
}

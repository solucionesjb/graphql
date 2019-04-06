
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class CentroModel
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("ContaminacionId")]
        public int ContaminacionId { get; set; }

        public byte? Ozono { get; set; }
        public byte? DioxidoAzufre { get; set; }
        public byte? DioxidoNitrogeno { get; set; }
        public byte? MonoxidoCarbono { get; set; }
        public byte? Pm10 { get; set; }

        public virtual Contaminacion Contaminacion { get; set; }
    }
}

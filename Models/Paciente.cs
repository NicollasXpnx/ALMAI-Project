using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PacientesALMAI.Models
{
    public class Paciente
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        public ICollection<Terapia> Terapias { get; set; }
    }
}

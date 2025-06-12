// Models/Terapia.cs
using System;
using System.ComponentModel.DataAnnotations;

namespace PacientesALMAI.Models
{
    public class Terapia
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public DayOfWeek DiaSemana { get; set; }

        [Required]
        public TimeSpan Hora { get; set; }

        [Required]
        public string Periodo { get; set; } // Ex: Manhã, Tarde, Noite

        [Required]
        public int PacienteId { get; set; }

        public Paciente Paciente { get; set; }
    }
}

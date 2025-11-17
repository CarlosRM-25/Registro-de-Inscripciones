using System.ComponentModel.DataAnnotations;

namespace Registro_de_Inscripciones.Models
{
    public class Inscripcion
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [MinLength(2, ErrorMessage = "El nombre debe tener al menos 2 caracteres.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Los apellidos son obligatorios.")]
        [MinLength(2, ErrorMessage = "Los apellidos deben tener al menos 2 caracteres.")]
        public string Apellidos { get; set; }

        [Required(ErrorMessage = "El correo es obligatorio.")]
        [EmailAddress(ErrorMessage = "Formato de correo inválido.")]
        public string Correo { get; set; }

        [Required(ErrorMessage = "El teléfono es obligatorio.")]
        [RegularExpression(@"^\d{9,}$", ErrorMessage = "El teléfono debe tener más de 8 dígitos y contener solo números.")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "Debe seleccionar un taller.")]
        [Display(Name = "Taller")]
        public string Taller { get; set; }

        [Required(ErrorMessage = "El nivel de experiencia es obligatorio.")]
        [Display(Name = "Nivel de experiencia")]
        public string NivelExperiencia { get; set; }

        [Required(ErrorMessage = "La fecha del taller es obligatoria.")]
        [DataType(DataType.Date)]
        [FutureOrToday(ErrorMessage = "La fecha del taller debe ser hoy o una fecha futura.")]
        [Display(Name = "Fecha del taller")]
        public DateTime FechaTaller { get; set; }

        [MustBeTrue(ErrorMessage = "Debe aceptar los términos y condiciones para completar la inscripción")]
        [Display(Name = "Acepta términos y condiciones")]
        public bool AceptaTerminos { get; set; }

        private class FutureOrTodayAttribute : Attribute
        {
            public string ErrorMessage { get; set; }
        }

        private class MustBeTrueAttribute : Attribute
        {
            public string ErrorMessage { get; set; }
        }
    }
}

using System.ComponentModel.DataAnnotations;

namespace Registro_de_Inscripciones.Models
{
    public class MustBeTrueAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value is bool b)
            {
                return b;
            }
            return false;
        }
    }
}
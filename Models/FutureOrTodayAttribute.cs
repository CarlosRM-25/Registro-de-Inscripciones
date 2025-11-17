using System;
using System.ComponentModel.DataAnnotations;

namespace Registro_de_Inscripciones.Models
{
    public class FutureOrTodayAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null) return false;
            if (value is DateTime dt)
            {
                // comparar solo fecha (sin hora)
                var today = DateTime.Today;
                return dt.Date >= today;
            }
            return false;
        }
    }
}

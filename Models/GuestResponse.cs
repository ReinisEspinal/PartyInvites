using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Porfavor colocar su nombre")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Porfavor colocar su correo electronico")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Porfavor colocar su telefono")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Porfavor especificar si asistira")]
        public bool? WillAttend { get; set; }
    }
}
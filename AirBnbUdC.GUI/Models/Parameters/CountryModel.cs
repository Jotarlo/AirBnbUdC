using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AirBnbUdC.GUI.Models.Parameters
{
    public class CountryModel
    {
        [DisplayName("País")]
        public int Id { get; set; }

        [DisplayName("Nombre")]
        [Required(ErrorMessage = "El nombre es requerido")]
        [StringLength(50, ErrorMessage = "El nombre debe tener entre 1 y 50 caracteres", MinimumLength = 1)]
        public string Name { get; set; }
    }
}

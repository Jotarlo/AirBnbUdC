using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AirBnbUdC.GUI.Models.Parameters
{
    public class CityModel
    {
        [DisplayName("Ciudad")]
        public int Id { get; set; }

        [DisplayName("Nombre")]
        [Required(ErrorMessage = "El nombre es requerido")]
        [StringLength(50, ErrorMessage = "El nombre debe tener entre 1 y 50 caracteres", MinimumLength = 1)]
        public string Name { get; set; }

        [Required]
        public CountryModel Country { get; set; }

        public IEnumerable<CountryModel> CountryList { get; set; }
    }
}

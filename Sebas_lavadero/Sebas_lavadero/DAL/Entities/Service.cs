using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Sebas_lavadero.DAL.Entities
{
    public class Service : Entity
    {
        [Display(Name = " nombre del servicio")]//Nombre que quiero mostrar en la web
        [MaxLength(100)]
        [Required(ErrorMessage = "\"El campo {0} es obligatorio\"")]
        public string Name { get; set; }


        [Display(Name = "el precio del Precio $")]
        [Required(ErrorMessage = "\"El campo {0} es obligatorio\"")]
        public decimal Price { get; set; }

        // se crea laas relacion con sus forenkey

        [Display(Name = "vehiculo")]
        public ICollection<Vehicle> Vehicles { get; set; }




    }
}

using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Sebas_lavadero.DAL.Entities
{
    public class VehicleDetail : Entity
    {
        [Display(Name = "Fecha de entrega")]
        public DateTime? DeliveryDate { get; set; }

        // se crea laas relacion con sus forenkey
        [Display(Name = "placa del vehiculo")]
        public Vehicle VechicleReg { get; set; }

    }
}


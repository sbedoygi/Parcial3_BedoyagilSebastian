using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Sebas_lavadero.DAL.Entities
{

    public class Vehicle : Entity
{

    [Display(Name = "id del servicio")]
    public Service ServiceReg { get; set; }

    [Display(Name = "ingrese el nombre del Dueño")]
    [MaxLength(100)]
    [Required(ErrorMessage = "\"El campo {0} es obligatorio\"")]
    public string Owner { get; set; }

    [Display(Name = "ingrese la Matrícula o placa ")]
    [MaxLength(100)]
    [Required(ErrorMessage = "\"El campo {0} es obligatorio\"")]
    public String? Plate { get; set; }

    // se crea laas relacion con sus forenkey

    [Display(Name = "Details")]
    public ICollection<VehicleDetail> VehicleDetails { get; set; }
}

}
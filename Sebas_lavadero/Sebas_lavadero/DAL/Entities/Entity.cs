using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Sebas_lavadero.DAL.Entities
{
    public class Entity
    {
        [Key]
        public virtual Guid Id { get; set; }

        [Display(Name = "fecha Creación")]
        public virtual DateTime? CreateDate { get; set; }

        [Display(Name = "fecha Modificación")]
        public virtual DateTime? ModifiedDate { get; set; }
    }



}


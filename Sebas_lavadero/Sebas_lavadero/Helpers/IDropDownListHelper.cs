using Microsoft.AspNetCore.Mvc.Rendering;

namespace Sebas_lavadero.Helpers
{
    public interface IDropDownListHelper
    {
        Task<IEnumerable<SelectListItem>> GetDDLServicesAsync();

    }
}

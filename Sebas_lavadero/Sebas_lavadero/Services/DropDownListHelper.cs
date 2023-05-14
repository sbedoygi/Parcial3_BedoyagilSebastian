using Microsoft.AspNetCore.Mvc.Rendering;
using Sebas_lavadero.DAL;
using Sebas_lavadero.Helpers;

namespace Sebas_lavadero.Services
{
    public class DropDownListHelper : IDropDownListHelper
    {
        public readonly DataBaseContext _context;
        public DropDownListHelper(DataBaseContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<SelectListItem>> GetDDLServicesAsync()
        {
            List<SelectListItem> listServices = await _context.Services
                .Select(s => new SelectListItem
                {
                    Text = s.Name,
                    Value = s.Id.ToString(),
                })
                .OrderBy(s => s.Text)
                .ToListAsync();

            listServices.Insert(0, new SelectListItem
            {
                Text = "Select the service...",
                Value = Guid.Empty.ToString(),
                Selected = true
            });

            return listServices;
        }
    }
}

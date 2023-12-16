using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VumbaSoft.AdventureWorksAbp.Demographics.StateProvinces;
using VumbaSoft.AdventureWorksAbp.Demographics.StateProvinces.Dtos;
using VumbaSoft.AdventureWorksAbp.Web.Pages.Demographics.StateProvinces.StateProvince.ViewModels;

namespace VumbaSoft.AdventureWorksAbp.Web.Pages.Demographics.StateProvinces.StateProvince;

public class CreateModalModel : AdventureWorksAbpPageModel
{
    [BindProperty]
    public CreateEditStateProvinceViewModel ViewModel { get; set; }

    private readonly IStateProvinceAppService _service;

    public CreateModalModel(IStateProvinceAppService service)
    {
        _service = service;
    }

    public virtual async Task<IActionResult> OnPostAsync()
    {
        var dto = ObjectMapper.Map<CreateEditStateProvinceViewModel, CreateUpdateStateProvinceDto>(ViewModel);
        await _service.CreateAsync(dto);
        return NoContent();
    }
}
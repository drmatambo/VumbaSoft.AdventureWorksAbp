using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VumbaSoft.AdventureWorksAbp.Demographics.Subcontinents;
using VumbaSoft.AdventureWorksAbp.Demographics.Subcontinents.Dtos;
using VumbaSoft.AdventureWorksAbp.Web.Pages.Demographics.Subcontinents.Subcontinent.ViewModels;

namespace VumbaSoft.AdventureWorksAbp.Web.Pages.Demographics.Subcontinents.Subcontinent;

public class CreateModalModel : AdventureWorksAbpPageModel
{
    [BindProperty]
    public CreateEditSubcontinentViewModel ViewModel { get; set; }

    private readonly ISubcontinentAppService _service;

    public CreateModalModel(ISubcontinentAppService service)
    {
        _service = service;
    }

    public virtual async Task<IActionResult> OnPostAsync()
    {
        var dto = ObjectMapper.Map<CreateEditSubcontinentViewModel, CreateUpdateSubcontinentDto>(ViewModel);
        await _service.CreateAsync(dto);
        return NoContent();
    }
}
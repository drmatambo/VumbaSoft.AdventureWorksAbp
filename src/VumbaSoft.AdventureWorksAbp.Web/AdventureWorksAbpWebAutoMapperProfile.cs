using VumbaSoft.AdventureWorksAbp.Demographics.Continents.Dtos;
using VumbaSoft.AdventureWorksAbp.Web.Pages.Demographics.Continents.Continent.ViewModels;
using VumbaSoft.AdventureWorksAbp.Demographics.Subcontinents.Dtos;
using VumbaSoft.AdventureWorksAbp.Web.Pages.Demographics.Subcontinents.Subcontinent.ViewModels;
using VumbaSoft.AdventureWorksAbp.Demographics.Countries.Dtos;
using VumbaSoft.AdventureWorksAbp.Web.Pages.Demographics.Countries.Country.ViewModels;
using VumbaSoft.AdventureWorksAbp.Demographics.Regions.Dtos;
using VumbaSoft.AdventureWorksAbp.Web.Pages.Demographics.Regions.Region.ViewModels;
using VumbaSoft.AdventureWorksAbp.Demographics.StateProvinces.Dtos;
using VumbaSoft.AdventureWorksAbp.Web.Pages.Demographics.StateProvinces.StateProvince.ViewModels;
using VumbaSoft.AdventureWorksAbp.Demographics.DistrictCities.Dtos;
using VumbaSoft.AdventureWorksAbp.Web.Pages.Demographics.DistrictCities.DistrictCity.ViewModels;
using VumbaSoft.AdventureWorksAbp.Demographics.Localities.Dtos;
using VumbaSoft.AdventureWorksAbp.Web.Pages.Demographics.Localities.Locality.ViewModels;
using AutoMapper;

namespace VumbaSoft.AdventureWorksAbp.Web;

public class AdventureWorksAbpWebAutoMapperProfile : Profile
{
    public AdventureWorksAbpWebAutoMapperProfile()
    {
        //Define your AutoMapper configuration here for the Web project.
        CreateMap<ContinentDto, CreateEditContinentViewModel>();
        CreateMap<CreateEditContinentViewModel, CreateUpdateContinentDto>();
        CreateMap<SubcontinentDto, CreateEditSubcontinentViewModel>();
        CreateMap<CreateEditSubcontinentViewModel, CreateUpdateSubcontinentDto>();
        CreateMap<CountryDto, CreateEditCountryViewModel>();
        CreateMap<CreateEditCountryViewModel, CreateUpdateCountryDto>();
        CreateMap<RegionDto, CreateEditRegionViewModel>();
        CreateMap<CreateEditRegionViewModel, CreateUpdateRegionDto>();
        CreateMap<StateProvinceDto, CreateEditStateProvinceViewModel>();
        CreateMap<CreateEditStateProvinceViewModel, CreateUpdateStateProvinceDto>();
        CreateMap<DistrictCityDto, CreateEditDistrictCityViewModel>();
        CreateMap<CreateEditDistrictCityViewModel, CreateUpdateDistrictCityDto>();
        CreateMap<LocalityDto, CreateEditLocalityViewModel>();
        CreateMap<CreateEditLocalityViewModel, CreateUpdateLocalityDto>();
    }
}

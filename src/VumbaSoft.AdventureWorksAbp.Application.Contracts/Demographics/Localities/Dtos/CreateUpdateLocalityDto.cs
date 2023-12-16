using System;

namespace VumbaSoft.AdventureWorksAbp.Demographics.Localities.Dtos;

[Serializable]
public class CreateUpdateLocalityDto
{
    public Guid ContinentID { get; set; }

    public Guid SubcontinentId { get; set; }

    public Guid CountryId { get; set; }

    public Guid RegionId { get; set; }

    public Guid StateProvinceId { get; set; }

    public Guid DistrictCityId { get; set; }

    public String Name { get; set; }

    public Int64 Population { get; set; }

    public String DistrictCityCode { get; set; }

    public String LocalityCode { get; set; }

    public Decimal Latitude { get; set; }

    public Decimal Longitude { get; set; }

    public String Remarks { get; set; }
}
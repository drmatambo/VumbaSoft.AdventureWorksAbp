using System;

namespace VumbaSoft.AdventureWorksAbp.Demographics.Regions.Dtos;

[Serializable]
public class CreateUpdateRegionDto
{
    public String Name { get; set; }

    public Int64 Population { get; set; }

    public Guid CountryId { get; set; }

    public String CountryCode { get; set; }

    public String RegionCode { get; set; }

    public String Remarks { get; set; }
}
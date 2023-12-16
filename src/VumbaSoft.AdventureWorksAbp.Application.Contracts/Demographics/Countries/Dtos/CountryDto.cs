using System;
using Volo.Abp.Application.Dtos;

namespace VumbaSoft.AdventureWorksAbp.Demographics.Countries.Dtos;

[Serializable]
public class CountryDto : FullAuditedEntityDto<Guid>
{
    public Guid ContinentID { get; set; }

    public Guid SubcontinentId { get; set; }

    public String Name { get; set; }

    public String FormalName { get; set; }

    public String NativeName { get; set; }

    public String IsoTreeCode { get; set; }

    public String IsoTwoCode { get; set; }

    public String CcnTreeCode { get; set; }

    public String PhoneCode { get; set; }

    public String Capital { get; set; }

    public String Currency { get; set; }

    public Int64 Population { get; set; }

    public String Emoji { get; set; }

    public String EmojiU { get; set; }

    public String Remarks { get; set; }
}
using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace VumbaSoft.AdventureWorksAbp.Demographics.Subcontinents;

public class Subcontinent : FullAuditedAggregateRoot<Guid>
{
    public virtual String Name { get; set; }
    public virtual Guid ContinentId { get; set; }
    public virtual Int64 Population { get; set; }
    //public virtual Continent Continent { get; set; } //Navigation property
    //public virtual ICollection<Country> Countries { get; set; }
    public virtual String Remarks { get; set; }


    protected Subcontinent()
    {
    }

    public Subcontinent(
        Guid id,
        String name,
        Guid continentId,
        Int64 population,
        String remarks
    ) : base(id)
    {
        Name = name;
        ContinentId = continentId;
        Population = population;
        Remarks = remarks;
    }
}


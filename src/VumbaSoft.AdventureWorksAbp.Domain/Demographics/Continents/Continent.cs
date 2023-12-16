using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace VumbaSoft.AdventureWorksAbp.Demographics.Continents;

public class Continent : FullAuditedAggregateRoot<Guid>
{
    public virtual String Name { get; set; }
    public virtual Int64 Population { get; set; }
    //public virtual virtual ICollection<Subcontinent> Subcontinents { get; set; }
    public virtual String Remarks { get; set; }

    protected Continent()
    {
    }

    public Continent(
        Guid id,
        String name,
        Int64 population,
        String remarks
    ) : base(id)
    {
        Name = name;
        Population = population;
        Remarks = remarks;
    }
}


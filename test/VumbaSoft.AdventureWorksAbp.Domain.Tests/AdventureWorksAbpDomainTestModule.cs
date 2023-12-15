using VumbaSoft.AdventureWorksAbp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace VumbaSoft.AdventureWorksAbp;

[DependsOn(
    typeof(AdventureWorksAbpEntityFrameworkCoreTestModule)
    )]
public class AdventureWorksAbpDomainTestModule : AbpModule
{

}

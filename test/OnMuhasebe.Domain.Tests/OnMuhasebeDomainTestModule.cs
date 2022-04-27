using OnMuhasebe.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace OnMuhasebe;

[DependsOn(
    typeof(OnMuhasebeEntityFrameworkCoreTestModule)
    )]
public class OnMuhasebeDomainTestModule : AbpModule
{

}

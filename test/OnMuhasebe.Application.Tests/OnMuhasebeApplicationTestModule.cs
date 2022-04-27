using Volo.Abp.Modularity;

namespace OnMuhasebe;

[DependsOn(
    typeof(OnMuhasebeApplicationModule),
    typeof(OnMuhasebeDomainTestModule)
    )]
public class OnMuhasebeApplicationTestModule : AbpModule
{

}

using OnMuhasebe.Localization;
using Volo.Abp.AspNetCore.Components;

namespace OnMuhasebe.Blazor;

public abstract class OnMuhasebeComponentBase : AbpComponentBase
{
    protected OnMuhasebeComponentBase()
    {
        LocalizationResource = typeof(OnMuhasebeResource);
    }
}

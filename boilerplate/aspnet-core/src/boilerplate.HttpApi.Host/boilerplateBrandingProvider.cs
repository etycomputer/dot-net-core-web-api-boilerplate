using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace boilerplate;

[Dependency(ReplaceServices = true)]
public class boilerplateBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "boilerplate";
}

using boilerplate.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace boilerplate.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class boilerplateController : AbpControllerBase
{
    protected boilerplateController()
    {
        LocalizationResource = typeof(boilerplateResource);
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using boilerplate.Localization;
using Volo.Abp.Application.Services;

namespace boilerplate;

/* Inherit your application services from this class.
 */
public abstract class boilerplateAppService : ApplicationService
{
    protected boilerplateAppService()
    {
        LocalizationResource = typeof(boilerplateResource);
    }
}

using AutoMapper;
using boilerplate.GlobalSettings;

namespace boilerplate;

public class boilerplateApplicationAutoMapperProfile : Profile
{
    public boilerplateApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
         CreateMap<GlobalSetting, GlobalSettingDto>();
         CreateMap<CreateUpdateGlobalSettingDto, GlobalSetting>();
    }
}

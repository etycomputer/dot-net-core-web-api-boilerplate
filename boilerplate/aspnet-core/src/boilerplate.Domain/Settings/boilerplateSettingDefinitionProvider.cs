using Volo.Abp.Settings;

namespace boilerplate.Settings;

public class boilerplateSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(boilerplateSettings.MySetting1));
    }
}

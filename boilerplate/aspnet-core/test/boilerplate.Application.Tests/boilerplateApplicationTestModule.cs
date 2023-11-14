using Volo.Abp.Modularity;

namespace boilerplate;

[DependsOn(
    typeof(boilerplateApplicationModule),
    typeof(boilerplateDomainTestModule)
    )]
public class boilerplateApplicationTestModule : AbpModule
{

}

using boilerplate.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace boilerplate;

[DependsOn(
    typeof(boilerplateEntityFrameworkCoreTestModule)
    )]
public class boilerplateDomainTestModule : AbpModule
{

}

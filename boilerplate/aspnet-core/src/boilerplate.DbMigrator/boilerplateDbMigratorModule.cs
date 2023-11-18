using boilerplate.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace boilerplate.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(boilerplateEntityFrameworkCoreModule),
    typeof(boilerplateApplicationContractsModule)
    )]
public class boilerplateDbMigratorModule : AbpModule
{
}

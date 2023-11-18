using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using boilerplate.Data;
using Volo.Abp.DependencyInjection;

namespace boilerplate.EntityFrameworkCore;

public class EntityFrameworkCoreboilerplateDbSchemaMigrator
    : IboilerplateDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreboilerplateDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the boilerplateDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<boilerplateDbContext>()
            .Database
            .MigrateAsync();
    }
}

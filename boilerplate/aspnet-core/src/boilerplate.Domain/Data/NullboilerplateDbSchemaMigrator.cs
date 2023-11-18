using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace boilerplate.Data;

/* This is used if database provider does't define
 * IboilerplateDbSchemaMigrator implementation.
 */
public class NullboilerplateDbSchemaMigrator : IboilerplateDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}

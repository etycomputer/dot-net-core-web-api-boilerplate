using System.Threading.Tasks;

namespace boilerplate.Data;

public interface IboilerplateDbSchemaMigrator
{
    Task MigrateAsync();
}

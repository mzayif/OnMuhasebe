using System.Threading.Tasks;

namespace OnMuhasebe.Data;

public interface IOnMuhasebeDbSchemaMigrator
{
    Task MigrateAsync();
}

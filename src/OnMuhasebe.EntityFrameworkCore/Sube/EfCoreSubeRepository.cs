using OnMuhasebe.Commons;
using OnMuhasebe.EntityFrameworkCore;
using OnMuhasebe.Subeler;
using Volo.Abp.EntityFrameworkCore;

namespace OnMuhasebe.Cariler;

public class EfCoreSubeRepository : EfCoreCommonRepository<Sube>, ISubeRepository
{
    public EfCoreSubeRepository(IDbContextProvider<OnMuhasebeDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
}
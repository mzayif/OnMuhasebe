using OnMuhasebe.Commons;
using OnMuhasebe.Depolar;
using OnMuhasebe.Donemler;
using OnMuhasebe.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace OnMuhasebe.Cariler;

public class EfCoreDonemRepository : EfCoreCommonRepository<Donem>, IDonemRepository
{
    public EfCoreDonemRepository(IDbContextProvider<OnMuhasebeDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
}
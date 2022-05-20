using OnMuhasebe.Commons;
using OnMuhasebe.Depolar;
using OnMuhasebe.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace OnMuhasebe.Cariler;

public class EfCoreDepoRepository : EfCoreCommonRepository<Depo>,IDepoRepository
{
    public EfCoreDepoRepository(IDbContextProvider<OnMuhasebeDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
}
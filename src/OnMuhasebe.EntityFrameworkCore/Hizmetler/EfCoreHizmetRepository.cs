using OnMuhasebe.Commons;
using OnMuhasebe.Depolar;
using OnMuhasebe.Donemler;
using OnMuhasebe.EntityFrameworkCore;
using OnMuhasebe.Faturalar;
using OnMuhasebe.Hizmetler;
using Volo.Abp.EntityFrameworkCore;

namespace OnMuhasebe.Cariler;

public class EfCoreHizmetRepository : EfCoreCommonRepository<Hizmet>, IHizmetRepository
{
    public EfCoreHizmetRepository(IDbContextProvider<OnMuhasebeDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
}
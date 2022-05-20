using OnMuhasebe.Commons;
using OnMuhasebe.Depolar;
using OnMuhasebe.Donemler;
using OnMuhasebe.EntityFrameworkCore;
using OnMuhasebe.Faturalar;
using Volo.Abp.EntityFrameworkCore;

namespace OnMuhasebe.Cariler;

public class EfCoreFaturaHareketRepository : EfCoreCommonRepository<FaturaHareket>, IFaturaHareketRepository
{
    public EfCoreFaturaHareketRepository(IDbContextProvider<OnMuhasebeDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
}
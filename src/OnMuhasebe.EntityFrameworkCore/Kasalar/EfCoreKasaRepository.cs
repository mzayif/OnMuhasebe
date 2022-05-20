using OnMuhasebe.Commons;
using OnMuhasebe.Depolar;
using OnMuhasebe.Donemler;
using OnMuhasebe.EntityFrameworkCore;
using OnMuhasebe.Faturalar;
using OnMuhasebe.Kasalar;
using Volo.Abp.EntityFrameworkCore;

namespace OnMuhasebe.Cariler;

public class EfCoreKasaRepository : EfCoreCommonRepository<Kasa>, IKasaRepository
{
    public EfCoreKasaRepository(IDbContextProvider<OnMuhasebeDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
}
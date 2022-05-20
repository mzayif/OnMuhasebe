using OnMuhasebe.Commons;
using OnMuhasebe.Depolar;
using OnMuhasebe.Donemler;
using OnMuhasebe.EntityFrameworkCore;
using OnMuhasebe.Faturalar;
using Volo.Abp.EntityFrameworkCore;

namespace OnMuhasebe.Cariler;

public class EfCoreFaturaRepository : EfCoreCommonRepository<Fatura>, IFaturaRepository
{
    public EfCoreFaturaRepository(IDbContextProvider<OnMuhasebeDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
}
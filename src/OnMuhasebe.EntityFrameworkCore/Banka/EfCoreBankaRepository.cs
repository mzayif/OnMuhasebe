using OnMuhasebe.Bankalar;
using OnMuhasebe.Commons;
using OnMuhasebe.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace OnMuhasebe.BankaHesaplar;

public class EfCoreBankaRepository:EfCoreCommonRepository<Banka>,IBankaRepository
{
    public EfCoreBankaRepository(IDbContextProvider<OnMuhasebeDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
}
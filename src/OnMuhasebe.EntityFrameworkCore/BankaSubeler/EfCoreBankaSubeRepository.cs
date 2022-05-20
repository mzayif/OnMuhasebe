using OnMuhasebe.BankaSubeler;
using OnMuhasebe.Commons;
using OnMuhasebe.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace OnMuhasebe.BankaHesaplar;

public class EfCoreBankaSubeRepository : EfCoreCommonRepository<BankaSube>,IBankaSubeRepository
{
    public EfCoreBankaSubeRepository(IDbContextProvider<OnMuhasebeDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
}
using OnMuhasebe.Commons;
using OnMuhasebe.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace OnMuhasebe.BankaHesaplar;

public class EfCoreBankaHesapRepository:EfCoreCommonRepository<BankaHesap>,IBankaHesapRepository
{
    public EfCoreBankaHesapRepository(IDbContextProvider<OnMuhasebeDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
}
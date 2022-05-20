using OnMuhasebe.BankaSubeler;
using OnMuhasebe.Commons;
using OnMuhasebe.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace OnMuhasebe.Birimler;

public class EfCoreBirimRepository : EfCoreCommonRepository<Birim>,IBirimRepository

{
    public EfCoreBirimRepository(IDbContextProvider<OnMuhasebeDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
}
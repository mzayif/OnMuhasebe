using OnMuhasebe.Commons;
using OnMuhasebe.EntityFrameworkCore;
using OnMuhasebe.Makbuzlar;
using OnMuhasebe.Masraflar;
using OnMuhasebe.OzelKodlar;
using OnMuhasebe.Parametreler;
using OnMuhasebe.Stoklar;
using Volo.Abp.EntityFrameworkCore;

namespace OnMuhasebe.Cariler;

public class EfCoreStokRepository : EfCoreCommonRepository<Stok>, IStokRepository
{
    public EfCoreStokRepository(IDbContextProvider<OnMuhasebeDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
}
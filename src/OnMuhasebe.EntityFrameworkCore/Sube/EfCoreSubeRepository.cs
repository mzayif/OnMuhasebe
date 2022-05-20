using OnMuhasebe.Commons;
using OnMuhasebe.EntityFrameworkCore;
using OnMuhasebe.Makbuzlar;
using OnMuhasebe.Masraflar;
using OnMuhasebe.OzelKodlar;
using OnMuhasebe.Parametreler;
using OnMuhasebe.Stoklar;
using OnMuhasebe.Subeler;
using Volo.Abp.EntityFrameworkCore;

namespace OnMuhasebe.Cariler;

public class EfCoreSubeRepository : EfCoreCommonRepository<Sube>, ISubeRepository
{
    public EfCoreSubeRepository(IDbContextProvider<OnMuhasebeDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
}
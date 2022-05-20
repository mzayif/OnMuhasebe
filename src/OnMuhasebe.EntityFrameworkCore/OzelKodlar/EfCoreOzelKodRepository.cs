using OnMuhasebe.Commons;
using OnMuhasebe.EntityFrameworkCore;
using OnMuhasebe.Makbuzlar;
using OnMuhasebe.Masraflar;
using OnMuhasebe.OzelKodlar;
using Volo.Abp.EntityFrameworkCore;

namespace OnMuhasebe.Cariler;

public class EfCoreOzelKodRepository : EfCoreCommonRepository<OzelKod>, IOzelKodRepository
{
    public EfCoreOzelKodRepository(IDbContextProvider<OnMuhasebeDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
}
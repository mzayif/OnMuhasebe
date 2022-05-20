using OnMuhasebe.Commons;
using OnMuhasebe.EntityFrameworkCore;
using OnMuhasebe.Makbuzlar;
using OnMuhasebe.Masraflar;
using OnMuhasebe.OzelKodlar;
using OnMuhasebe.Parametreler;
using Volo.Abp.EntityFrameworkCore;

namespace OnMuhasebe.Cariler;

public class EfCoreFirmaParametreRepository : EfCoreCommonRepository<FirmaParametre>, IFirmaParametreRepository
{
    public EfCoreFirmaParametreRepository(IDbContextProvider<OnMuhasebeDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
}
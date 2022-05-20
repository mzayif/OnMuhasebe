using OnMuhasebe.Commons;
using OnMuhasebe.EntityFrameworkCore;
using OnMuhasebe.Makbuzlar;
using Volo.Abp.EntityFrameworkCore;

namespace OnMuhasebe.Cariler;

public class EfCoreMakbuzRepository : EfCoreCommonRepository<Makbuz>, IMakbuzRepository
{
    public EfCoreMakbuzRepository(IDbContextProvider<OnMuhasebeDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
}
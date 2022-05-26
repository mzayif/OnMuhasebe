using OnMuhasebe.Services;

namespace OnMuhasebe.OzelKodlar;

public interface IOzelKodAppService : ICrudAppService<SelectOzelKodDto, ListOzelKodDto, IOzelKodAppService, CreateOzelKodDto, UpdateOzelKodDto, OzelKodCodeParameterDto>
{
    
}
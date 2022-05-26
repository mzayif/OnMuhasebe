using OnMuhasebe.CommonDtos;
using OnMuhasebe.Services;

namespace OnMuhasebe.Donemler;

public interface IDonemAppService : ICrudAppService<SelectDonemDto, ListDonemDto, DonemListParameterDto, CreateDonemDto, UpdateDonemDto, CodeParameterDto>
{
    
}
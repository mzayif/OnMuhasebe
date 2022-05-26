using OnMuhasebe.CommonDtos;
using OnMuhasebe.Services;

namespace OnMuhasebe.Subeler;

public interface ISubeAppService : ICrudAppService<SelectSubeDto, ListSubeDto, SubeListParameterDto, CreateSubeDto, UpdateSubeDto, CodeParameterDto>
{
    
}
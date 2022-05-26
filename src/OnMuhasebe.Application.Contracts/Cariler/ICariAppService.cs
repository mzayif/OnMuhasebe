using OnMuhasebe.CommonDtos;
using OnMuhasebe.Services;

namespace OnMuhasebe.Cariler;

public interface ICariAppService : ICrudAppService<SelectCariDto, ListCariDto, CariListParameterDto, CreateCariDto, UpdateCariDto, CodeParameterDto>
{
    
}
using OnMuhasebe.CommonDtos;
using OnMuhasebe.Services;

namespace OnMuhasebe.Hizmetler;

public interface IHizmetAppService : ICrudAppService<SelectHizmetDto, ListHizmetDto, HizmetListParameterDto, CreateHizmetDto, UpdateHizmetDto, CodeParameterDto>
{
    
}
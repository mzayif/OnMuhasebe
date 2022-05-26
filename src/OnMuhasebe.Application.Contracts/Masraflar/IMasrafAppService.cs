using OnMuhasebe.CommonDtos;
using OnMuhasebe.Services;

namespace OnMuhasebe.Masraflar;

public interface IMasrafAppService : ICrudAppService<SelectMasrafDto, ListMasrafDto, MasrafListParameterDto, CreateMasrafDto, UpdateMasrafDto, CodeParameterDto>
{
    
}
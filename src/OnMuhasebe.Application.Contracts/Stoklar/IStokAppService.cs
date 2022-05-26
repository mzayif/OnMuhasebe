using OnMuhasebe.CommonDtos;
using OnMuhasebe.Services;

namespace OnMuhasebe.Stoklar;

public interface IStokAppService : ICrudAppService<SelectStokDto, ListStokDto, StokListParameterDto, CreateStokDto, UpdateStokDto, CodeParameterDto>
{
    
}
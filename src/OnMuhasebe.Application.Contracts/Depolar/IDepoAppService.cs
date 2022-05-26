using OnMuhasebe.Services;

namespace OnMuhasebe.Depolar;

public interface IDepoAppService : ICrudAppService<SelectDepoDto, ListDepoDto, DepoListParameterDto, CreateDepoDto, UpdateDepoDto, DepoCodeParameterDto>
{
    
}
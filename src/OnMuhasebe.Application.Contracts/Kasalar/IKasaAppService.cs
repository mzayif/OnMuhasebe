using OnMuhasebe.Services;

namespace OnMuhasebe.Kasalar;

public interface IKasaAppService : ICrudAppService<SelectKasaDto, ListKasaDto, KasaListParameterDto, CreateKasaDto, UpdateKasaDto, KasaCodeParameterDto>
{
    
}
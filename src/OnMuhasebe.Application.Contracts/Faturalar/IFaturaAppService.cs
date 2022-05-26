using OnMuhasebe.Services;

namespace OnMuhasebe.Faturalar;

public interface IFaturaAppService : ICrudAppService<SelectFaturaDto, ListFaturaDto, FaturaListParameterDto, CreateFaturaDto, UpdateFaturaDto, FaturaNoParameterDto>
{
    
}
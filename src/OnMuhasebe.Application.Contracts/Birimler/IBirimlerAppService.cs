using OnMuhasebe.CommonDtos;
using OnMuhasebe.Services;

namespace OnMuhasebe.Birimler;

public interface IBirimlerAppService : ICrudAppService<SelectBirimDto, ListBirimDto, BirimListParameterDto, CreateBirimDto, UpdateBirimDto, CodeParameterDto>
{

}
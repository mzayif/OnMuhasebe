using OnMuhasebe.CommonDtos;
using OnMuhasebe.Services;

namespace OnMuhasebe.Bankalar;

public interface IBankaAppService : ICrudAppService<SelectBankaDto, ListBankaDto, BankaListParameterDto, CreateBankaDto, UpdateBankaDto, CodeParameterDto>
{

}
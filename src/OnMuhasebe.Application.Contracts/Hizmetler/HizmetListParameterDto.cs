using OnMuhasebe.CommonDtos;
using Volo.Abp.Application.Dtos;

namespace OnMuhasebe.Hizmetler;

public class HizmetListParameterDto : PagedResultRequestDto, IDurum, IEntityDto
{
    public bool Durum { get; set; }
}
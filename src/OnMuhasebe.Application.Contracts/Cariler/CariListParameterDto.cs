using OnMuhasebe.CommonDtos;
using Volo.Abp.Application.Dtos;

namespace OnMuhasebe.Cariler;

public class CariListParameterDto : PagedResultRequestDto, IDurum, IEntityDto
{
    public bool Durum { get; set; }
}
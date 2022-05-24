using OnMuhasebe.CommonDtos;
using Volo.Abp.Application.Dtos;

namespace OnMuhasebe.Subeler;

public class SubeListParameterDto : PagedResultRequestDto, IDurum, IEntityDto
{
    public bool Durum { get; set; }
}
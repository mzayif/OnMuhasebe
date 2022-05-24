using OnMuhasebe.CommonDtos;
using Volo.Abp.Application.Dtos;

namespace OnMuhasebe.Bankalar;

public class BankaListParameterDto : PagedResultRequestDto, IDurum, IEntityDto
{
    public bool Durum { get; set; }
}
using OnMuhasebe.CommonDtos;
using Volo.Abp.Application.Dtos;

namespace OnMuhasebe.Masraflar;

public class MasrafListParameterDto : PagedResultRequestDto, IDurum, IEntityDto
{
    public bool Durum { get; set; }
}
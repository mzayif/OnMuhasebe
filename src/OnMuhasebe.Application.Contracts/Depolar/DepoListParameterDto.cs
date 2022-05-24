using System;
using OnMuhasebe.CommonDtos;
using Volo.Abp.Application.Dtos;

namespace OnMuhasebe.Depolar;

public class DepoListParameterDto : PagedResultRequestDto, IDurum, IEntityDto
{
    public Guid? SubeId { get; set; }
    public bool Durum { get; set; }

}
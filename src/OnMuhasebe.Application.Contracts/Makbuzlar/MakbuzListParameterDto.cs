using System;
using OnMuhasebe.CommonDtos;
using Volo.Abp.Application.Dtos;

namespace OnMuhasebe.Makbuzlar;

public class MakbuzListParameterDto : PagedResultRequestDto, IDurum, IEntityDto
{
    public MakbuzTuru MakbuzTuru { get; set; }
    public Guid SubeId { get; set; }
    public Guid DonemId { get; set; }
    public bool Durum { get; set; }

}
using System;
using OnMuhasebe.CommonDtos;
using Volo.Abp.Application.Dtos;

namespace OnMuhasebe.BankaSubeler;

public class BankaSubeCodeParameterDto : IDurum, IEntityDto
{
    public Guid BankaId { get; set; }
    public bool Durum { get; set; }
}
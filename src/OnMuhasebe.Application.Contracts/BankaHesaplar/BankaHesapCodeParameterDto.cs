using System;
using OnMuhasebe.CommonDtos;
using Volo.Abp.Application.Dtos;

namespace OnMuhasebe.BankaHesaplar;

public class BankaHesapCodeParameterDto : IEntityDto, IDurum
{
    public Guid SubeId { get; set; }
    public bool Durum { get; set; }
}
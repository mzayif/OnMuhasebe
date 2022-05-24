using System;
using OnMuhasebe.CommonDtos;
using Volo.Abp.Application.Dtos;

namespace OnMuhasebe.Bankalar;

public class SelectBankaDto : EntityDto<Guid>,IOzelKod
{
    public string Kod { get; set; }
    public string Ad { get; set; }
    public Guid? OzelKod1Id { get; set; }
    public string OzelKod1Adi { get; set; }
    public Guid? OzelKod2Id { get; set; }
    public string OzelKod2Adi { get; set; }
    public string Aciklama { get; set; }
}
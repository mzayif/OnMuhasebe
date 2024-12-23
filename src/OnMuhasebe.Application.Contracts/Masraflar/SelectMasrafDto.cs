﻿using System;
using OnMuhasebe.CommonDtos;
using Volo.Abp.Application.Dtos;

namespace OnMuhasebe.Masraflar;

public class SelectMasrafDto : EntityDto<Guid>, IOzelKod
{
    public string Kod { get; set; }
    public string Ad { get; set; }
    public int KdvOrani { get; set; }
    public decimal BirimFiyati { get; set; }
    public string Barkod { get; set; }
    public Guid BirimId { get; set; }
    public string BirimAdi { get; set; }
    public Guid? OzelKod1Id { get; set; }
    public string OzelKod1Adi { get; set; }
    public Guid? OzelKod2Id { get; set; }
    public string OzelKod2Adi { get; set; }
    public string Aciklama { get; set; }
    public bool Durum { get; set; }
}
﻿using System;
using Volo.Abp.Application.Dtos;

namespace OnMuhasebe.Hizmetler;

public class ListHizmetDto : EntityDto<Guid>
{
    public string Kod { get; set; }
    public string Ad { get; set; }
    public int KdvOrani { get; set; }
    public decimal BirimFiyati { get; set; }
    public string Barkod { get; set; }
    public string BirimAdi { get; set; }
    public string OzelKod1Adi { get; set; }
    public string OzelKod2Adi { get; set; }
    public decimal Giren { get; set; }
    public decimal Cikan { get; set; }
    public string Aciklama { get; set; }
}
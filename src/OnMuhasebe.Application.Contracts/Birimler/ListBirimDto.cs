﻿using System;
using Volo.Abp.Application.Dtos;

namespace OnMuhasebe.Birimler;

public class ListBirimDto : EntityDto<Guid>
{
    public string Kod { get; set; }
    public string Ad { get; set; }
    public string OzelKod1Adi { get; set; }
    public string OzelKod2Adi { get; set; }
    public string Aciklama { get; set; }
}
using System;
using System.Collections.Generic;
using Volo.Abp.Application.Dtos;

namespace OnMuhasebe.Faturalar;

public class UpdateFaturaDto : IEntityDto
{
    public string FaturaNo { get; set; }
    public DateTime Tarih { get; set; }
    public decimal? BrutTutar { get; set; }
    public decimal? IndirimTutar { get; set; }
    public decimal? KdvHaricTutar { get; set; }
    public decimal? KdvTutar { get; set; }
    public decimal? NetTutar { get; set; }
    public int? HareketSayisi { get; set; }
    public Guid? CariId { get; set; }
    public Guid? OzelKod1Id { get; set; }
    public Guid? OzelKod2Id { get; set; }
    public string Aciklama { get; set; }
    public bool Durum { get; set; }
    public List<FatruraHareketDto> FatruraHareketler { get; set; }

}
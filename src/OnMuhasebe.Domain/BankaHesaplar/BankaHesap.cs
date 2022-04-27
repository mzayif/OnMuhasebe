
// ReSharper disable UnusedMember.Global

// ReSharper disable IdentifierTypo
namespace OnMuhasebe.BankaHesaplar;

public class BankaHesap:FullAuditedAggregateRoot<Guid>
{
    public string Kod { get; set; }
    public string Ad { get; set; }
    public BankaHesapTuru BankaHesapTuru { get; set; }
    public string HesapNo { get; set; }
    public string IbanNo { get; set; }
    public Guid BankaSubeId { get; set; }
    public Guid? OzelKod1Id { get; set; }
    public Guid? OzelKod2Id { get; set; }
    public Guid SubeId { get; set; }
    public string Aciklama { get; set; }
    public bool Durum { get; set; }
}
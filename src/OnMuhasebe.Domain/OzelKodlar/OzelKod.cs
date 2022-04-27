// ReSharper disable UnusedMember.Global
// ReSharper disable IdentifierTypo

namespace OnMuhasebe.OzelKodlar;

public class OzelKod : FullAuditedAggregateRoot<Guid>
{
    public string Kod { get; set; }
    public string Ad { get; set; }
    public OzelKodTuru KodTuru { get; set; }
    public KartTuru KartTuru { get; set; }
    public string Aciklama { get; set; }
    public bool Durum { get; set; }
}
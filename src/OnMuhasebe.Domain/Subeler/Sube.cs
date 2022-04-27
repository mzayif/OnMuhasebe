// ReSharper disable UnusedMember.Global
// ReSharper disable IdentifierTypo

namespace OnMuhasebe.Subeler;

public class Sube : FullAuditedAggregateRoot<Guid>
{
    public string Kod { get; set; }
    public string Ad { get; set; }
    public string Aciklama { get; set; }
    public bool Durum { get; set; }
}
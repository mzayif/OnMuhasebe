// ReSharper disable UnusedMember.Global
// ReSharper disable IdentifierTypo
namespace OnMuhasebe.Donemler;

public class Donem : FullAuditedAggregateRoot<Guid>
{
    public string Kod { get; set; }
    public string Ad { get; set; }
    public string Aciklama { get; set; }
    public bool Durum { get; set; }

    public ICollection<Fatura> Faturalar { get; set; }
    public ICollection<Makbuz> Makbuzlar { get; set; }
    public ICollection<FirmaParametre> FirmaParametreler { get; set; }
}
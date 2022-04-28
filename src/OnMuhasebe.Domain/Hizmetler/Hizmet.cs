// ReSharper disable UnusedMember.Global
// ReSharper disable IdentifierTypo

namespace OnMuhasebe.Hizmetler;

public class Hizmet : FullAuditedAggregateRoot<Guid>
{
    public string Kod { get; set; }
    public string Ad { get; set; }
    public int KdvOrani { get; set; }
    public decimal BirimFiyati { get; set; }
    public string Barkod { get; set; }
    public Guid BirimId { get; set; }
    public Guid? OzelKod1Id { get; set; }
    public Guid? OzelKod2Id { get; set; }
    public string Aciklama { get; set; }
    public bool Durum { get; set; }


    public Birim Birim { get; set; }
    public OzelKod OzelKod1 { get; set; }
    public OzelKod OzelKod2 { get; set; }
    public ICollection<FaturaHareket> FaturaHareketler { get; set; }
}
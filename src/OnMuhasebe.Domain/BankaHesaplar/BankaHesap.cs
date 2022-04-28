
// ReSharper disable UnusedMember.Global

// ReSharper disable IdentifierTypo




namespace OnMuhasebe.BankaHesaplar;

public class BankaHesap : FullAuditedAggregateRoot<Guid>
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


    public BankaSube BankaSubeler { get; set; }
    public OzelKod OzelKod1 { get; set; }
    public OzelKod OzelKod2 { get; set; }
    public Sube Sube { get; set; }

    public ICollection<Makbuz> Makbuzlar { get; set; }
    public ICollection<MakbuzHareket> MakbuzHareketler { get; set; }

}
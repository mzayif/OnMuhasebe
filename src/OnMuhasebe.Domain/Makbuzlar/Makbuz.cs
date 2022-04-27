// ReSharper disable UnusedMember.Global
// ReSharper disable IdentifierTypo

namespace OnMuhasebe.Makbuzlar;

public class Makbuz : FullAuditedAggregateRoot<Guid>
{
    public MakbuzTuru MakbuzTuru { get; set; }
    public string MakbuzNo { get; set; }
    public DateTime Tarih { get; set; }
    public Guid? CariId { get; set; }
    public Guid? KasaId { get; set; }
    public Guid? BankaHesapId { get; set; }
    public int HareketSayisi { get; set; }
    public decimal CekToplam { get; set; }
    public decimal SenetToplam { get; set; }
    public decimal PosToplam { get; set; }
    public decimal NakitToplam { get; set; }
    public decimal BankaToplam { get; set; }
    public Guid? OzelKod1Id { get; set; }
    public Guid? OzelKod2Id { get; set; }
    public Guid SubeId { get; set; }
    public Guid DonemId { get; set; }
    public string Aciklama { get; set; }
    public bool Durum { get; set; }
}
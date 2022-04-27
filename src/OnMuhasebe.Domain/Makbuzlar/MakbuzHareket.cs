// ReSharper disable UnusedMember.Global
// ReSharper disable IdentifierTypo
namespace OnMuhasebe.Makbuzlar;

public class MakbuzHareket : FullAuditedEntity<Guid>
{
    public Guid MakbuzId { get; set; }
    public OdemeTuru OdemeTuru { get; set; }
    public string TakipNo { get; set; }
    public Guid? CekBankaId { get; set; }
    public Guid? CekBankaSubeId { get; set; }
    public string CekHesapNo { get; set; }
    public string BelgeNo { get; set; }
    public DateTime Vade { get; set; }
    public string AsilBorcu { get; set; }
    public string Ciranta { get; set; }
    public Guid? KasaId { get; set; }
    public Guid? BankaHesapId { get; set; }
    public decimal Tutar { get; set; }
    public BelgeDurumu BelgeDurumu { get; set; }
    public bool KendiBelgemiz { get; set; }
    public string Aciklama { get; set; }
}
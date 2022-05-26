using System.Linq;
using System.Threading.Tasks;
using OnMuhasebe.Extensions;
using Volo.Abp.Domain.Services;

namespace OnMuhasebe.BankaSubeler;

public class BankaSubeManager : DomainService
{
    private readonly IBankaSubeRepository _bankaSubeRepository;
    private readonly IBankaRepository _bankaRepository;
    private readonly IOzelKodRepository _ozelKodRepository;

    public BankaSubeManager(IBankaSubeRepository bankaSubeRepository, IOzelKodRepository ozelKodRepository, IBankaRepository bankaRepository)
    {
        _bankaSubeRepository = bankaSubeRepository;
        _ozelKodRepository = ozelKodRepository;
        _bankaRepository = bankaRepository;
    }

    /// <summary>
    /// Bir Banka Şubesi kaydetmeden önce gelen verinin kayda uygun olup olmadığını kontrol eder
    /// </summary>
    /// <param name="kod"></param>
    /// <param name="bankaId"></param>
    /// <param name="ozelKod1Id"></param>
    /// <param name="ozelKod2Id"></param>
    /// <returns></returns>
    public async Task CheckCreateAsync(string kod, Guid? bankaId, Guid? ozelKod1Id, Guid? ozelKod2Id)
    {
        await _bankaRepository.EntityAnyAsync(bankaId, x => x.Id == bankaId);
        await _bankaSubeRepository.KodAnyAsync(kod, x => x.Kod == kod && x.BankaId == bankaId);
        await _ozelKodRepository.EntityAnyAsync(ozelKod1Id, OzelKodTuru.OzelKod1, KartTuru.BankaSube);
        await _ozelKodRepository.EntityAnyAsync(ozelKod2Id, OzelKodTuru.OzelKod2, KartTuru.BankaSube);
    }

    /// <summary>
    /// Bir Banka Şubesi Güncellemeden önce gelen verinin kayda uygun olup olmadığını kontrol eder
    /// </summary>
    /// <param name="id"></param>
    /// <param name="kod"></param>
    /// <param name="entity"></param>
    /// <param name="ozelKod1Id"></param>
    /// <param name="ozelKod2Id"></param>
    /// <returns></returns>
    public async Task CheckUpdateAsync(Guid id, string kod, BankaSube entity, Guid? ozelKod1Id, Guid? ozelKod2Id)
    {
        await _bankaSubeRepository.KodAnyAsync(kod, x => x.Kod == kod && x.Id != id && x.BankaId == entity.BankaId, entity.Kod != kod);
        await _ozelKodRepository.EntityAnyAsync(ozelKod1Id, OzelKodTuru.OzelKod1, KartTuru.BankaSube, entity.OzelKod1Id != ozelKod1Id);
        await _ozelKodRepository.EntityAnyAsync(ozelKod2Id, OzelKodTuru.OzelKod2, KartTuru.BankaSube, entity.OzelKod2Id != ozelKod2Id);
    }

    /// <summary>
    /// Bir Banka Şubesi İptal etmeden önce kaydın iptale uygun olup olmadığını kontrol eder
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public async Task CheckDeleteAsync(Guid id)
    {
        await _bankaSubeRepository.RelationalEntityAnyAsync(x => x.BankaHesaplar.Any(y => y.BankaSubeId == id) || x.MakbuzHareketler.Any(y => y.CekBankaId == id));
    }
}
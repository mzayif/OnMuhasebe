using OnMuhasebe.Services;

namespace OnMuhasebe.BankaHesaplar;

public interface IBankaHesapAppService : ICrudAppService<SelectBankaHesapDto, ListBankaHesapDto, BankaHesapListParameterDto, CreateBankaHesapDto, UpdateBankaHesapDto, BankaHesapCodeParameterDto>
{

}
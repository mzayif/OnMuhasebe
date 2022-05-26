using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Repositories;

namespace OnMuhasebe.BankaSubeler;

public class BankaSubeAppService : OnMuhasebeAppService, IBankaSubeAppService
{
    private readonly IBankaSubeRepository _repository;
    private readonly BankaSubeManager _bankaSubeManager;

    public BankaSubeAppService(IBankaSubeRepository repository, BankaSubeManager bankaSubeManager)
    {
        _repository = repository;
        _bankaSubeManager = bankaSubeManager;
    }
    
    public virtual async Task<SelectBankaSubeDto> CreateAsync(CreateBankaSubeDto input)
    {
        await _bankaSubeManager.CheckCreateAsync(input.Kod, input.BankaId, input.OzelKod1Id, input.OzelKod2Id);

        var entity = ObjectMapper.Map<CreateBankaSubeDto, BankaSube>(input);
        await _repository.InsertAsync(entity);
        return ObjectMapper.Map<BankaSube, SelectBankaSubeDto>(entity);
    }

    public virtual async Task<SelectBankaSubeDto> UpdateAsync(Guid id, UpdateBankaSubeDto input)
    {
        var entity = await _repository.GetAsync(id, x => x.Id == id);

        await _bankaSubeManager.CheckUpdateAsync(id, input.Kod, entity, input.OzelKod1Id, input.OzelKod2Id);

        var mappedEntity = ObjectMapper.Map(input, entity);
        await _repository.UpdateAsync(mappedEntity);

        return ObjectMapper.Map<BankaSube, SelectBankaSubeDto>(mappedEntity);
    }

    public virtual async Task DeleteAsync(Guid id)
    {
        await _bankaSubeManager.CheckDeleteAsync(id);
        await _repository.DeleteAsync(id);
    }

    public virtual async Task<SelectBankaSubeDto> GetAsync(Guid id)
    {
        var entity = await _repository.GetAsync(id, x => x.Id == id, x => x.OzelKod1, x => x.OzelKod2);
        return ObjectMapper.Map<BankaSube, SelectBankaSubeDto>(entity);
    }

    public virtual async Task<PagedResultDto<ListBankaSubeDto>> GetListAsync(BankaSubeListParameterDto input)
    {
        var entities = await _repository.GetPagedListAsync(input.SkipCount, input.MaxResultCount,
            x => x.BankaId == input.BankaId && x.Durum == input.Durum, x => x.Banka, x => x.OzelKod1, x => x.OzelKod2);

        var totalCount = await _repository.CountAsync(x => x.BankaId == input.BankaId && x.Durum == input.Durum);
        return new PagedResultDto<ListBankaSubeDto>(totalCount, ObjectMapper.Map<List<BankaSube>, List<ListBankaSubeDto>>(entities));
    }

    public virtual async Task<string> GetCodeAsync(BankaSubeCodeParameterDto input)
    {
        return await _repository.GetCodeAsync(x => x.Kod, x => x.Durum == input.Durum);
    }
}
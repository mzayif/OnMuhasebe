using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OnMuhasebe.CommonDtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Repositories;

namespace OnMuhasebe.Bankalar;

public class BankaAppService : OnMuhasebeAppService, IBankaAppService
{
    private readonly IBankaRepository _repository;
    private readonly BankaManager _bankaManager;

    public BankaAppService(IBankaRepository repository, BankaManager bankaManager)
    {
        _repository = repository;
        _bankaManager = bankaManager;
    }

    public virtual async Task<SelectBankaDto> CreateAsync(CreateBankaDto input)
    {
        await _bankaManager.CheckCreateAsync(input.Kod, input.OzelKod1Id, input.OzelKod2Id);

        var entity = ObjectMapper.Map<CreateBankaDto, Banka>(input);
        await _repository.InsertAsync(entity);
        return ObjectMapper.Map<Banka, SelectBankaDto>(entity);
    }

    public virtual async Task<SelectBankaDto> UpdateAsync(Guid id, UpdateBankaDto input)
    {
        var entity = await _repository.GetAsync(id, x => x.Id == id);

        await _bankaManager.CheckUpdateAsync(id, input.Kod, entity, input.OzelKod1Id, input.OzelKod2Id);

        var mappedEntity = ObjectMapper.Map(input, entity);
        await _repository.UpdateAsync(mappedEntity);

        return ObjectMapper.Map<Banka, SelectBankaDto>(mappedEntity);
    }

    public virtual async Task DeleteAsync(Guid id)
    {
        await _bankaManager.CheckDeleteAsync(id);
        await _repository.DeleteAsync(id);
    }


    public virtual async Task<SelectBankaDto> GetAsync(Guid id)
    {
        var entity = await _repository.GetAsync(id, x => x.Id == id, x => x.OzelKod1, x => x.OzelKod2);
        return ObjectMapper.Map<Banka, SelectBankaDto>(entity);
    }

    public virtual async Task<PagedResultDto<ListBankaDto>> GetListAsync(BankaListParameterDto input)
    {
        var entities = await _repository.GetPagedListAsync(input.SkipCount, input.MaxResultCount,
            x => x.Durum == input.Durum,
            x => x.Kod,
            x => x.OzelKod1, x => x.OzelKod2);

        var totalCount = await _repository.CountAsync(x => x.Durum == input.Durum);
        return new PagedResultDto<ListBankaDto>(totalCount, ObjectMapper.Map<List<Banka>, List<ListBankaDto>>(entities));
    }

    public virtual async Task<string> GetCodeAsync(CodeParameterDto input)
    {
        return await _repository.GetCodeAsync(x => x.Kod, x => x.Durum == input.Durum);
    }
}
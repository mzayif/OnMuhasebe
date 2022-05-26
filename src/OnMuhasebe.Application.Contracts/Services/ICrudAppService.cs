using System;
using Volo.Abp.Application.Services;

namespace OnMuhasebe.Services;

public interface ICrudAppService<TGetOutPutDto, TGetListOutPutDto, in TGetListInput, in TCreateInput, in TUpdateInput> :
    IReadOnlyAppService<TGetOutPutDto, TGetListOutPutDto, Guid, TGetListInput>,
    ICreateAppService<TGetOutPutDto, TCreateInput>,
    IUpdateAppService<TGetOutPutDto, Guid, TUpdateInput>
{

}
public interface ICrudAppService<TGetOutPutDto, TGetListOutPutDto, in TGetListInput, in TCreateInput, in TUpdateInput, in TGetCodeInput> :
    ICrudAppService<TGetOutPutDto, TGetListOutPutDto, TGetListInput, TCreateInput, TUpdateInput>,
    IDeleteAppService<Guid>,
    ICodeAppService<TGetCodeInput>
{

}
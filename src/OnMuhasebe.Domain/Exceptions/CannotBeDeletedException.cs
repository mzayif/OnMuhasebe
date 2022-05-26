using Volo.Abp;

namespace OnMuhasebe.Exceptions;

public class CannotBeDeletedException : BusinessException
{
    public CannotBeDeletedException() : base(OnMuhasebeDomainErrorCodes.CannotBeDeleted)
    {
    }
}
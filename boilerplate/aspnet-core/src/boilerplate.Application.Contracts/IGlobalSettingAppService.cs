using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
namespace boilerplate.GlobalSettings
{
    public interface IGlobalSettingAppService: IApplicationService
    {
                Task<PagedResultDto<GlobalSettingDto>> GetListAsync(
                    PagedAndSortedResultRequestDto input
                );
    }
}
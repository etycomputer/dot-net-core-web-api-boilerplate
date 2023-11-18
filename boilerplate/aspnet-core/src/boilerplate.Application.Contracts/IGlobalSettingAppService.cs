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
        Task CreateAsync(CreateUpdateGlobalSettingDto input);
        Task<GlobalSettingDto> GetAsync(long id);
        Task<GlobalSettingDto> GetByKeyNameAsync(string keyName);
        //Task UpdateAsync(long id, CreateUpdateGlobalSettingDto input);
    }
}
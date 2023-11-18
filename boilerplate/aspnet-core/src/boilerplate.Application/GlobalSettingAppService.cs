using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.OpenIddict;

namespace boilerplate.GlobalSettings
{
    public class GlobalSettingAppService :
        boilerplateAppService, IGlobalSettingAppService

    {
        private readonly IRepository<GlobalSetting, long> _globalsettingRepository;

        public GlobalSettingAppService(IRepository<GlobalSetting, long> globalsettingRepository)
        {
            _globalsettingRepository = globalsettingRepository;
        }

        public async Task CreateAsync(CreateUpdateGlobalSettingDto input)
        {
            await _globalsettingRepository.InsertAsync(
                ObjectMapper.Map<CreateUpdateGlobalSettingDto, GlobalSetting>(input));
            //throw new System.NotImplementedException();
        }

        public async Task<GlobalSettingDto> GetAsync(long id)
        {
            var gs = await _globalsettingRepository.GetAsync(id);
            return ObjectMapper.Map<GlobalSetting, GlobalSettingDto>(gs);
            //throw new System.NotImplementedException();
        }

        public async Task<GlobalSettingDto> GetByKeyNameAsync(string keyName)
        {
            var query = await _globalsettingRepository.WithDetailsAsync();
            var parameter = query
                .OrderByDescending(c => c.Id)
                .Where(c => c.key_name == keyName)
                .First();
            return ObjectMapper.Map<GlobalSetting, GlobalSettingDto>(parameter);
            //throw new System.NotImplementedException();
        }

        public async Task<PagedResultDto<GlobalSettingDto>> GetListAsync(PagedAndSortedResultRequestDto input)
        {
            //var query = await _globalsettingRepository.GetListAsync();
            var query = await _globalsettingRepository.WithDetailsAsync();

            var xx = query.Skip(input.SkipCount)
                         .Take(input.MaxResultCount)
                         .OrderByDescending(c=>c.Id).ToList()
                         .GroupBy(c=>c.key_name)
                         .Select( g => g.First());
                         //.OrderBy(input.Sorting ?? nameof(GlobalSetting.group_name));
            // var gs = await AsyncExecuter.ToListAsync(xx.);
            var count = xx.Count();

            return new PagedResultDto<GlobalSettingDto>(
                count,
                ObjectMapper.Map<List<GlobalSetting>, List<GlobalSettingDto>>
                (xx.ToList())
            );
        }

        // public async Task UpdateAsync(long id, CreateUpdateGlobalSettingDto input)
        // {
        //     var gs = await _globalsettingRepository.GetAsync(id);
        //     ObjectMapper.Map(input, gs);
        // }
    }
}
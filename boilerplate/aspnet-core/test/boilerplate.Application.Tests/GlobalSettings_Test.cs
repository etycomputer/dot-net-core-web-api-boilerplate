using System.Threading.Tasks;
using Shouldly;
using Volo.Abp.Application.Dtos;
using Xunit;

namespace boilerplate.GlobalSettings
{
    public class GlobalSettings_Test : boilerplateApplicationTestBase
    {
        private readonly IGlobalSettingAppService _globalsettingRepository;

        public GlobalSettings_Test()
        {
            _globalsettingRepository = GetRequiredService<IGlobalSettingAppService>();
        }

        [Fact]
        public async Task Should_Get_GlobalSettings_List()
        {
            var output = await _globalsettingRepository.GetListAsync(
                new PagedAndSortedResultRequestDto()
            );

            output.TotalCount.ShouldBe(1);
            output.Items.ShouldContain(
                x => x.key_name.Contains("schema_version")
            );

        }
    }
}
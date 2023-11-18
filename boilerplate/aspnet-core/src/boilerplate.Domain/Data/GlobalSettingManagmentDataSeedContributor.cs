using System.Threading.Tasks;
using boilerplate.GlobalSettings;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Uow;

namespace boilerplate.Data
{
    public class globalSettingManagmentDataSeedContributor :
        IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<GlobalSetting, long> _globalSettingRep;

        public globalSettingManagmentDataSeedContributor(IRepository<GlobalSetting, long> globalSettingRep)
        {
            _globalSettingRep = globalSettingRep;
        }

        [UnitOfWork]
        public async Task SeedAsync(DataSeedContext context)
        {
            //throw new System.NotImplementedException();
            if(await _globalSettingRep.CountAsync() == 0){
                var gs = new GlobalSetting(){
                    group_name = "registry",
                    key_name = "schema_version",
                    key_value = "1.6.2023",
                    
                    comments = "Database created using Init script"
                };
                await _globalSettingRep.InsertAsync(gs);
            }
            return ;
        }
    }
}
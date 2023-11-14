using Volo.Abp.Application.Dtos;

namespace boilerplate.GlobalSettings
{
    public class GlobalSettingDto: AuditedEntityDto<long>
    {
        public string group_name { get; set; } 
        public string key_name { get; set; } 
        public string key_value { get; set; } 
        public string comments { get; set; } 
        // [Timestamp]
        public byte[] timestamp  { get; set; }
    }
    
}
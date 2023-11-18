
using Volo.Abp.Domain.Entities.Auditing;

namespace boilerplate.GlobalSettings
{
    public class GlobalSetting: FullAuditedAggregateRoot<long>
    {
        public string group_name { get; set; } 
        public string key_name { get; set; } 
        public string key_value { get; set; } 
        public string comments { get; set; } 
        // [Timestamp]
        //public byte[] timestamp  { get; set; } 
        // group_name TEXT NOT NULL CONSTRAINT group_length CHECK (char_length(group_name) > 0),
        // key_name TEXT NOT NULL CONSTRAINT key_length CHECK (char_length(key_name) > 0),
        // key_value TEXT,
        // timestamp TIMESTAMPTZ,
        // comments TEXT,
    }
}
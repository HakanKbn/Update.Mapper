using System.Diagnostics.CodeAnalysis;

namespace Update.Mapper.Model
{
    public class Referans
    {
        public string kod { get; set; }
        public  int  tipId { get; set; }
        public Guid? tenantId { get; set; }
        public Guid? deneme { get; set; }
    }
}

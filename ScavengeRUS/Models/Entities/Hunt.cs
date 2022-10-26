using System.ComponentModel;

namespace ScavengeRUS.Models.Entities
{
    public class Hunt
    {
        public int Id { get; set; }
        [DisplayName("Hunt URL")]
        public string? HuntUrl { get; set; }
    }
}

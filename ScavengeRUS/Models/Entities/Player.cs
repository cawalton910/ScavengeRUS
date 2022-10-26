using System.ComponentModel;

namespace ScavengeRUS.Models.Entities
{
    public class Player
    {
        public int Id { get; set; }
        [DisplayName("First Name")]
        public string? FirstName { get; set; }
        [DisplayName("Last Name")]
        public string? LastName { get; set; }
    }
}

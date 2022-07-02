using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TestArchitecture.API
{
    [Description("Test")]
    public class User
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [Range(1, 100)]
        public int Age { get; set; }
    }
}

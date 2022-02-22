using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EES.Database.Entities
{
    public class MstBelong : CommonEntity
    {
        [Required]
        [Column("code")]
        public string Code { get; set; }

        [Required]
        [Column("name")]
        public string Name { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EES.Database.Entities
{
    public class CommonEntity
    {
        [Column("id")]
        public int ID { get; set; }

        [Required]
        [Column("create_uid")]
        public int CreateUid { get; set; }

        [Required]
        [Column("create_dtime")]
        public DateTime CreateDtime { get; set; }

        [Required]
        [Column("update_uid")]
        public int UpdateUid { get; set; }

        [Required]
        [Column("update_dtime")]
        public DateTime UpdateDtime { get; set; }
    }
}

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EES.Database.Entities
{
    public class DtEmployee : CommonEntity
    {
        [Required]
        [Column("employee_id")]
        public int EmployeeId { get; set; }

        [Required]
        [Column("mst_belongs_id")]
        public int MstBelongsId { get; set; }

        [Required]
        [Column("name")]
        public string Name { get; set; }

        [Required]
        [Column("entering_date")]
        public DateTime EnteringDate { get; set; }

        [Required]
        [Column("grade")]
        public DateTime Grade { get; set; }

        [Required]
        [Column("level")]
        public DateTime Level { get; set; }

        [Required]
        [Column("evaluation")]
        public DateTime Evaluation { get; set; }

        [Column("grade1_promoted_date")]
        public DateTime Grade1PromotedDate { get; set; }

        [Column("grade2_promoted_date")]
        public DateTime Grade2PromotedDate { get; set; }

        [Column("grade3_promoted_date")]
        public DateTime Grade3PromotedDate { get; set; }

        [Column("grade4_promoted_date")]
        public DateTime Grade4PromotedDate { get; set; }

        [Column("grade5_promoted_date")]
        public DateTime Grade5PromotedDate { get; set; }

        [Column("grade6_promoted_date")]
        public DateTime Grade6PromotedDate { get; set; }

        [Column("grade7_promoted_date")]
        public DateTime Grade7PromotedDate { get; set; }

        [Column("grade8_promoted_date")]
        public DateTime Grade8PromotedDate { get; set; }

        [Column("grade9_promoted_date")]
        public DateTime Grade9PromotedDate { get; set; }
    }
}

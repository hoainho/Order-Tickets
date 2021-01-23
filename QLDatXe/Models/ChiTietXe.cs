namespace QLDatXe.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietXe")]
    public partial class ChiTietXe
    {
        public int ID { get; set; }

        [Required]
        [StringLength(10)]
        public string MaXe { get; set; }

        public int MaGhe { get; set; }

        public int TongGhe { get; set; }

        public virtual Ghe Ghe { get; set; }

        public virtual Xe Xe { get; set; }
    }
}

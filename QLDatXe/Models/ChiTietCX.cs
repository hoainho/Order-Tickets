namespace QLDatXe.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietCX")]
    public partial class ChiTietCX
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Required]
        [StringLength(10)]
        public string MaCX { get; set; }

        [Required]
        [StringLength(10)]
        public string MaXe { get; set; }

        public virtual ChuyenXe ChuyenXe { get; set; }

        public virtual Xe Xe { get; set; }
    }
}

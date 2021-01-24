namespace QLDatXe.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VeXe")]
    public partial class VeXe
    {
        [Key]
        [StringLength(10)]
        public string MaVe { get; set; }

        [Required]
        [StringLength(10)]
        public string MaXe { get; set; }

        [Required]
        [StringLength(10)]
        public string MaCX { get; set; }

        [Required]
        [StringLength(100)]
        public string TenKhach { get; set; }

        [Required]
        [StringLength(20)]
        public string userName { get; set; }

        public int sdt { get; set; }

        public virtual ChuyenXe ChuyenXe { get; set; }

        public virtual TaiKhoan TaiKhoan { get; set; }

        public virtual Xe Xe { get; set; }
    }
}

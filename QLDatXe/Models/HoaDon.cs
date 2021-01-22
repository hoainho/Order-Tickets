namespace QLDatXe.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDon")]
    public partial class HoaDon
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaHD { get; set; }

        public int MaVe { get; set; }

        [Required]
        [StringLength(20)]
        public string userName { get; set; }

        public double TongTien { get; set; }

        public int trangthai { get; set; }

        public int giamgia { get; set; }

        public virtual TaiKhoan TaiKhoan { get; set; }

        public virtual VeXe VeXe { get; set; }
    }
}

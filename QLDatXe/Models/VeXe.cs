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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VeXe()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        [Key]
        public int MaVe { get; set; }

        public int MaCX { get; set; }

        [Required]
        [StringLength(50)]
        public string TenKhach { get; set; }

        public int CMND { get; set; }

        public double GiaVe { get; set; }

        public virtual ChuyenXe ChuyenXe { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}

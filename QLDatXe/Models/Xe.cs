namespace QLDatXe.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Xe")]
    public partial class Xe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Xe()
        {
            ChuyenXes = new HashSet<ChuyenXe>();
        }

        [Key]
        public int MaXe { get; set; }

        public int Loai { get; set; }

        public int MaGhe { get; set; }

        public int TongGhe { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChuyenXe> ChuyenXes { get; set; }

        public virtual Ghe Ghe { get; set; }

        public virtual LoaiXe LoaiXe { get; set; }
    }
}

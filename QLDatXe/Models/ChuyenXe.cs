namespace QLDatXe.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChuyenXe")]
    public partial class ChuyenXe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ChuyenXe()
        {
            VeXes = new HashSet<VeXe>();
        }

        [Key]
        [StringLength(10)]
        public string MaCX { get; set; }

        public int MaXe { get; set; }

        public int MaBXDi { get; set; }

        public int MaBXDen { get; set; }

        [Column(TypeName = "date")]
        public DateTime Ngaydi { get; set; }

        public double GiaVe { get; set; }

        public virtual BenXe BenXe { get; set; }

        public virtual BenXe BenXe1 { get; set; }

        public virtual Xe Xe { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VeXe> VeXes { get; set; }
    }
}

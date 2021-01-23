namespace QLDatXe.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaiKhoan")]
    public partial class TaiKhoan
    {
        [Required]
        [StringLength(20)]
        public string userName { get; set; }

        [Required]
        [StringLength(200)]
        public string displayName { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int numberPhone { get; set; }

        [Required]
        [StringLength(10)]
        public string type { get; set; }

        [Required]
        [StringLength(200)]
        public string address { get; set; }
    }
}

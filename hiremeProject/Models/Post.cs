namespace hiremeProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Post")]
    public partial class Post
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string name { get; set; }

        [Required]
        [StringLength(50)]
        public string job { get; set; }

        public int phoneNumber { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string address { get; set; }

        [Column(TypeName = "text")]
        public string details { get; set; }

        [Column(TypeName = "date")]
        public DateTime? datePost { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string passwordPost { get; set; }
    }
}

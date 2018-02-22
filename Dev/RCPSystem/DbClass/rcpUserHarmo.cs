namespace RCPSystem
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("rcpUserHarmo")]
    public partial class rcpUserHarmo
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdUser { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdHarmo { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime ValidFrom { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime ValidTo { get; set; }

        public virtual genUser genUser { get; set; }

        public virtual rcpHarmo rcpHarmo { get; set; }
    }
}
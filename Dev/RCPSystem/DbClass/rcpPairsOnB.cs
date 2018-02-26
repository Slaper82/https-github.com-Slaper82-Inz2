namespace RCPSystem
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("rcpPairsOnB")]
    public partial class rcpPairsOnB
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdUser { get; set; }

        public DateTime? Start { get; set; }

        public DateTime? Stop { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Lp { get; set; }

        public virtual genUser genUser { get; set; }
    }
}

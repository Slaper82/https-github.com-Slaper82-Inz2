namespace RCPSystem
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("rcpTransaction")]
    public partial class rcpTransaction
    {
        [Key]
        [Column(Order = 0)]
        public long IdTrans { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime DateAndTime { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdUser { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdTransType { get; set; }

        public virtual genUser genUser { get; set; }

        public virtual rcpTranType rcpTranType { get; set; }
    }
}

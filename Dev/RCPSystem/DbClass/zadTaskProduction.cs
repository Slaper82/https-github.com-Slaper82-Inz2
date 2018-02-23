namespace RCPSystem
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("zadTaskProduction")]
    public partial class zadTaskProduction
    {
        public int? IdTask { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdUser { get; set; }

        public DateTime Start { get; set; }

        public DateTime? Stop { get; set; }

        public bool? Active { get; set; }

        public virtual genUser genUser { get; set; }

        public virtual zadTaskList zadTaskList { get; set; }
    }
}

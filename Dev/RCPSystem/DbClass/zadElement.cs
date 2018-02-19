namespace RCPSystem
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("zadElement")]
    public partial class zadElement
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public zadElement()
        {
            zadTaskLists = new HashSet<zadTaskList>();
        }

        [Key]
        public int IdElement { get; set; }

        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        [Required]
        [StringLength(200)]
        public string Description { get; set; }

        public int IdProduct { get; set; }

        public int IdType { get; set; }

        public bool Active { get; set; }

        public virtual zadProduct zadProduct { get; set; }

        public virtual zadType zadType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<zadTaskList> zadTaskLists { get; set; }
    }
}

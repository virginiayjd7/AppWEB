namespace AppWEB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TipoTramite")]
    public partial class TipoTramite
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TipoTramite()
        {
            Certificado = new HashSet<Certificado>();
        }

        [Key]
        public int idtipotramite { get; set; }

        public int? idtramite { get; set; }

        [StringLength(200)]
        public string descripcion { get; set; }

        public decimal? costo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Certificado> Certificado { get; set; }

        public virtual Tramite Tramite { get; set; }
    }
}

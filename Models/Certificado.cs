namespace AppWEB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Certificado")]
    public partial class Certificado
    {
        [Key]
        public int idcerti { get; set; }

        public int? idsolicitante { get; set; }

        [StringLength(200)]
        public string ubicacion_predio { get; set; }

        public int? idtipotramite { get; set; }

        [StringLength(50)]
        public string validar_pago { get; set; }

        public virtual Solicitante Solicitante { get; set; }

        public virtual TipoTramite TipoTramite { get; set; }
    }
}

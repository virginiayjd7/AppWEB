namespace AppWEB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TipoDocumento")]
    public partial class TipoDocumento
    {
        [Key]
        public int idTipo_doci { get; set; }

        [StringLength(50)]
        public string descripcion { get; set; }
    }
}

namespace AppWEB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("Solicitante")]
    public partial class Solicitante
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Solicitante()
        {
            Certificado = new HashSet<Certificado>();
        }

        [Key]
        public int idsolicitante { get; set; }

        public int? idTipo_doci { get; set; }

        [StringLength(8)]
        public string numero_doc { get; set; }

        [StringLength(50)]
        public string fechanac { get; set; }

        [StringLength(50)]
        public string fechaemi { get; set; }

        [StringLength(50)]
        public string nombre { get; set; }

        [StringLength(50)]
        public string apellidop { get; set; }

        [StringLength(50)]
        public string apellidom { get; set; }

        [StringLength(50)]
        public string celular { get; set; }

        [StringLength(100)]
        public string correo { get; set; }

        [StringLength(100)]
        public string confirmar_correo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Certificado> Certificado { get; set; }
        public ResponseModel Acceder(string Usuario, string Password)
        {
            var rm = new ResponseModel();
            try
            {
                using (var db = new dbcerti())
                {
                    var query = db.Solicitante.Where(x => x.numero_doc == Usuario).Where(x => x.fechaemi == Password)
                        .SingleOrDefault();

                    if (query != null)
                    {
                        SessionHelper.AddUserToSession(query.idsolicitante.ToString());                 
                        rm.idusuario = query.idsolicitante.ToString();
                        rm.nombre = query.nombre;
                        rm.correo = numero_doc;
                        rm.SetResponse(true);
                    }
                    else
                    {
                        rm.SetResponse(false, "Usuario y/o Password incorrectos ...");
                    }
                }
            }
            catch (Exception ex)
            { throw; }
            return rm;
        }

    }
}

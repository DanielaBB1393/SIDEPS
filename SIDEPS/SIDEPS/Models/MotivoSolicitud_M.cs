using System.ComponentModel;

namespace SIDEPS.Models
{
    public class MotivoSolicitud_M
    {
        [DisplayName("Motivo Solicitud")]
        public string MotivoSolicitud { get; set; }
        [DisplayName("Observaciones")]
        public string Observaciones { get; set; }
    }
}
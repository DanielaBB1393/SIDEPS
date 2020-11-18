using System.Collections.Generic;
using System.ComponentModel;
using SIDEPS.WCFCasos;

namespace SIDEPS.Models
{
    public class GrupoFamiliar_M
    {
        [DisplayName("Grupo Familiar")]
        public List<MiembroFamiliar_M> GrupoFamiliar { get; set; }
        public string Mensaje { get; set; }
    }
}
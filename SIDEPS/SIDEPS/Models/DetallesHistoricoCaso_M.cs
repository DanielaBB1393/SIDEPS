using System.Collections.Generic;

namespace SIDEPS.Models
{
    public class DetallesHistoricoCaso_M
    {
        public DatosPersonales_M DatosPersonales { get; set; }
        public AspectoSalud_M AspectoSalud { get; set; }
        public Vivienda_M Vivienda { get; set; }
        public List<MiembroFamiliar_M> GrupoFamiliar { get; set; }
        public Egresos_M Egresos { get; set; }
        public Caso_M Caso { get; set; }

        public string CedulaUsuario { get; set; }
    }
}
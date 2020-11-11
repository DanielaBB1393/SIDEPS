using System.Collections.Generic;
using System.ComponentModel;

namespace SIDEPS.Models
{
    public class SituacionFinanciera_M
    {
        [DisplayName("Grupo Familiar")]
        public List<MiembroGrupoFamiliar> GrupoFamiliar { get; set; }
    }
}
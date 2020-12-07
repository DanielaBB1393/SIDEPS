using System.Collections.Generic;

namespace SIDEPS.Models
{
    public class AprobarCaso_M
    {
        public int CodigoCaso { get; set; }

        public List<TipoAyuda_M> Ayudas { get; set; }
    }
}
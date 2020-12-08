using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SIDEPS.Models
{
    public class HistoricoCaso_M
    {
        [DisplayName("Caso")]
        public int CODCASO25 { get; set; }

        [DisplayName("Cédula Solicitante")]
        public string CEDPERS13 { get; set; }

        [DisplayName("Nombre")]
        public string NOMPERS13 { get; set; }

        [DisplayName("Apellido")]
        public string PAPPERS13 { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]

        [DisplayName("Inicio")]
        public Nullable<DateTime> FEICASO25 { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DisplayName("Fin")]
        public Nullable<DateTime> FEFCASO25 { get; set; }

        [DisplayName("Cedula Usuario")]
        public string CEDUSRO07 { get; set; }

        [DisplayName("Nombre")]
        public string NOMUSRO07 { get; set; }

        [DisplayName("Apellido")]
        public string PAPUSRO07 { get; set; }

        [DisplayName("Motivo")]
        public string DESCASO25 { get; set; }

        [DisplayName("Observaciones")]
        public string OPICASO25 { get; set; }

        [DisplayName("Estado")]
        public string ESTCASO25 { get; set; }
    }
}
using System.Collections.Generic;

namespace SIDEPS.Models
{
    public static class Combos
    {
        public static List<string> ActivoInactivo = new List<string>()
        {
            "ACTIVO","INACTIVO"
        };

        public static List<Categoria> SiNo = new List<Categoria>()
        {
            new Categoria
            {
                Codigo = 1,
                Descripcion = "SI"
            },
            new Categoria
            {
                Codigo = 0,
                Descripcion = "NO"
            }
        };

        public static List<string> ValidarCasos = new List<string>
        {
            CASO_APROBADO,
            CASO_RECHAZADO
        };

        public static List<string> EstadosCaso = new List<string>
        {
            "INCOMPLETO",
            "PENDIENTE",
            "APROBADO",
            "RECHAZADO",
        };

        public static string CASO_INCOMPLETO = "INCOMPLETO";
        public static string CASO_PENDIENTE = "PENDIENTE";
        public static string CASO_APROBADO = "APROBADO";
        public static string CASO_RECHAZADO = "RECHAZADO";
    }
}
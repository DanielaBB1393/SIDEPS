using System.Collections.Generic;

namespace SIDEPS.Models
{
    public static class Combos
    {
        public static List<string> ActivoInactivo = new List<string>()
        {
            "ACTIVO","INACTIVO"
        };

        public static List<string> SiNo = new List<string>()
        {
            "SI","NO"
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
            "FINALIZADO",
        };

        // Estados de casos
        public static string CASO_INCOMPLETO = "INCOMPLETO";
        public static string CASO_PENDIENTE = "PENDIENTE";
        public static string CASO_APROBADO = "APROBADO";
        public static string CASO_RECHAZADO = "RECHAZADO";

        // Tipos de usuarios
        public const string ADMIN_PARROQUIAL = "ADMIN PARROQUIAL";
        public const string ADMIN_DIACONAL = "ADMIN DIACONAL";
        public const string COLABORADOR = "COLABORADOR";

        // Llaves usadas en temp data
        public const string _CODIGOCASO = "codigoCaso";
        public const string _CEDULAPERSONA = "cedulaPersona";
        public const string _CODIGOVIVIENDA = "codigoVivienda";
        public const string _CEDULAUSUARIO = "cedulaUsuario";
        public const string _TIPOUSUARIO = "tipoUsuario";
    }
}
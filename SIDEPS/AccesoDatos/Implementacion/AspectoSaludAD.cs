﻿using AccesoDatos.Interfaces;
using Entidades;
using System;

namespace AccesoDatos.Implementacion
{
    public class AspectoSaludAD : IAspectoSaludAD
    {
        private readonly SIDEPSEntities contexto = new SIDEPSEntities();

        public int SP_Ins_AspectoSalud(SIDEPS_16REGASPS aspecto, int codigoCaso)
        {
            try
            {
                var resultado = this.contexto.SIDEPS_16REGASPS.Add(aspecto);
                this.contexto.SaveChanges();

                SIDEPS_25REGCASO caso = this.contexto.SIDEPS_25REGCASO.Find(codigoCaso);
                caso.CODASPS16 = resultado.CODASPS16;
                this.contexto.SaveChanges();

                return resultado.CODASPS16;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
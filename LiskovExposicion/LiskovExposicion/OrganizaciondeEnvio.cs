using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace LiskovExposicion
{ 
    public class OrganizaciondeEnvio

    {   public OrganizaciondeEnvio(decimal PrecioInicial)
        {
            this.precioInicial = PrecioInicial; 
        }
        //Invariante
        private decimal PrecioInicial;
        protected decimal precioInicial
        {
            get
            {
                return this.PrecioInicial;
            }
            set
            {
                if (value<= 0)
                    throw new ArgumentOutOfRangeException(nameof(value), "El precio inicial deb ser postivo distinto a cero");
                this.PrecioInicial = value;
            }
        }
        
        public virtual decimal CalcularCostodeEnvio(float PesoenKg, RegionInfo Destino)
        {   
            //Precondicion
            if (PesoenKg <= 0)
                throw new ArgumentOutOfRangeException(nameof(PesoenKg), "El peso en kilogramos debe se mayor a cero");
            //Implementación
            var CostodeEnvio = decimal.One;
            //Post condición
            if (CostodeEnvio <= decimal.Zero)
                throw new ArgumentOutOfRangeException("Resultado, el envio debe ser mayor a cero");
            return CostodeEnvio;
        }
    }
}
using System;
using System.Globalization;

namespace LiskovExposicion
{
    public class EstrategiaGolbaldeEnvio : OrganizaciondeEnvio
    {
        public EstrategiaGolbaldeEnvio(decimal PrecioInicial)
            : base(PrecioInicial)
        {
        }
        public new decimal precioInicial
        {
            get
            {
                return base.precioInicial;
            }
            set
            {
                base.precioInicial = value;
            }
        }
        public override decimal CalcularCostodeEnvio(float PesoenKg, RegionInfo Destino)
        {
            //Precondicion
            if (PesoenKg <= 0)
                throw new ArgumentOutOfRangeException(nameof(PesoenKg), "El peso en kilogramos debe se mayor a cero");
            if (Destino == null)
                throw new ArgumentNullException("Debe de existir una localización");
            //Post condicion
            var CostodeEnvio = decimal.One;
            if (Destino == RegionInfo.CurrentRegion)
            
                CostodeEnvio= decimal.Zero;
            
            return CostodeEnvio;
        }

    }

       

            
       


    }

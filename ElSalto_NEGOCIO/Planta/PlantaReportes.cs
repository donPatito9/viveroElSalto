 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElSalto_NEGOCIO.Planta
{
     public class PlantaReportes
    {
            public int ReportePlantaVenenosa()
            {
                return (CommonBC.PlantaModelo.spObtenerCantidadPlantasVenenosas().First().Value);
            }

            public int ReportePlantaAutoctona()
            {
                return (CommonBC.PlantaModelo.spObtenerCantidadPlantasAutoctonas().First().Value);
            }

        }
    }


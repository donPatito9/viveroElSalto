using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElSalto_NEGOCIO.Planta
{
    public class PlantaCollection
    {
        public List<Planta> ReadAll()
        {
            var plantas = CommonBC.PlantaModelo.vwPlanta;
            return ObtenerPlantas(plantas.ToList());
        }
        private List<Planta> ObtenerPlantas(List<ElSalto_DALC.vwPlanta> plantasDALC)
        {
            List<Planta> plantaList = new List<Planta>();
            foreach (ElSalto_DALC.vwPlanta planta in plantasDALC)
            {
                Planta p = new Planta();

                p.PlantaId = planta.PlantaId;

                //DesenriptaCamposEnElMetodoListar

                p.NombreComun = Helpers.AES_Helper.DecryptString(planta.NombreComun);

                p.NombreCientifico = Helpers.AES_Helper.DecryptString(planta.NombreCientifico);

                p.TipoPlanta = planta.TipoPlanta;

                p.Descripcion = Helpers.AES_Helper.DecryptString(planta.Descripcion);

                p.TiempoRiego = planta.TiempoRiego;
                p.CantidadAgua = planta.CantidadAgua;
                p.Epoca = planta.Epoca;
                p.EsVenenosa = (bool)planta.EsVenenosa;
                p.EsAutoctona = (bool)planta.EsAutoctona;

                plantaList.Add(p);
            }
            return plantaList;
        }
    }
}
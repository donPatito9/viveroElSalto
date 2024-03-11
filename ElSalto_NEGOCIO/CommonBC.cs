using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElSalto_NEGOCIO
{
    public class CommonBC
    {
        private static ElSalto_DALC.ElSaltoEntities _plantaModelo;

        public static ElSalto_DALC.ElSaltoEntities PlantaModelo
        {
            get
            {
                if (_plantaModelo == null)
                {
                    _plantaModelo = new ElSalto_DALC.ElSaltoEntities();
                }
                return _plantaModelo;
            }
        }

        public CommonBC() { }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElSalto_NEGOCIO
{
    public interface IPersistente
    {
        bool Create();
        bool Read(int PlantaId);
        bool Update();
        bool Delete(int PlantaId);
    }
}
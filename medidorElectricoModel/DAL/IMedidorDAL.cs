using medidorElectricoModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medidorElectricoModel.DAL
{
    internal interface IMedidorDAL
    {
        void ObtenerMedidores(Medidor medidor);
        List<Medidor> ObtenerMedidores();


    }
}

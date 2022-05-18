using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medidorElectricoModel.DTO
{
    public class Lectura
    {
        private int nroMedidor;
        private DateTime fecha;
        private string valorConsumo;

        public int NroMedidor { get => nroMedidor; set => nroMedidor = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string ValorConsumo { get => valorConsumo; set => valorConsumo = value; }

        public override string ToString()
        {
            return nroMedidor + " " + fecha + " " + ValorConsumo;
        }

    }

}

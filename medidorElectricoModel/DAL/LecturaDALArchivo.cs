using medidorElectricoModel.DTO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace medidorElectricoModel.DAL
{
    public class LecturaDALArchivo : ILecturaDAL
    {

        private LecturaDALArchivo()
        {

        }

        private static LecturaDALArchivo instancia;

        public static ILecturaDAL GetInstacia()
        {
            if (instancia == null)
            {
                instancia = new LecturaDALArchivo();
            }
            return instancia;
        }

        private static string url = Directory.GetCurrentDirectory();
        private static string archivo = url + "/medidor.txt";

        public void IngresarLectura(Medidor medidor)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(archivo, true))
                {
                    writer.WriteLine(medidor.NroMedidor + ";" + medidor.Fecha + ";" + medidor.ValorConsumo);
                    writer.Flush();
                }
            }
            catch (Exception)
            {

            }

        }
        public List<Medidor> ObtenerLecturas()
        {   
            List<Medidor> lista = new List<Medidor>();
            return null;
        }

     }

   
}
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using medidorElectricoModel.DAL;
using medidorElectricoModel.DTO;
using Mensajero.Comunicacion;
using Microsoft.VisualBasic;




namespace medidorElectrico
{
    class Program
    {

        private static ILecturaDAL LecturaDAL = LecturaDALArchivo.GetInstacia();
        private static bool Menu()
        {
            bool continuar = true;
            Console.WriteLine("Medidor Electrico");
            Console.WriteLine(" 1. Ingresar nueva lectura \n 2. Mostrar lecturas \n 0. Salir");
            switch (Console.ReadLine().Trim())
            {
                case "1":
                    IngresarLectura();
                    break;
                case "2":
                    ObtenerLecturas();
                    break;
                case "0":
                    continuar = false;
                    break;
                default:
                    Console.WriteLine("Ingrese la nueva lectura");
                    break;
            }
            return continuar;
        }
        static void Main(string[] args)
        {
            HebraServidor hebra = new HebraServidor();
            Thread t = new Thread(new ThreadStart(hebra.Ejecutar));
            t.IsBackground = true;
            t.Start();
            while (Menu()) ;
        }

        

        static void IngresarLectura()
        {
            Console.WriteLine("Ingrese numero de medidor: ");
            int nroMedidor = Console.Read();

            Console.WriteLine("fecha de lectura :");
            DateTime fecha = DateTime.Now;
            Console.WriteLine(fecha.ToString("dd/MM/yyyy"));

            Console.WriteLine("Ingrese valor del consumo :");
            string valorConsumo = Console.ReadLine();
            Console.WriteLine(valorConsumo.Trim() + "kw/h");

            Medidor medidor = new Medidor()
            {
                NroMedidor = nroMedidor,
                Fecha = fecha, 
                ValorConsumo = valorConsumo,
                
            };

        }




        static void ObtenerLecturas()
        {
            
            
        }


    }

}

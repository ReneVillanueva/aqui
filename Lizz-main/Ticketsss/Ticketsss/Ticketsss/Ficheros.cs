using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Ticketsss
{
    internal class Ficheros
    {
        public double Precio { get; set; }
        public Ficheros()
        {
            this.Precio = 0;
            
        }

        public void CrearFichero(string producto, double P1)
        {

            StreamWriter fichero;
            string nombreFichero = "C:\\Users\\Alumno\\Downloads\\Lizz-main\\Ticketsss\\TicketsssTicket.txt";
            fichero = File.CreateText(nombreFichero);
            fichero.WriteLine("total = " + Precio);
            this.Precio += P1;

            fichero.Close();

        }
        public void AgregarTextoAfichero(string producto, double Pr2)
        {

            this.Precio+= Pr2;
            StreamWriter fichero;
            string nombreFichero = "C:\\Users\\Alumno\\Downloads\\Lizz-main\\Ticketsss\\TicketsssTicket.txt";
            fichero = File.AppendText(nombreFichero);
            fichero.WriteLine(producto + " " + Pr2);
            

            fichero.Close();

        }
        public void AgregarTextoAfichero2(string producto, int P3)
        {

            this.Precio += P3;
            StreamWriter fichero;
            string nombreFichero = "C:\\Users\\Alumno\\Downloads\\Lizz-main\\Ticketsss\\TicketsssTicket.txt";
            fichero = File.AppendText(nombreFichero);
            fichero.WriteLine(producto + " " + P3);
            

            fichero.Close();

        }
        public void AgregarTextoAfichero3(string producto, int P4)
        {

            this.Precio += P4;
            StreamWriter fichero;
            string nombreFichero = "C:\\Users\\Alumno\\Downloads\\Lizz-main\\Ticketsss\\TicketsssTicket.txt";
            fichero = File.AppendText(nombreFichero);
            fichero.WriteLine(producto + " " + P4);
            

            fichero.Close();

        }
        public void AgregarTextoAfichero4(string producto, int P5)
        {

            this.Precio += P5;
            StreamWriter fichero;
            string nombreFichero = "C:\\Users\\Alumno\\Downloads\\Lizz-main\\Ticketsss\\TicketsssTicket.txt";
            fichero = File.AppendText(nombreFichero);
            fichero.WriteLine(producto + " " + P5);
            fichero.WriteLine("El total es: " + Precio);

            fichero.Close();

        }
        public void LeerDocumento()
        {
            StreamReader fichero;
            string nombreFichero = "C:\\Users\\Alumno\\Downloads\\Lizz-main\\Ticketsss\\TicketsssTicket.txt";
            string linea;
           
            fichero = File.OpenText(nombreFichero);
            do
            {
                linea = fichero.ReadLine();
                Console.WriteLine(linea);

            } while (linea != null);
            fichero.Close();
            Console.ReadKey();
        }
    }
}
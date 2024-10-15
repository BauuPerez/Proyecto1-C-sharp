using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Clases
{
    internal class CasaFinde : Casa
    {

        Image[] imagenes;


        public Image[] Images { get; set; }


        public CasaFinde(bool cochera, bool pileta, bool wifi, bool limpieza, bool desayuno, bool mascotas, string direccion, int nro, int minimodias, int cantcamas, double preciobase, calendario calen, int cantImagenes, string[] directorioImagenes, string lugar) :base(cochera,pileta,wifi,limpieza,desayuno,mascotas,direccion,nro,3,cantcamas,preciobase,calen,cantImagenes,directorioImagenes,lugar)
        {

            Lugar = lugar;
            Calendario = calen;
            Cochera = cochera;
            this.Pileta = pileta;
            this.Wifi = wifi;
            this.Limpieza = limpieza;
            this.Desayuno = desayuno;
            this.Mascotas = mascotas;
            this.Direccion = direccion;
            Nropropiedad = nro;
            this.MinimoDias = minimodias;
            this.CantidadCamas = cantcamas;
            this.PrecioBase = preciobase;
            imagenes = new Image[cantImagenes];
            for (int i = 0; i < cantImagenes; i++)
            {
                imagenes[i] = Image.FromFile(directorioImagenes[i]);
            }
            reservasCasa = new List<Reserva>();

        }

        public double CalcularPrecioCasaFinde() // "acum" acumula los porcentaje de los serivios...
        {
            double acum = 0;
            if (Cochera) acum += 2;
            if (Wifi) acum += 5;
            if (Limpieza) acum += 15;
            if (Desayuno) acum += 10;
            if (Pileta) acum += 5;
            if (Mascotas) acum += 2;
            acum += CantidadCamas * 5;
            double aux = (PrecioBase * acum) / 100; //"aux" varibale auxiliar para guardar el precio del porcentaje total
            return PrecioBase + aux;
        }

        public void AgregarReservaCasaFinde(Reserva res)
        {
            //reservasCasa.Add(res);
        }


        public override string ToString()
        {
            return "Casa Finde: " + Direccion + "- " + Nropropiedad + "- " + CantidadCamas + "- " + PrecioBase;
        }

    }
}

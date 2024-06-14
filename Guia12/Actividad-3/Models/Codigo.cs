using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_3.Models
{
    internal class Codigo
    {

        public int[] ids = new int[100];
        public string[] origen = new string[100];
        public double[] peso = new double[100];
        public int cont = 0;
        public int[] busquedaID = new int[100];
        public string[] busquedaOrigen = new string[100];
        public double[] pesoBusqueda = new double[100];
        public int contBusqueda;

        public void AgregarCont(int id, double pesos, string pais)
        {
            ids[cont] = id;
            origen[cont] = pais;
            peso[cont] = pesos;
            cont++;
        }

        
        public int[] BusquedaOrigen(string pais, ref int cantidad)
        {
            int[] posicion = new int[100];
            cantidad = 0;
            for (int i = 0; i < cont; i++)
            {
                if (origen[i] == pais)
                {
                    posicion[cantidad] = i;
                    cantidad++;
                }
            }
            return posicion;
        }

        public void Ordenar()
        {
            int idsGuardar;
            string origenGuardar;
            double pesoGuardar;

            for (int i = 0; i < cont - 1; i++)
            {
                for (int j = i + 1; j < cont; j++)
                {
                    if (ids[i] > ids[j])
                    {
                        idsGuardar = ids[j];
                        ids[j] = ids[i];
                        ids[i] = idsGuardar;

                        origenGuardar = origen[j];
                        origen[j] = origen[i];
                        origen[i] = origenGuardar;

                        pesoGuardar = peso[j];
                        peso[j] = peso[i];
                        peso[i] = pesoGuardar;
                    }
                }
            }
        }
    }
}

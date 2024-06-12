using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad.Models
{
    public class Codigo
    {

        public string[] competidores = new string[50];
        public int[] tiempos = new int[50];
        public int cont = 0;

        public void AgregarComp(string comp)
        {
            competidores[cont++] = comp;
        }

        public void Tiempos(int HH, int MM, int i)
        {
            tiempos[i] = HH * 60 + MM;
          
        }

        public void Ordenar()
        {
            string compGuardar = "";
            int tiempoGuardar = 0;
            for (int i = 0; i < cont - 1; i++)
            {
                for (int j = i + 1;  j < cont ; j++)
                {
                    if (tiempos[i] > tiempos[j])
                    {
                        tiempoGuardar = tiempos[j];
                        tiempos[i] = tiempos[j];
                        tiempos[i] = tiempoGuardar;

                        compGuardar = competidores[j];
                        competidores[i] = competidores[j];
                        competidores[i] = compGuardar;
                    }
                }
            }
        }
    }
}

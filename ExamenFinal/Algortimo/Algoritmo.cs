using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal.Algortimo
{
    public class Algoritmo
    {
        public List<int> GenerarNumerosAleatorios(int x0, int a, int m, int totalValores) 
        { 
            List<int> listaAleatorios = new List<int>();
            if (m > x0 && m > a && a > 0 && x0 > 0)
            {
                listaAleatorios.Add(x0);
                int aleatorioNuevo = 0;
                for (int i = 1; i < totalValores; i++)
                {
                    aleatorioNuevo = (a * listaAleatorios[i - 1]) % m;
                    if (listaAleatorios[i - 1] == aleatorioNuevo)
                    {
                        break;
                    }
                    listaAleatorios.Add(aleatorioNuevo);
                }
            }
            return listaAleatorios;
        }
    }
}

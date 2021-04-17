using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2.clases
{
    class ClsArreglo
    {

        public string[,] DosDimensiones(string[] arreglo, int numeroColumnas)
        {
            string[,] matriz = new string[arreglo.Length-1, numeroColumnas];
            int contador = 0;
            foreach (string fila in arreglo)
            {
                if (contador > 0)
                {
                    string[] columnas = fila.Split(';');
                    matriz[contador-1, 0] = columnas[0]; 
                    matriz[contador-1, 1] = columnas[1]; 
                    matriz[contador-1, 2] = columnas[2]; 
                    matriz[contador-1, 3] = columnas[3]; 
                    matriz[contador-1, 4] = columnas[4]; 
                    matriz[contador-1, 5] = columnas[5]; 
                  
                    int suma = Convert.ToInt16(columnas[2]) + Convert.ToInt16(columnas[3]) + Convert.ToInt16(columnas[4]);
                    int promedio = suma / 3;

                    matriz[contador-1, 6] = Convert.ToString(promedio); 
                }
                contador++;
            }
            return matriz;
        }
        public string[] OrdenarString(string[,] matriz, int columna)
        {
            string[] arreglo = new string[matriz.GetLength(0)-1];

            for (int i = 0; i < arreglo.Length; i++)
            {
                arreglo[i] = matriz[i, columna];
            }
            
            string[] ArregloTemporal = arreglo;
            string datosTemporal;

            for (int i = 0; i < arreglo.Length; i++)
            {
                for (int j = i + 1; j < arreglo.Length; j++)
                {
                    
                    if (ArregloTemporal[i].CompareTo(ArregloTemporal[j]) > 0)
                    {
                        datosTemporal = ArregloTemporal[i];
                        ArregloTemporal[i] = ArregloTemporal[j];
                        ArregloTemporal[j] = datosTemporal;
                    }
                }
            }
            return arreglo;
        }
        public int[] OrdenarInt(string[,] matriz, int columna)
        {

           
            int[] arreglo = new int[matriz.GetLength(0)-1];
            for (int i = 0; i < arreglo.Length; i++)
            {
                arreglo[i] = Convert.ToInt32(matriz[i , columna]);
            }

            
            int[] ArregloTemporal = arreglo;
            int datosTemporal;
            for (int i = 0; i < arreglo.GetLength(0); i++)
            {
                for (int j = i + 1; j < arreglo.GetLength(0); j++)
                {
                   
                    if (ArregloTemporal[i].CompareTo(ArregloTemporal[j]) > 0)
                    {
                        datosTemporal = ArregloTemporal[i];
                        ArregloTemporal[i] = ArregloTemporal[j];
                        ArregloTemporal[j] = datosTemporal;
                    }
                }
            }
            return arreglo;
        }
        
       

    }
}

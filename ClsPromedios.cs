using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2.clases
{
    class ClsPromedios : InterfacePromedio
    {
        public string[,] Clasificar_Alumnos(string[,] matriz, string seccion)
        {
            int alumnosEnSeccion = 0;
            for(int i=0; i<matriz.GetLength(0); i++)
            {
                if (matriz[i, 5] == seccion)
                {
                    alumnosEnSeccion++;
                }
            }
            string[,] datos = new string[alumnosEnSeccion, matriz.GetLength(1)];
            int contadorNuevaMatriz = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                if (matriz[i, 5] == seccion)
                {
                    datos[contadorNuevaMatriz, 0] = matriz[i, 0];
                    datos[contadorNuevaMatriz, 1] = matriz[i, 1];
                    datos[contadorNuevaMatriz, 2] = matriz[i, 2];
                    datos[contadorNuevaMatriz, 3] = matriz[i, 3];
                    datos[contadorNuevaMatriz, 4] = matriz[i, 4];
                    datos[contadorNuevaMatriz, 5] = matriz[i, 5];
                    datos[contadorNuevaMatriz, 6] = matriz[i, 6];
                    contadorNuevaMatriz++;
                }
            }
            return datos;

        }

        public int promedios_general_seccion(string[,] matriz, int columna_parcial, string seccion)
        {
            int suma = 0;
            for(int i=0; i < matriz.GetLength(0); i++)
            {
                if (matriz[i, 5] == seccion )
                {
                    suma = suma + Convert.ToInt32(matriz[i, columna_parcial]);
                }
            }
            int promedio = suma / matriz.GetLength(0);
            return promedio;
        }

        public int promedios_por_parcial(string[,] matriz, int columna_parcial)
        {
            
            int acumulador = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                acumulador = acumulador + Convert.ToInt32(matriz[i, columna_parcial]);
            }

            int promedio = acumulador / matriz.GetLength(0);

            return promedio;
        }

        public int promedios_por_seccion(string[,] matriz, int columna_parcial, string seccion)
        {
            
            int acumulador = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                if (matriz[i, 5] == seccion)
                {
                    acumulador = acumulador + Convert.ToInt32(matriz[i, columna_parcial]);
                }
            }

            int promedio = acumulador / matriz.GetLength(0);

            return promedio;
        }

        public string[,] sumatoria_general_por_alumno(string[,] matriz)
        {
            string[,] datos = new string[matriz.GetLength(0), 2];
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                datos[i, 0] = matriz[i, 1];
                int suma = Convert.ToInt16(matriz[i, 2]) + Convert.ToInt16(matriz[i, 3]) + Convert.ToInt16(matriz[i, 4]);
                datos[i, 1] = Convert.ToString(suma);
            }
            return datos;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2.clases
{
    interface InterfacePromedio
    {
        /// <summary>
        /// retorna el promedio en base a una columna especifica
        /// </summary>
        /// <param name="matriz"></param>
        /// <param name="columna"></param>
        /// <returns></returns>
        int promedios_por_parcial(string[,] matriz, int columna_parcial);


        /// <summary>
        /// retorna el promedio de un parcial en ESPESIFICO
        /// </summary>
        /// <param name="matriz"></param>
        /// <param name="columna"></param>
        /// <param name="seccion"></param>
        /// <returns></returns>
        int promedios_por_seccion(string[,] matriz, int columna_parcial, string seccion);


        /// <summary>
        /// Saca el promedio general de todos los alumnos por seccion.
        /// </summary>
        /// <param name="matriz"></param>
        /// <param name="columna_parcial"></param>
        /// <param name="seccion"></param>
        /// <returns></returns>
        int promedios_general_seccion(string[,] matriz, int columna_parcial, string seccion);



        /// <summary>
        /// Se manda la matriz fuente y retrona una matiz nueva con los alumnos clasificados por seccion
        /// </summary>
        /// <param name="matriz"></param>
        /// <param name="seccion"></param>
        /// <returns></returns>
        string[,] Clasificar_Alumnos(string[,] matriz, string seccion);


        /// <summary>
        /// Retorna una matriz de 2 columnas con el nombre y la sumatoria de las columnas del parcial 1 al 3
        /// </summary>
        /// <param name="matriz"></param>
        /// <returns></returns>
        string[,] sumatoria_general_por_alumno(string[,] matriz);
    }
}

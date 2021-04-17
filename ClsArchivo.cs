using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2.clases
{
    class ClsArchivo
    {
        public string ruta {get; private set;}
        public string[] filas { get; private set; }
        public ClsArchivo() {
            this.abrir();
        }
        private string abrir()
        {
            OpenFileDialog archivo = new OpenFileDialog();
            archivo.Title = "Seleccione su Archivo Plano!";
            archivo.InitialDirectory = "c:\\";
            archivo.Filter = "";
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                this.ruta = archivo.FileName;
            }
            return this.ruta;
        }
        public string[] obtenerFilas()
        {
            string[] filas = File.ReadAllLines(this.ruta, Encoding.ASCII);
            this.filas = filas;
            return filas;
        }
    }
}

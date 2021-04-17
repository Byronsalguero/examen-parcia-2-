
namespace Parcial2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.Archivo = new System.Windows.Forms.ListBox();
            this.ListaResultado = new System.Windows.Forms.ListBox();
            this.btnOrdenNombre = new System.Windows.Forms.Button();
            this.btnOrdenP1 = new System.Windows.Forms.Button();
            this.btnOrdenP2 = new System.Windows.Forms.Button();
            this.btnOrdenP3 = new System.Windows.Forms.Button();
            this.btnPromedios = new System.Windows.Forms.Button();
            this.promedio1 = new System.Windows.Forms.Button();
            this.Promedio3 = new System.Windows.Forms.Button();
            this.Promedio2 = new System.Windows.Forms.Button();
            this.PromediosSeccion = new System.Windows.Forms.Button();
            this.txtSeccion = new System.Windows.Forms.TextBox();
            this.seccion2 = new System.Windows.Forms.Button();
            this.seccion3 = new System.Windows.Forms.Button();
            this.seccion1 = new System.Windows.Forms.Button();
            this.totalll = new System.Windows.Forms.Button();
            this.seccionalum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(35, 13);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 68);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cargar archivo";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Archivo
            // 
            this.Archivo.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Archivo.FormattingEnabled = true;
            this.Archivo.HorizontalScrollbar = true;
            this.Archivo.ItemHeight = 19;
            this.Archivo.Location = new System.Drawing.Point(35, 121);
            this.Archivo.Margin = new System.Windows.Forms.Padding(4);
            this.Archivo.Name = "Archivo";
            this.Archivo.ScrollAlwaysVisible = true;
            this.Archivo.Size = new System.Drawing.Size(552, 650);
            this.Archivo.TabIndex = 2;
            // 
            // ListaResultado
            // 
            this.ListaResultado.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaResultado.FormattingEnabled = true;
            this.ListaResultado.HorizontalScrollbar = true;
            this.ListaResultado.ItemHeight = 19;
            this.ListaResultado.Location = new System.Drawing.Point(816, 373);
            this.ListaResultado.Margin = new System.Windows.Forms.Padding(4);
            this.ListaResultado.Name = "ListaResultado";
            this.ListaResultado.ScrollAlwaysVisible = true;
            this.ListaResultado.Size = new System.Drawing.Size(538, 479);
            this.ListaResultado.TabIndex = 3;
            // 
            // btnOrdenNombre
            // 
            this.btnOrdenNombre.BackColor = System.Drawing.Color.Blue;
            this.btnOrdenNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenNombre.Location = new System.Drawing.Point(155, 24);
            this.btnOrdenNombre.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrdenNombre.Name = "btnOrdenNombre";
            this.btnOrdenNombre.Size = new System.Drawing.Size(106, 57);
            this.btnOrdenNombre.TabIndex = 4;
            this.btnOrdenNombre.Text = " Nombre";
            this.btnOrdenNombre.UseVisualStyleBackColor = false;
            this.btnOrdenNombre.Click += new System.EventHandler(this.btnOrdenNombre_Click);
            // 
            // btnOrdenP1
            // 
            this.btnOrdenP1.BackColor = System.Drawing.Color.Lime;
            this.btnOrdenP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenP1.Location = new System.Drawing.Point(269, 24);
            this.btnOrdenP1.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrdenP1.Name = "btnOrdenP1";
            this.btnOrdenP1.Size = new System.Drawing.Size(96, 57);
            this.btnOrdenP1.TabIndex = 13;
            this.btnOrdenP1.Text = "Parcial Uno";
            this.btnOrdenP1.UseVisualStyleBackColor = false;
            this.btnOrdenP1.Click += new System.EventHandler(this.btnOrdenP1_Click);
            // 
            // btnOrdenP2
            // 
            this.btnOrdenP2.BackColor = System.Drawing.Color.Cyan;
            this.btnOrdenP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenP2.Location = new System.Drawing.Point(382, 24);
            this.btnOrdenP2.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrdenP2.Name = "btnOrdenP2";
            this.btnOrdenP2.Size = new System.Drawing.Size(125, 57);
            this.btnOrdenP2.TabIndex = 14;
            this.btnOrdenP2.Text = " Parcial Dos";
            this.btnOrdenP2.UseVisualStyleBackColor = false;
            this.btnOrdenP2.Click += new System.EventHandler(this.btnOrdenP2_Click);
            // 
            // btnOrdenP3
            // 
            this.btnOrdenP3.BackColor = System.Drawing.Color.BlueViolet;
            this.btnOrdenP3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenP3.Location = new System.Drawing.Point(526, 24);
            this.btnOrdenP3.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrdenP3.Name = "btnOrdenP3";
            this.btnOrdenP3.Size = new System.Drawing.Size(121, 57);
            this.btnOrdenP3.TabIndex = 15;
            this.btnOrdenP3.Text = "Parcial Tres";
            this.btnOrdenP3.UseVisualStyleBackColor = false;
            this.btnOrdenP3.Click += new System.EventHandler(this.btnOrdenP3_Click);
            // 
            // btnPromedios
            // 
            this.btnPromedios.BackColor = System.Drawing.Color.Crimson;
            this.btnPromedios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPromedios.Location = new System.Drawing.Point(634, 121);
            this.btnPromedios.Margin = new System.Windows.Forms.Padding(4);
            this.btnPromedios.Name = "btnPromedios";
            this.btnPromedios.Size = new System.Drawing.Size(131, 64);
            this.btnPromedios.TabIndex = 16;
            this.btnPromedios.Text = "Alumnos";
            this.btnPromedios.UseVisualStyleBackColor = false;
            this.btnPromedios.Click += new System.EventHandler(this.btnPromediosAlumnos_Click);
            // 
            // promedio1
            // 
            this.promedio1.BackColor = System.Drawing.Color.Chartreuse;
            this.promedio1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.promedio1.Location = new System.Drawing.Point(783, 208);
            this.promedio1.Margin = new System.Windows.Forms.Padding(4);
            this.promedio1.Name = "promedio1";
            this.promedio1.Size = new System.Drawing.Size(126, 60);
            this.promedio1.TabIndex = 17;
            this.promedio1.Text = "Promedio Parcial 1";
            this.promedio1.UseVisualStyleBackColor = false;
            this.promedio1.Click += new System.EventHandler(this.btnPromedioP1_Click);
            // 
            // Promedio3
            // 
            this.Promedio3.BackColor = System.Drawing.Color.Aquamarine;
            this.Promedio3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Promedio3.Location = new System.Drawing.Point(1079, 208);
            this.Promedio3.Margin = new System.Windows.Forms.Padding(4);
            this.Promedio3.Name = "Promedio3";
            this.Promedio3.Size = new System.Drawing.Size(120, 60);
            this.Promedio3.TabIndex = 18;
            this.Promedio3.Text = "Promedio Parcial 3";
            this.Promedio3.UseVisualStyleBackColor = false;
            this.Promedio3.Click += new System.EventHandler(this.btnPromedioP3_Click);
            // 
            // Promedio2
            // 
            this.Promedio2.BackColor = System.Drawing.Color.Blue;
            this.Promedio2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Promedio2.Location = new System.Drawing.Point(942, 206);
            this.Promedio2.Margin = new System.Windows.Forms.Padding(4);
            this.Promedio2.Name = "Promedio2";
            this.Promedio2.Size = new System.Drawing.Size(129, 62);
            this.Promedio2.TabIndex = 19;
            this.Promedio2.Text = "Promedio Parcial 2";
            this.Promedio2.UseVisualStyleBackColor = false;
            this.Promedio2.Click += new System.EventHandler(this.btnPromedioP2_Click);
            // 
            // PromediosSeccion
            // 
            this.PromediosSeccion.BackColor = System.Drawing.Color.Aqua;
            this.PromediosSeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PromediosSeccion.Location = new System.Drawing.Point(595, 407);
            this.PromediosSeccion.Margin = new System.Windows.Forms.Padding(4);
            this.PromediosSeccion.Name = "PromediosSeccion";
            this.PromediosSeccion.Size = new System.Drawing.Size(119, 50);
            this.PromediosSeccion.TabIndex = 22;
            this.PromediosSeccion.Text = "General";
            this.PromediosSeccion.UseVisualStyleBackColor = false;
            this.PromediosSeccion.Click += new System.EventHandler(this.btnPromediosSeccion_Click);
            // 
            // txtSeccion
            // 
            this.txtSeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeccion.Location = new System.Drawing.Point(1396, 423);
            this.txtSeccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtSeccion.Name = "txtSeccion";
            this.txtSeccion.Size = new System.Drawing.Size(33, 34);
            this.txtSeccion.TabIndex = 23;
            this.txtSeccion.Text = "A";
            // 
            // seccion2
            // 
            this.seccion2.BackColor = System.Drawing.Color.Yellow;
            this.seccion2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seccion2.Location = new System.Drawing.Point(595, 532);
            this.seccion2.Margin = new System.Windows.Forms.Padding(4);
            this.seccion2.Name = "seccion2";
            this.seccion2.Size = new System.Drawing.Size(119, 52);
            this.seccion2.TabIndex = 27;
            this.seccion2.Text = "Parcial 2";
            this.seccion2.UseVisualStyleBackColor = false;
            this.seccion2.Click += new System.EventHandler(this.button2_Click);
            // 
            // seccion3
            // 
            this.seccion3.BackColor = System.Drawing.Color.Aqua;
            this.seccion3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seccion3.Location = new System.Drawing.Point(595, 592);
            this.seccion3.Margin = new System.Windows.Forms.Padding(4);
            this.seccion3.Name = "seccion3";
            this.seccion3.Size = new System.Drawing.Size(119, 44);
            this.seccion3.TabIndex = 26;
            this.seccion3.Text = "Parcial 3";
            this.seccion3.UseVisualStyleBackColor = false;
            this.seccion3.Click += new System.EventHandler(this.button3_Click);
            // 
            // seccion1
            // 
            this.seccion1.BackColor = System.Drawing.Color.YellowGreen;
            this.seccion1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seccion1.Location = new System.Drawing.Point(595, 474);
            this.seccion1.Margin = new System.Windows.Forms.Padding(4);
            this.seccion1.Name = "seccion1";
            this.seccion1.Size = new System.Drawing.Size(119, 50);
            this.seccion1.TabIndex = 25;
            this.seccion1.Text = "Parcial 1";
            this.seccion1.UseVisualStyleBackColor = false;
            this.seccion1.Click += new System.EventHandler(this.button4_Click);
            // 
            // totalll
            // 
            this.totalll.BackColor = System.Drawing.Color.Aqua;
            this.totalll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalll.Location = new System.Drawing.Point(1217, 206);
            this.totalll.Margin = new System.Windows.Forms.Padding(4);
            this.totalll.Name = "totalll";
            this.totalll.Size = new System.Drawing.Size(137, 62);
            this.totalll.TabIndex = 29;
            this.totalll.Text = "Suma de todos los alumnos";
            this.totalll.UseVisualStyleBackColor = false;
            this.totalll.Click += new System.EventHandler(this.button8_Click);
            // 
            // seccionalum
            // 
            this.seccionalum.BackColor = System.Drawing.Color.Yellow;
            this.seccionalum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seccionalum.Location = new System.Drawing.Point(1378, 328);
            this.seccionalum.Margin = new System.Windows.Forms.Padding(4);
            this.seccionalum.Name = "seccionalum";
            this.seccionalum.Size = new System.Drawing.Size(100, 50);
            this.seccionalum.TabIndex = 30;
            this.seccionalum.Text = "Alumnos Sección";
            this.seccionalum.UseVisualStyleBackColor = false;
            this.seccionalum.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1523, 871);
            this.Controls.Add(this.seccionalum);
            this.Controls.Add(this.totalll);
            this.Controls.Add(this.seccion2);
            this.Controls.Add(this.seccion3);
            this.Controls.Add(this.seccion1);
            this.Controls.Add(this.txtSeccion);
            this.Controls.Add(this.PromediosSeccion);
            this.Controls.Add(this.Promedio2);
            this.Controls.Add(this.Promedio3);
            this.Controls.Add(this.promedio1);
            this.Controls.Add(this.btnPromedios);
            this.Controls.Add(this.btnOrdenP3);
            this.Controls.Add(this.btnOrdenP2);
            this.Controls.Add(this.btnOrdenP1);
            this.Controls.Add(this.btnOrdenNombre);
            this.Controls.Add(this.ListaResultado);
            this.Controls.Add(this.Archivo);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox Archivo;
        private System.Windows.Forms.ListBox ListaResultado;
        private System.Windows.Forms.Button btnOrdenNombre;
        private System.Windows.Forms.Button btnOrdenP1;
        private System.Windows.Forms.Button btnOrdenP2;
        private System.Windows.Forms.Button btnOrdenP3;
        private System.Windows.Forms.Button btnPromedios;
        private System.Windows.Forms.Button promedio1;
        private System.Windows.Forms.Button Promedio3;
        private System.Windows.Forms.Button Promedio2;
        private System.Windows.Forms.Button PromediosSeccion;
        private System.Windows.Forms.TextBox txtSeccion;
        private System.Windows.Forms.Button seccion2;
        private System.Windows.Forms.Button seccion3;
        private System.Windows.Forms.Button seccion1;
        private System.Windows.Forms.Button totalll;
        private System.Windows.Forms.Button seccionalum;
    }
}


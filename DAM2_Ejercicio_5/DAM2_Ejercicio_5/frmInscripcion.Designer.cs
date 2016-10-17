namespace DAM2_Ejercicio_5
{
    partial class frmInscripcion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labFichero = new System.Windows.Forms.Label();
            this.gbxFichaAlumno = new System.Windows.Forms.GroupBox();
            this.tbxProvincia = new System.Windows.Forms.TextBox();
            this.labProvincia = new System.Windows.Forms.Label();
            this.tbxTelefono = new System.Windows.Forms.TextBox();
            this.labTelefono = new System.Windows.Forms.Label();
            this.tbxCP = new System.Windows.Forms.TextBox();
            this.labCP = new System.Windows.Forms.Label();
            this.tbxPoblacion = new System.Windows.Forms.TextBox();
            this.labPoblacion = new System.Windows.Forms.Label();
            this.tbxDireccion = new System.Windows.Forms.TextBox();
            this.labDireccion = new System.Windows.Forms.Label();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.labNombre = new System.Windows.Forms.Label();
            this.tbxApellidos = new System.Windows.Forms.TextBox();
            this.labApellidos = new System.Windows.Forms.Label();
            this.tbxCodigo = new System.Windows.Forms.TextBox();
            this.labCodigo = new System.Windows.Forms.Label();
            this.tbxMatricula = new System.Windows.Forms.TextBox();
            this.labMatricula = new System.Windows.Forms.Label();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.gbxFichaAlumno.SuspendLayout();
            this.SuspendLayout();
            // 
            // labFichero
            // 
            this.labFichero.AutoSize = true;
            this.labFichero.Location = new System.Drawing.Point(30, 33);
            this.labFichero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labFichero.Name = "labFichero";
            this.labFichero.Size = new System.Drawing.Size(177, 18);
            this.labFichero.TabIndex = 0;
            this.labFichero.Text = "Contengo nombre fichero";
            // 
            // gbxFichaAlumno
            // 
            this.gbxFichaAlumno.Controls.Add(this.tbxProvincia);
            this.gbxFichaAlumno.Controls.Add(this.labProvincia);
            this.gbxFichaAlumno.Controls.Add(this.tbxTelefono);
            this.gbxFichaAlumno.Controls.Add(this.labTelefono);
            this.gbxFichaAlumno.Controls.Add(this.tbxCP);
            this.gbxFichaAlumno.Controls.Add(this.labCP);
            this.gbxFichaAlumno.Controls.Add(this.tbxPoblacion);
            this.gbxFichaAlumno.Controls.Add(this.labPoblacion);
            this.gbxFichaAlumno.Controls.Add(this.tbxDireccion);
            this.gbxFichaAlumno.Controls.Add(this.labDireccion);
            this.gbxFichaAlumno.Controls.Add(this.tbxNombre);
            this.gbxFichaAlumno.Controls.Add(this.labNombre);
            this.gbxFichaAlumno.Controls.Add(this.tbxApellidos);
            this.gbxFichaAlumno.Controls.Add(this.labApellidos);
            this.gbxFichaAlumno.Controls.Add(this.tbxCodigo);
            this.gbxFichaAlumno.Controls.Add(this.labCodigo);
            this.gbxFichaAlumno.Controls.Add(this.tbxMatricula);
            this.gbxFichaAlumno.Controls.Add(this.labMatricula);
            this.gbxFichaAlumno.Location = new System.Drawing.Point(34, 80);
            this.gbxFichaAlumno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxFichaAlumno.Name = "gbxFichaAlumno";
            this.gbxFichaAlumno.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxFichaAlumno.Size = new System.Drawing.Size(722, 434);
            this.gbxFichaAlumno.TabIndex = 1;
            this.gbxFichaAlumno.TabStop = false;
            this.gbxFichaAlumno.Text = "Ficha de alumno";
            // 
            // tbxProvincia
            // 
            this.tbxProvincia.Location = new System.Drawing.Point(524, 321);
            this.tbxProvincia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxProvincia.Name = "tbxProvincia";
            this.tbxProvincia.Size = new System.Drawing.Size(148, 24);
            this.tbxProvincia.TabIndex = 15;
            this.tbxProvincia.Validating += new System.ComponentModel.CancelEventHandler(this.tbxAlfanumerico_Validating);
            // 
            // labProvincia
            // 
            this.labProvincia.AutoSize = true;
            this.labProvincia.Location = new System.Drawing.Point(414, 321);
            this.labProvincia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labProvincia.Name = "labProvincia";
            this.labProvincia.Size = new System.Drawing.Size(69, 18);
            this.labProvincia.TabIndex = 14;
            this.labProvincia.Text = "Provincia";
            // 
            // tbxTelefono
            // 
            this.tbxTelefono.Location = new System.Drawing.Point(194, 373);
            this.tbxTelefono.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxTelefono.Name = "tbxTelefono";
            this.tbxTelefono.Size = new System.Drawing.Size(112, 24);
            this.tbxTelefono.TabIndex = 13;
            this.tbxTelefono.Validating += new System.ComponentModel.CancelEventHandler(this.tbxNumerico_Validating);
            // 
            // labTelefono
            // 
            this.labTelefono.AutoSize = true;
            this.labTelefono.Location = new System.Drawing.Point(48, 373);
            this.labTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labTelefono.Name = "labTelefono";
            this.labTelefono.Size = new System.Drawing.Size(66, 18);
            this.labTelefono.TabIndex = 12;
            this.labTelefono.Text = "Teléfono";
            // 
            // tbxCP
            // 
            this.tbxCP.Location = new System.Drawing.Point(194, 321);
            this.tbxCP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxCP.Name = "tbxCP";
            this.tbxCP.Size = new System.Drawing.Size(112, 24);
            this.tbxCP.TabIndex = 3;
            this.tbxCP.Validating += new System.ComponentModel.CancelEventHandler(this.tbxNumerico_Validating);
            // 
            // labCP
            // 
            this.labCP.AutoSize = true;
            this.labCP.Location = new System.Drawing.Point(48, 321);
            this.labCP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labCP.Name = "labCP";
            this.labCP.Size = new System.Drawing.Size(100, 18);
            this.labCP.TabIndex = 2;
            this.labCP.Text = "Código postal";
            // 
            // tbxPoblacion
            // 
            this.tbxPoblacion.Location = new System.Drawing.Point(194, 270);
            this.tbxPoblacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxPoblacion.Name = "tbxPoblacion";
            this.tbxPoblacion.Size = new System.Drawing.Size(478, 24);
            this.tbxPoblacion.TabIndex = 11;
            this.tbxPoblacion.Validating += new System.ComponentModel.CancelEventHandler(this.tbxAlfanumerico_Validating);
            // 
            // labPoblacion
            // 
            this.labPoblacion.AutoSize = true;
            this.labPoblacion.Location = new System.Drawing.Point(48, 270);
            this.labPoblacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labPoblacion.Name = "labPoblacion";
            this.labPoblacion.Size = new System.Drawing.Size(74, 18);
            this.labPoblacion.TabIndex = 10;
            this.labPoblacion.Text = "Población";
            // 
            // tbxDireccion
            // 
            this.tbxDireccion.Location = new System.Drawing.Point(194, 219);
            this.tbxDireccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxDireccion.Name = "tbxDireccion";
            this.tbxDireccion.Size = new System.Drawing.Size(478, 24);
            this.tbxDireccion.TabIndex = 9;
            this.tbxDireccion.Validating += new System.ComponentModel.CancelEventHandler(this.tbxAlfanumerico_Validating);
            // 
            // labDireccion
            // 
            this.labDireccion.AutoSize = true;
            this.labDireccion.Location = new System.Drawing.Point(48, 219);
            this.labDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labDireccion.Name = "labDireccion";
            this.labDireccion.Size = new System.Drawing.Size(71, 18);
            this.labDireccion.TabIndex = 8;
            this.labDireccion.Text = "Dirección";
            // 
            // tbxNombre
            // 
            this.tbxNombre.Location = new System.Drawing.Point(194, 167);
            this.tbxNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(478, 24);
            this.tbxNombre.TabIndex = 7;
            this.tbxNombre.Validating += new System.ComponentModel.CancelEventHandler(this.tbxAlfanumerico_Validating);
            // 
            // labNombre
            // 
            this.labNombre.AutoSize = true;
            this.labNombre.Location = new System.Drawing.Point(48, 167);
            this.labNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labNombre.Name = "labNombre";
            this.labNombre.Size = new System.Drawing.Size(62, 18);
            this.labNombre.TabIndex = 6;
            this.labNombre.Text = "Nombre";
            // 
            // tbxApellidos
            // 
            this.tbxApellidos.Location = new System.Drawing.Point(194, 116);
            this.tbxApellidos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxApellidos.Name = "tbxApellidos";
            this.tbxApellidos.Size = new System.Drawing.Size(478, 24);
            this.tbxApellidos.TabIndex = 5;
            this.tbxApellidos.Validating += new System.ComponentModel.CancelEventHandler(this.tbxAlfanumerico_Validating);
            // 
            // labApellidos
            // 
            this.labApellidos.AutoSize = true;
            this.labApellidos.Location = new System.Drawing.Point(48, 116);
            this.labApellidos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labApellidos.Name = "labApellidos";
            this.labApellidos.Size = new System.Drawing.Size(67, 18);
            this.labApellidos.TabIndex = 4;
            this.labApellidos.Text = "Apellidos";
            // 
            // tbxCodigo
            // 
            this.tbxCodigo.Location = new System.Drawing.Point(524, 65);
            this.tbxCodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxCodigo.Name = "tbxCodigo";
            this.tbxCodigo.Size = new System.Drawing.Size(148, 24);
            this.tbxCodigo.TabIndex = 3;
            this.tbxCodigo.Validating += new System.ComponentModel.CancelEventHandler(this.tbxAlfanumerico_Validating);
            // 
            // labCodigo
            // 
            this.labCodigo.AutoSize = true;
            this.labCodigo.Location = new System.Drawing.Point(414, 65);
            this.labCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labCodigo.Name = "labCodigo";
            this.labCodigo.Size = new System.Drawing.Size(98, 18);
            this.labCodigo.TabIndex = 2;
            this.labCodigo.Text = "Código curso";
            // 
            // tbxMatricula
            // 
            this.tbxMatricula.Location = new System.Drawing.Point(194, 65);
            this.tbxMatricula.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxMatricula.Name = "tbxMatricula";
            this.tbxMatricula.Size = new System.Drawing.Size(112, 24);
            this.tbxMatricula.TabIndex = 1;
            this.tbxMatricula.Validating += new System.ComponentModel.CancelEventHandler(this.tbxNumerico_Validating);
            // 
            // labMatricula
            // 
            this.labMatricula.AutoSize = true;
            this.labMatricula.Location = new System.Drawing.Point(48, 65);
            this.labMatricula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labMatricula.Name = "labMatricula";
            this.labMatricula.Size = new System.Drawing.Size(126, 18);
            this.labMatricula.TabIndex = 0;
            this.labMatricula.Text = "Número matrícula";
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(228, 540);
            this.btnGrabar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(178, 44);
            this.btnGrabar.TabIndex = 2;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(578, 540);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(178, 44);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // frmInscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 601);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.gbxFichaAlumno);
            this.Controls.Add(this.labFichero);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmInscripcion";
            this.Text = "Inscripciones";
            this.Load += new System.EventHandler(this.frmInscripcion_Load);
            this.gbxFichaAlumno.ResumeLayout(false);
            this.gbxFichaAlumno.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labFichero;
        private System.Windows.Forms.GroupBox gbxFichaAlumno;
        private System.Windows.Forms.TextBox tbxProvincia;
        private System.Windows.Forms.Label labProvincia;
        private System.Windows.Forms.TextBox tbxTelefono;
        private System.Windows.Forms.Label labTelefono;
        private System.Windows.Forms.TextBox tbxCP;
        private System.Windows.Forms.Label labCP;
        private System.Windows.Forms.TextBox tbxPoblacion;
        private System.Windows.Forms.Label labPoblacion;
        private System.Windows.Forms.TextBox tbxDireccion;
        private System.Windows.Forms.Label labDireccion;
        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.Label labNombre;
        private System.Windows.Forms.TextBox tbxApellidos;
        private System.Windows.Forms.Label labApellidos;
        private System.Windows.Forms.TextBox tbxCodigo;
        private System.Windows.Forms.Label labCodigo;
        private System.Windows.Forms.TextBox tbxMatricula;
        private System.Windows.Forms.Label labMatricula;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnVolver;
    }
}